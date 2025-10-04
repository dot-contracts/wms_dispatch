// WMS API Service - uses the .NET Web API endpoints
import { useAuth } from '../context/AuthContext';

// API Configuration - using proxy for development, direct URL for production  
const API_BASE_URL = process.env.NODE_ENV === 'development' ? '' : 'https://wmsandroidapi-w74du.ondigitalocean.app';

// Updated interfaces to match .NET API structure

export interface Parcel {
  id: string;
  createdAt: string;
  updatedAt?: string;
  waybillNumber: string;
  qrCode?: string;
  dispatchedAt?: string;
  dispatchTrackingCode?: string;
  createdById: number;
  sender: string;
  senderTelephone: string;
  receiver: string;
  receiverTelephone: string;
  destination: string;
  quantity: number;
  description: string;
  amount: number;
  rate: number;
  paymentMethods: string;
  totalAmount: number;
  totalRate: number;
  status: number; // 0=Pending, 1=Finalized, 2=InTransit, 3=Delivered, 4=Cancelled
  createdBy?: any;
}

export interface Dispatch {
  id: string;
  dispatchCode: string;
  destination: string;
  dispatchTime: string;
  sourceBranch: string;
  vehicleNumber: string;
  driver: string;
  status: string;
  totalParcels?: number;
  totalAmount?: number;
  parcelIds: string[] | { $values: string[] };
  parcels?: Parcel[];
}

export interface CreateDispatchRequest {
  dispatchCode: string;
  sourceBranch: string;
  destination: string;
  vehicleNumber: string;
  driver: string;
  parcelIds: string[];
}

export interface User {
  id: number;
  username: string;
  email?: string;
  firstName?: string;
  lastName?: string;
  roles: string[];
  role?: {
    id: number;
    name: string;
  };
  branch?: {
    id: number;
    name: string;
  } | string;
  createdAt?: string;
  branchId?: number;
  roleId?: number;
}

export interface ContractCustomer {
  id: number;
  name: string;
  companyName?: string;
  email?: string;
  phone?: string;
  address?: string;
  contactPerson?: string;
  contractNumber?: string;
  paymentTerms: string;
  taxRate: number;
  isActive: boolean;
  createdAt: string;
  updatedAt: string;
  createdBy?: number;
  apiUserId?: number;
  apiUsername?: string;
}

export interface Invoice {
  id: number;
  invoiceNumber: string;
  customerId: number;
  customer?: ContractCustomer;
  issueDate: string;
  dueDate: string;
  status: 'draft' | 'sent' | 'paid' | 'overdue' | 'cancelled';
  subtotal: number;
  taxAmount: number;
  totalAmount: number;
  notes?: string;
  createdBy?: number;
  apiUserId?: number;
  apiUsername?: string;
  createdAt: string;
  updatedAt: string;
  items?: InvoiceItem[];
}

export interface InvoiceItem {
  id: number;
  invoiceId: number;
  parcelId: string;
  waybillNumber: string;
  description: string;
  quantity: number;
  unitPrice: number;
  totalPrice: number;
  createdAt: string;
}

class WMSApiService {
  private getHeaders(): Record<string, string> {
    const token = localStorage.getItem('auth_token') || sessionStorage.getItem('auth_token');
    return {
      'Content-Type': 'application/json',
      'Accept': 'application/json',
      ...(token && { 'Authorization': `Bearer ${token}` }),
    };
  }

  // Parcels API methods
  async getParcels(branch?: string, filters?: {
    status?: string;
    destination?: string;
    dateFrom?: string;
    dateTo?: string;
    waybillNumber?: string;
    paymentMode?: string;
  }): Promise<Parcel[]> {
    try {
      // If searching by waybill number, use specific endpoint
      if (filters?.waybillNumber) {
        return this.getParcelByWaybill(filters.waybillNumber).then(p => p ? [p] : []);
      }

      const url = `${API_BASE_URL}/api/Parcels`;
      const params = new URLSearchParams();
      if (branch) {
        params.append('branchName', branch);
      }

      const response = await fetch(`${url}?${params}`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        throw new Error(`Failed to fetch parcels: ${response.status}`);
      }

      const rawData = await response.json();

      // Handle the { "$id": ..., "$values": [...] } format
      let parcels: Parcel[];
      if (typeof rawData === 'object' && rawData !== null && '$values' in rawData && Array.isArray(rawData.$values)) {
        parcels = rawData.$values;
      } else if (Array.isArray(rawData)) {
        parcels = rawData;
      } else {
        console.warn('API returned data in an unexpected format:', typeof rawData);
        return [];
      }

      // Apply client-side filtering for unsupported API filters
      if (filters) {
        parcels = parcels.filter((parcel: Parcel) => {
          if (filters.status && filters.status !== 'all') {
            const statusMap: Record<string, number> = {
              'pending': 0,
              'finalized': 1, 
              'in-transit': 2,
              'delivered': 3,
              'cancelled': 4
            };
            if (parcel.status !== statusMap[filters.status]) return false;
          }
          if (filters.destination && !parcel.destination.toLowerCase().includes(filters.destination.toLowerCase())) return false;
          if (filters.dateFrom && new Date(parcel.createdAt) < new Date(filters.dateFrom)) return false;
          if (filters.dateTo && new Date(parcel.createdAt) > new Date(filters.dateTo)) return false;
          if (filters.paymentMode && !parcel.paymentMethods.toLowerCase().includes(filters.paymentMode.toLowerCase())) return false;
          return true;
        });
      }

      return parcels;
    } catch (error) {
      console.error('Error fetching parcels:', error);
      throw new Error(`Failed to connect to WMS API: ${error}`);
    }
  }

  async getParcelById(parcelId: string): Promise<Parcel | null> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Parcels/${parcelId}`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        if (response.status === 404) {
          return null;
        }
        throw new Error(`Failed to fetch parcel: ${response.status}`);
      }

      return await response.json();
    } catch (error) {
      console.error(`Error fetching parcel ${parcelId}:`, error);
      throw error;
    }
  }

  async getParcelByWaybill(waybillNumber: string): Promise<Parcel | null> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Parcels/waybill/${waybillNumber}`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        if (response.status === 404) {
          return null;
        }
        throw new Error(`Failed to fetch parcel by waybill: ${response.status}`);
      }

      return await response.json();
    } catch (error) {
      console.error(`Error fetching parcel by waybill ${waybillNumber}:`, error);
      throw error;
    }
  }

  async getPendingParcels(dateFilter?: string, branch?: string): Promise<Parcel[]> {
    try {
      const url = `${API_BASE_URL}/api/parcels/pending`;
      const params = new URLSearchParams();
      if (branch) {
        params.append('branchName', branch);
      }

      const response = await fetch(`${url}?${params}`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        throw new Error(`Failed to fetch pending parcels: ${response.status}`);
      }

      const data = await response.json();
      let parcels = data.$values || data;

      if (dateFilter) {
        // Filter parcels by date on the client side
        parcels = parcels.filter((parcel: Parcel) => {
          if (parcel.createdAt) {
            try {
              const parcelDate = new Date(parcel.createdAt.replace('Z', '+00:00'));
              return parcelDate.toISOString().split('T')[0] === dateFilter;
            } catch (error) {
              console.warn(`Could not parse date for parcel ${parcel.id}:`, error);
              return false;
            }
          }
          return false;
        });
      }

      return parcels;
    } catch (error) {
      console.error('Error fetching pending parcels:', error);
      throw error;
    }
  }

  async updateParcel(parcelId: string, parcelData: Partial<Parcel>): Promise<boolean> {
    try {
      // Clean up the data
      const cleanedData = Object.fromEntries(
        Object.entries(parcelData).filter(([_, value]) => value !== null)
      );

      const response = await fetch(`${API_BASE_URL}/api/parcels/${parcelId}`, {
        method: 'PUT',
        headers: this.getHeaders(),
        body: JSON.stringify(cleanedData),
      });

      if (response.ok) {
        console.log(`Successfully updated parcel ${parcelId}`);
        return true;
      } else {
        console.error(`Failed to update parcel ${parcelId}: ${response.status} - ${await response.text()}`);
        return false;
      }
    } catch (error) {
      console.error(`Error updating parcel ${parcelId}:`, error);
      return false;
    }
  }

  async updateParcelStatus(parcelId: string, status: number): Promise<boolean> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/parcels/${parcelId}/status`, {
        method: 'PUT',
        headers: this.getHeaders(),
        body: JSON.stringify({ Status: status }),
      });

      if (response.ok) {
        console.log(`Successfully updated parcel ${parcelId} status to ${status}`);
        return true;
      } else {
        console.error(`Failed to update parcel ${parcelId} status: ${response.status} - ${await response.text()}`);
        return false;
      }
    } catch (error) {
      console.error(`Error updating parcel ${parcelId} status:`, error);
      return false;
    }
  }

  async deleteParcel(parcelId: string): Promise<boolean> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/parcels/${parcelId}`, {
        method: 'DELETE',
        headers: this.getHeaders(),
      });

      if (response.ok) {
        console.log(`Successfully deleted parcel ${parcelId}`);
        return true;
      } else {
        console.error(`Failed to delete parcel ${parcelId}: ${response.status} - ${await response.text()}`);
        return false;
      }
    } catch (error) {
      console.error(`Error deleting parcel ${parcelId}:`, error);
      return false;
    }
  }

  // Helper method to normalize parcelIds structure
  private normalizeParcelIds(parcelIds: string[] | { $values: string[] } | undefined): string[] {
    if (!parcelIds) return [];
    if (Array.isArray(parcelIds)) return parcelIds;
    if (typeof parcelIds === 'object' && parcelIds.$values && Array.isArray(parcelIds.$values)) {
      return parcelIds.$values;
    }
    return [];
  }

  // Dispatches API methods
  async getDispatches(branch?: string): Promise<Dispatch[]> {
    try {
      let url = `${API_BASE_URL}/api/Dispatches`;
      if (branch) {
        url = `${API_BASE_URL}/api/Dispatches/branch/${branch}`;
      }

      const response = await fetch(url, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        throw new Error(`Failed to fetch dispatches: ${response.status}`);
      }

      const data = await response.json();
      const dispatches = data.$values || data;
      
      // Normalize parcelIds structure for all dispatches
      return dispatches.map((dispatch: Dispatch) => ({
        ...dispatch,
        parcelIds: this.normalizeParcelIds(dispatch.parcelIds)
      }));
    } catch (error) {
      console.error('Error fetching dispatches:', error);
      throw error;
    }
  }

  async getDispatchById(dispatchId: string): Promise<Dispatch | null> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Dispatches/${dispatchId}/note`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        if (response.status === 404) {
          return null;
        }
        throw new Error(`Failed to fetch dispatch: ${response.status}`);
      }

      const data = await response.json();
      const dispatch = data.$values || data;
      
      // Normalize parcelIds structure
      if (dispatch) {
        return {
          ...dispatch,
          parcelIds: this.normalizeParcelIds(dispatch.parcelIds)
        };
      }
      
      return dispatch;
    } catch (error) {
      console.error(`Error fetching dispatch ${dispatchId}:`, error);
      throw error;
    }
  }

  async createDispatch(dispatchData: {
    dispatchCode: string;
    sourceBranch: string;
    destination: string;
    driver_name: string;
    vehicle_registration: string;
    parcel_ids: string[];
  }): Promise<Dispatch | null> {
    try {
      // Use the .NET API structure for creating dispatch
      const createDispatchRequest = {
        dispatchCode: dispatchData.dispatchCode,
        sourceBranch: dispatchData.sourceBranch,
        destination: dispatchData.destination,
        vehicleNumber: dispatchData.vehicle_registration,
        driver: dispatchData.driver_name,
        parcelIds: dispatchData.parcel_ids
      };

      const response = await fetch(`${API_BASE_URL}/api/Dispatches/create`, {
        method: 'POST',
        headers: this.getHeaders(),
        body: JSON.stringify(createDispatchRequest),
        signal: AbortSignal.timeout(30000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Dispatch creation failed:', response.status, errorText);
        throw new Error(`Failed to create dispatch: ${response.status}`);
      }

      return await response.json();
    } catch (error) {
      console.error('Error creating dispatch:', error);
      throw error;
    }
  }

  // Users API methods
  async getUserById(userId: number): Promise<User | null> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Users/${userId}`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(10000),
      });

      if (!response.ok) {
        if (response.status === 404) {
          return null;
        }
        throw new Error(`Failed to fetch user: ${response.status}`);
      }

      return await response.json();
    } catch (error) {
      console.error(`Error fetching user ${userId}:`, error);
      return null;
    }
  }

  async getUsers(): Promise<User[]> {
    try {
      const users: User[] = [];
      const roles = ['Admin', 'Manager', 'Clerk', 'Client', 'Driver', 'Accountant'];

      // Get users by role since /api/users might not work
      for (const role of roles) {
        try {
          const response = await fetch(`${API_BASE_URL}/api/users/byRole/${role}`, {
            headers: this.getHeaders(),
            signal: AbortSignal.timeout(10000),
          });

          if (response.ok) {
            const roleData = await response.json();
            const roleUsers = roleData.$values || roleData;
            users.push(...roleUsers);
          }
        } catch (error) {
          console.warn(`Failed to fetch users with role ${role}:`, error);
        }
      }

      // Remove duplicates by user ID
      const uniqueUsers = users.filter((user, index, self) =>
        index === self.findIndex(u => u.id === user.id)
      );

      return uniqueUsers;
    } catch (error) {
      console.error('Error fetching users:', error);
      throw error;
    }
  }

  async createUser(userData: {
    username: string;
    email: string;
    firstName: string;
    lastName: string;
    password: string;
    roleId: number;
    branchId?: number;
  }): Promise<User | null> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Users`, {
        method: 'POST',
        headers: this.getHeaders(),
        body: JSON.stringify(userData),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('User creation failed:', response.status, errorText);
        throw new Error(`Failed to create user: ${response.status}`);
      }

      return await response.json();
    } catch (error) {
      console.error('Error creating user:', error);
      throw error;
    }
  }

  async updateUser(userId: number, userData: {
    username?: string;
    email?: string;
    firstName?: string;
    lastName?: string;
    roleId?: number;
    branchId?: number;
  }): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Users/${userId}`, {
        method: 'PUT',
        headers: this.getHeaders(),
        body: JSON.stringify(userData),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('User update failed:', response.status, errorText);
        throw new Error(`Failed to update user: ${response.status}`);
      }
    } catch (error) {
      console.error('Error updating user:', error);
      throw error;
    }
  }

  async changeUserPassword(userId: number, newPassword: string): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Users/${userId}/change-password`, {
        method: 'PUT',
        headers: this.getHeaders(),
        body: JSON.stringify({ newPassword }),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Password change failed:', response.status, errorText);
        throw new Error(`Failed to change password: ${response.status}`);
      }
    } catch (error) {
      console.error('Error changing password:', error);
      throw error;
    }
  }

  async deleteUser(userId: number): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Users/${userId}`, {
        method: 'DELETE',
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('User deletion failed:', response.status, errorText);
        throw new Error(`Failed to delete user: ${response.status}`);
      }
    } catch (error) {
      console.error('Error deleting user:', error);
      throw error;
    }
  }

  async activateUser(userId: number): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Users/${userId}/activate`, {
        method: 'PUT',
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('User activation failed:', response.status, errorText);
        throw new Error(`Failed to activate user: ${response.status}`);
      }
    } catch (error) {
      console.error('Error activating user:', error);
      throw error;
    }
  }

  async deactivateUser(userId: number): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Users/${userId}/deactivate`, {
        method: 'PUT',
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('User deactivation failed:', response.status, errorText);
        throw new Error(`Failed to deactivate user: ${response.status}`);
      }
    } catch (error) {
      console.error('Error deactivating user:', error);
      throw error;
    }
  }

  // Branches API methods
  async getBranches(): Promise<{ id: number; name: string; address?: string; phone?: string; email?: string }[]> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Branches`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        throw new Error(`Failed to fetch branches: ${response.status}`);
      }

      const data = await response.json();
      return data.$values || data;
    } catch (error) {
      console.error('Error fetching branches:', error);
      throw error;
    }
  }

  // Analytics methods
  async getParcelCountForDate(date: Date, branch?: string): Promise<number> {
    try {
      const params = new URLSearchParams();
      params.append('date', date.toISOString().split('T')[0]);
      if (branch) {
        params.append('branchName', branch);
      }

      const response = await fetch(`${API_BASE_URL}/api/Parcels/count?${params}`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(10000),
      });

      if (!response.ok) {
        return 0;
      }

      const data = await response.json();
      return data.count || 0;
    } catch (error) {
      console.error('Error fetching parcel count:', error);
      return 0;
    }
  }

  async getTotalSalesForDate(date: Date, branch?: string): Promise<number> {
    try {
      const params = new URLSearchParams();
      params.append('date', date.toISOString().split('T')[0]);
      if (branch) {
        params.append('branchName', branch);
      }

      const response = await fetch(`${API_BASE_URL}/api/Parcels/sales?${params}`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(10000),
      });

      if (!response.ok) {
        return 0;
      }

      const data = await response.json();
      return data.totalSales || 0;
    } catch (error) {
      console.error('Error fetching total sales:', error);
      return 0;
    }
  }

  // Contract Customers API methods
  async getContractCustomers(): Promise<ContractCustomer[]> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/ContractCustomers`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        throw new Error(`Failed to fetch contract customers: ${response.status}`);
      }

      const data = await response.json();
      return data.$values || data;
    } catch (error) {
      console.error('Error fetching contract customers:', error);
      throw error;
    }
  }

  async createContractCustomer(customerData: Omit<ContractCustomer, 'id' | 'createdAt' | 'updatedAt'>): Promise<ContractCustomer | null> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/ContractCustomers`, {
        method: 'POST',
        headers: this.getHeaders(),
        body: JSON.stringify(customerData),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Contract customer creation failed:', response.status, errorText);
        throw new Error(`Failed to create contract customer: ${response.status}`);
      }

      return await response.json();
    } catch (error) {
      console.error('Error creating contract customer:', error);
      throw error;
    }
  }

  async updateContractCustomer(customerId: number, customerData: Partial<ContractCustomer>): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/ContractCustomers/${customerId}`, {
        method: 'PUT',
        headers: this.getHeaders(),
        body: JSON.stringify(customerData),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Contract customer update failed:', response.status, errorText);
        throw new Error(`Failed to update contract customer: ${response.status}`);
      }
    } catch (error) {
      console.error('Error updating contract customer:', error);
      throw error;
    }
  }

  async deleteContractCustomer(customerId: number): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/ContractCustomers/${customerId}`, {
        method: 'DELETE',
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Contract customer deletion failed:', response.status, errorText);
        throw new Error(`Failed to delete contract customer: ${response.status}`);
      }
    } catch (error) {
      console.error('Error deleting contract customer:', error);
      throw error;
    }
  }

  // Invoices API methods
  async getInvoices(): Promise<Invoice[]> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Invoices`, {
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        throw new Error(`Failed to fetch invoices: ${response.status}`);
      }

      const data = await response.json();
      return data.$values || data;
    } catch (error) {
      console.error('Error fetching invoices:', error);
      throw error;
    }
  }

  async createInvoice(invoiceData: Omit<Invoice, 'id' | 'createdAt' | 'updatedAt'>): Promise<Invoice | null> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Invoices`, {
        method: 'POST',
        headers: this.getHeaders(),
        body: JSON.stringify(invoiceData),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Invoice creation failed:', response.status, errorText);
        throw new Error(`Failed to create invoice: ${response.status}`);
      }

      return await response.json();
    } catch (error) {
      console.error('Error creating invoice:', error);
      throw error;
    }
  }

  async updateInvoice(invoiceId: number, invoiceData: Partial<Invoice>): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Invoices/${invoiceId}`, {
        method: 'PUT',
        headers: this.getHeaders(),
        body: JSON.stringify(invoiceData),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Invoice update failed:', response.status, errorText);
        throw new Error(`Failed to update invoice: ${response.status}`);
      }
    } catch (error) {
      console.error('Error updating invoice:', error);
      throw error;
    }
  }

  async deleteInvoice(invoiceId: number): Promise<void> {
    try {
      const response = await fetch(`${API_BASE_URL}/api/Invoices/${invoiceId}`, {
        method: 'DELETE',
        headers: this.getHeaders(),
        signal: AbortSignal.timeout(15000),
      });

      if (!response.ok) {
        const errorText = await response.text();
        console.error('Invoice deletion failed:', response.status, errorText);
        throw new Error(`Failed to delete invoice: ${response.status}`);
      }
    } catch (error) {
      console.error('Error deleting invoice:', error);
      throw error;
    }
  }
}

// Export a singleton instance
export const wmsApi = new WMSApiService();

// Hook for using the WMS API service with authentication context
export const useWMSApi = () => {
  const { user, token } = useAuth();

  return {
    api: wmsApi,
    user,
    token,
    isAuthenticated: !!user && !!token,
  };
};