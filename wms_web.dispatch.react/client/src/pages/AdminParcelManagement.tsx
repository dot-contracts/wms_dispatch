import React, { useState, useEffect, useCallback } from 'react';
import { useAuth } from '../context/AuthContext';
import { wmsApi, Parcel } from '../services/wmsApi';
import { 
  Package, 
  Search, 
  RefreshCw, 
  Edit, 
  Trash2,
  AlertTriangle,
  CheckCircle,
  X,
  FileText,
  Calendar,
  User,
  MapPin,
  Phone,
  DollarSign,
  Settings,
  Save,
  RotateCcw
} from 'lucide-react';
import { FilterPanel, FilterField } from '../components/ui';

// Status constants matching the API
const PARCEL_STATUS = {
  PENDING: 0,
  FINALIZED: 1,
  IN_TRANSIT: 2,
  DELIVERED: 3,
  CANCELLED: 4
} as const;

const STATUS_LABELS: Record<number, string> = {
  [PARCEL_STATUS.PENDING]: 'Pending',
  [PARCEL_STATUS.FINALIZED]: 'Finalized',
  [PARCEL_STATUS.IN_TRANSIT]: 'In Transit',
  [PARCEL_STATUS.DELIVERED]: 'Delivered',
  [PARCEL_STATUS.CANCELLED]: 'Cancelled'
};

const STATUS_COLORS: Record<number, string> = {
  [PARCEL_STATUS.PENDING]: 'bg-warning-100 text-warning-800 border-warning-200',
  [PARCEL_STATUS.FINALIZED]: 'bg-primary-100 text-primary-800 border-primary-200',
  [PARCEL_STATUS.IN_TRANSIT]: 'bg-info-100 text-info-800 border-info-200',
  [PARCEL_STATUS.DELIVERED]: 'bg-success-100 text-success-800 border-success-200',
  [PARCEL_STATUS.CANCELLED]: 'bg-error-100 text-error-800 border-error-200'
};

interface ParcelEditForm {
  waybillNumber: string;
  status: number;
  paymentMethods: string;
  sender: string;
  senderTelephone: string;
  receiver: string;
  receiverTelephone: string;
  destination: string;
  quantity: number;
  amount: number;
  description: string;
}

interface ParcelFilterState {
  waybillNumber: string;
  createdBy: string;
  dateCreated: string;
  status: string;
  destination: string;
  paymentMethod: string;
  amountRange: { from: string; to: string };
  dateRange: { from: string; to: string };
}

const AdminParcelManagement: React.FC = () => {
  const { user } = useAuth();
  const [parcels, setParcels] = useState<Parcel[]>([]);
  const [filteredParcels, setFilteredParcels] = useState<Parcel[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [successMessage, setSuccessMessage] = useState<string | null>(null);
  
  // Pagination state
  const [currentPage, setCurrentPage] = useState(1);
  const [itemsPerPage] = useState(10);
  
  // Dropdown options for edit modal
  const [availableDestinations, setAvailableDestinations] = useState<string[]>([]);
  const [availablePaymentMethods, setAvailablePaymentMethods] = useState<string[]>([]);
  const [allUsers, setAllUsers] = useState<any[]>([]);
  
  // Edit Modal State
  const [editingParcel, setEditingParcel] = useState<Parcel | null>(null);
  const [editForm, setEditForm] = useState<ParcelEditForm | null>(null);
  const [saving, setSaving] = useState(false);
  
  // Delete Confirmation State
  const [deletingParcel, setDeletingParcel] = useState<Parcel | null>(null);
  
  // Filter State
  const [filters, setFilters] = useState<ParcelFilterState>({
    waybillNumber: '',
    createdBy: '',
    dateCreated: '',
    status: '',
    destination: '',
    paymentMethod: '',
    amountRange: { from: '', to: '' },
    dateRange: { from: '', to: '' }
  });
  
  // Available clerks for filter dropdown
  const [clerks, setClerks] = useState<{ id: number; username: string }[]>([]);

  // Filter fields configuration
  const filterFields: FilterField[] = [
    {
      key: 'waybillNumber',
      label: 'Waybill Number',
      type: 'text',
      placeholder: 'Search waybill...',
      icon: <Search className="w-4 h-4" />
    },
    {
      key: 'createdBy',
      label: 'Created By',
      type: 'select',
      placeholder: 'Select clerk',
      options: [
        { value: '', label: 'All Clerks' },
        ...clerks.map(clerk => ({ value: clerk.username, label: clerk.username }))
      ],
      icon: <User className="w-4 h-4" />
    },
    {
      key: 'status',
      label: 'Status',
      type: 'select',
      placeholder: 'Select status',
      options: [
        { value: '', label: 'All Statuses' },
        { value: 'pending', label: 'Pending' },
        { value: 'finalized', label: 'Finalized' },
        { value: 'in-transit', label: 'In Transit' },
        { value: 'delivered', label: 'Delivered' },
        { value: 'cancelled', label: 'Cancelled' }
      ]
    },
    {
      key: 'destination',
      label: 'Destination',
      type: 'select',
      placeholder: 'Select destination',
      options: [
        { value: '', label: 'All Destinations' },
        ...availableDestinations.map(dest => ({ value: dest, label: dest }))
      ],
      icon: <MapPin className="w-4 h-4" />
    },
    {
      key: 'paymentMethod',
      label: 'Payment Method',
      type: 'select',
      placeholder: 'Select payment method',
      options: [
        { value: '', label: 'All Payment Methods' },
        ...availablePaymentMethods.map(method => ({ value: method, label: method }))
      ],
      icon: <DollarSign className="w-4 h-4" />
    },
    {
      key: 'amountRange',
      label: 'Amount Range',
      type: 'dateRange',
      placeholder: 'Select amount range'
    },
    {
      key: 'dateRange',
      label: 'Date Range',
      type: 'dateRange',
      placeholder: 'Select date range',
      icon: <Calendar className="w-4 h-4" />
    }
  ];

  // Check admin access
  useEffect(() => {
    if (user && user.role !== 'admin') {
      setError('Access denied. Admin privileges required.');
      return;
    }
  }, [user]);

  // Load parcels and clerks
  const loadParcels = useCallback(async () => {
    if (!user || user.role !== 'admin') return;
    
    try {
      setLoading(true);
      setError(null);
      
      // Load all parcels (admin can see all)
      const allParcels = await wmsApi.getParcels();
      setParcels(allParcels);
      setFilteredParcels(allParcels);
      
      // Extract unique destinations and payment methods for dropdowns
      const destinations = Array.from(new Set(allParcels.map(p => p.destination).filter(Boolean)));
      const paymentMethods = Array.from(new Set(allParcels.map(p => p.paymentMethods).filter(Boolean)));
      setAvailableDestinations(destinations);
      setAvailablePaymentMethods(paymentMethods);
      
      // Load all users for filter dropdown and created by mapping
      try {
        const users = await wmsApi.getUsers();
        setAllUsers(users);
        
        // Map user names to parcels that don't have createdBy populated
        const updatedParcels = allParcels.map(parcel => {
          if (!parcel.createdBy && parcel.createdById) {
            const user = users.find(u => u.id === parcel.createdById);
            if (user) {
              return { ...parcel, createdBy: { username: user.firstName && user.lastName ? `${user.firstName} ${user.lastName}` : user.username } };
            }
          }
          return parcel;
        });
        
        setParcels(updatedParcels);
        setFilteredParcels(updatedParcels);
        
        // Set clerks for filter
        const clerkUsers = users.filter(u => u.role?.name === 'Clerk' || u.roles?.includes('clerk'));
        setClerks(clerkUsers.map(u => ({ id: u.id, username: u.firstName && u.lastName ? `${u.firstName} ${u.lastName}` : u.username })));
      } catch (err) {
        console.warn('Could not load users for mapping:', err);
      }
      
    } catch (err) {
      setError('Failed to load parcels');
      console.error('Error loading parcels:', err);
    } finally {
      setLoading(false);
    }
  }, [user]);

  useEffect(() => {
    loadParcels();
  }, [loadParcels]);

  // Apply filters
  useEffect(() => {
    let filtered = [...parcels];
    
    if (filters.waybillNumber) {
      filtered = filtered.filter(p => 
        p.waybillNumber.toLowerCase().includes(filters.waybillNumber.toLowerCase())
      );
    }
    
    if (filters.createdBy) {
      filtered = filtered.filter(p => 
        p.createdBy?.username === filters.createdBy ||
        p.createdById.toString() === filters.createdBy
      );
    }
    
    if (filters.dateCreated) {
      filtered = filtered.filter(p => {
        const parcelDate = new Date(p.createdAt).toISOString().split('T')[0];
        return parcelDate === filters.dateCreated;
      });
    }
    
    if (filters.status && filters.status !== 'all') {
      const statusMap: Record<string, number> = {
        'pending': PARCEL_STATUS.PENDING,
        'finalized': PARCEL_STATUS.FINALIZED,
        'in-transit': PARCEL_STATUS.IN_TRANSIT,
        'delivered': PARCEL_STATUS.DELIVERED,
        'cancelled': PARCEL_STATUS.CANCELLED
      };
      filtered = filtered.filter(p => p.status === statusMap[filters.status]);
    }

    if (filters.destination) {
      filtered = filtered.filter(p => p.destination === filters.destination);
    }

    if (filters.paymentMethod) {
      filtered = filtered.filter(p => p.paymentMethods === filters.paymentMethod);
    }

    if (filters.amountRange.from || filters.amountRange.to) {
      filtered = filtered.filter(p => {
        const amount = p.amount;
        const from = filters.amountRange.from ? Number(filters.amountRange.from) : 0;
        const to = filters.amountRange.to ? Number(filters.amountRange.to) : Infinity;
        return amount >= from && amount <= to;
      });
    }

    if (filters.dateRange.from || filters.dateRange.to) {
      filtered = filtered.filter(p => {
        const parcelDate = new Date(p.createdAt);
        const from = filters.dateRange.from ? new Date(filters.dateRange.from) : new Date(0);
        const to = filters.dateRange.to ? new Date(filters.dateRange.to) : new Date();
        return parcelDate >= from && parcelDate <= to;
      });
    }
    
    setFilteredParcels(filtered);
    setCurrentPage(1); // Reset to first page when filters change
  }, [parcels, filters]);

  // Handle filter changes
  const handleFilterChange = (key: string, value: string | { from: string; to: string }) => {
    setFilters(prev => ({ ...prev, [key]: value }));
  };

  // Clear all filters
  const clearFilters = () => {
    setFilters({
      waybillNumber: '',
      createdBy: '',
      dateCreated: '',
      status: '',
      destination: '',
      paymentMethod: '',
      amountRange: { from: '', to: '' },
      dateRange: { from: '', to: '' }
    });
  };

  // Generate active filter chips
  const getActiveFilterChips = () => {
    const chips: any[] = [];

    if (filters.waybillNumber) {
      chips.push({
        key: 'waybillNumber',
        label: 'Waybill',
        value: filters.waybillNumber,
        onRemove: () => handleFilterChange('waybillNumber', '')
      });
    }

    if (filters.createdBy) {
      chips.push({
        key: 'createdBy',
        label: 'Created By',
        value: filters.createdBy,
        onRemove: () => handleFilterChange('createdBy', '')
      });
    }

    if (filters.status) {
      const statusLabel = filterFields.find(f => f.key === 'status')?.options?.find(o => o.value === filters.status)?.label || filters.status;
      chips.push({
        key: 'status',
        label: 'Status',
        value: statusLabel,
        onRemove: () => handleFilterChange('status', '')
      });
    }

    if (filters.destination) {
      chips.push({
        key: 'destination',
        label: 'Destination',
        value: filters.destination,
        onRemove: () => handleFilterChange('destination', '')
      });
    }

    if (filters.paymentMethod) {
      chips.push({
        key: 'paymentMethod',
        label: 'Payment Method',
        value: filters.paymentMethod,
        onRemove: () => handleFilterChange('paymentMethod', '')
      });
    }

    if (filters.amountRange.from || filters.amountRange.to) {
      const rangeValue = `${filters.amountRange.from || '0'} - ${filters.amountRange.to || '∞'}`;
      chips.push({
        key: 'amountRange',
        label: 'Amount Range',
        value: rangeValue,
        onRemove: () => handleFilterChange('amountRange', { from: '', to: '' })
      });
    }

    if (filters.dateRange.from || filters.dateRange.to) {
      const rangeValue = `${filters.dateRange.from || 'Start'} - ${filters.dateRange.to || 'End'}`;
      chips.push({
        key: 'dateRange',
        label: 'Date Range',
        value: rangeValue,
        onRemove: () => handleFilterChange('dateRange', { from: '', to: '' })
      });
    }

    return chips;
  };

  // Handle quick status update
  const handleQuickStatusUpdate = async (parcelId: string, newStatus: number) => {
    try {
      const success = await wmsApi.updateParcelStatus(parcelId, newStatus);
      if (success) {
        setParcels(prev => prev.map(p => 
          p.id === parcelId ? { ...p, status: newStatus } : p
        ));
        setSuccessMessage(`Parcel status updated to ${STATUS_LABELS[newStatus]}`);
        setTimeout(() => setSuccessMessage(null), 3000);
      } else {
        setError('Failed to update parcel status');
        setTimeout(() => setError(null), 3000);
      }
    } catch (err) {
      setError('Failed to update parcel status');
      setTimeout(() => setError(null), 3000);
    }
  };

  // Open edit modal
  const openEditModal = (parcel: Parcel) => {
    setEditingParcel(parcel);
    setEditForm({
      waybillNumber: parcel.waybillNumber,
      status: parcel.status,
      paymentMethods: parcel.paymentMethods,
      sender: parcel.sender,
      senderTelephone: parcel.senderTelephone,
      receiver: parcel.receiver,
      receiverTelephone: parcel.receiverTelephone,
      destination: parcel.destination,
      quantity: parcel.quantity,
      amount: parcel.amount,
      description: parcel.description
    });
  };

  // Close edit modal
  const closeEditModal = () => {
    setEditingParcel(null);
    setEditForm(null);
  };

  // Handle edit form changes
  const handleEditFormChange = (field: keyof ParcelEditForm, value: string | number) => {
    if (!editForm) return;
    setEditForm(prev => prev ? { ...prev, [field]: value } : null);
  };

  // Reset edit form
  const resetEditForm = () => {
    if (!editingParcel) return;
    setEditForm({
      waybillNumber: editingParcel.waybillNumber,
      status: editingParcel.status,
      paymentMethods: editingParcel.paymentMethods,
      sender: editingParcel.sender,
      senderTelephone: editingParcel.senderTelephone,
      receiver: editingParcel.receiver,
      receiverTelephone: editingParcel.receiverTelephone,
      destination: editingParcel.destination,
      quantity: editingParcel.quantity,
      amount: editingParcel.amount,
      description: editingParcel.description
    });
  };

  // Save parcel edits
  const saveParcelEdits = async () => {
    if (!editingParcel || !editForm) return;
    
    try {
      setSaving(true);
      const success = await wmsApi.updateParcel(editingParcel.id, editForm);
      
      if (success) {
        // Update local state
        setParcels(prev => prev.map(p => 
          p.id === editingParcel.id ? { ...p, ...editForm } : p
        ));
        setSuccessMessage('Parcel updated successfully');
        closeEditModal();
        setTimeout(() => setSuccessMessage(null), 3000);
      } else {
        setError('Failed to update parcel');
        setTimeout(() => setError(null), 3000);
      }
    } catch (err) {
      setError('Failed to update parcel');
      setTimeout(() => setError(null), 3000);
    } finally {
      setSaving(false);
    }
  };

  // Handle delete parcel
  const handleDeleteParcel = async () => {
    if (!deletingParcel) return;
    
    try {
      const success = await wmsApi.deleteParcel(deletingParcel.id);
      
      if (success) {
        setParcels(prev => prev.filter(p => p.id !== deletingParcel.id));
        setSuccessMessage('Parcel deleted successfully');
        setDeletingParcel(null);
        setTimeout(() => setSuccessMessage(null), 3000);
      } else {
        setError('Failed to delete parcel');
        setTimeout(() => setError(null), 3000);
      }
    } catch (err) {
      setError('Failed to delete parcel');
      setTimeout(() => setError(null), 3000);
    }
  };

  // Format currency
  const formatCurrency = (amount: number) => {
    return new Intl.NumberFormat('en-KE', {
      style: 'currency',
      currency: 'KES',
      minimumFractionDigits: 0
    }).format(amount).replace('KES', 'KSh');
  };

  // Format date
  const formatDate = (dateString: string) => {
    return new Date(dateString).toLocaleDateString('en-US', {
      year: 'numeric',
      month: 'short',
      day: 'numeric',
      hour: '2-digit',
      minute: '2-digit'
    });
  };

  // Pagination calculations
  const totalPages = Math.ceil(filteredParcels.length / itemsPerPage);
  const startIndex = (currentPage - 1) * itemsPerPage;
  const paginatedParcels = filteredParcels.slice(startIndex, startIndex + itemsPerPage);

  if (user?.role !== 'admin') {
    return (
      <div className="flex items-center justify-center min-h-[400px]">
        <div className="text-center">
          <AlertTriangle className="w-16 h-16 text-error-500 mx-auto mb-4" />
          <h2 className="text-xl font-semibold text-gray-900 mb-2">Access Denied</h2>
          <p className="text-gray-600">You need admin privileges to access this page.</p>
        </div>
      </div>
    );
  }

  return (
    <div className="space-y-6">
      {/* Header */}
      <div className="flex items-center justify-between">
        <div>
          <h1 className="text-2xl font-bold text-gray-900 flex items-center gap-3">
            <Settings className="w-8 h-8 text-primary-600" />
            Manage Parcels (Admin)
          </h1>
          <p className="text-gray-600 mt-1">
            Administrative parcel management with full CRUD operations
          </p>
        </div>
        <div className="flex items-center gap-3">
          <button
            onClick={loadParcels}
            disabled={loading}
            className="btn-primary flex items-center gap-2"
          >
            <RefreshCw className={`w-4 h-4 ${loading ? 'animate-spin' : ''}`} />
            Refresh
          </button>
        </div>
      </div>

      {/* Success/Error Messages */}
      {successMessage && (
        <div className="bg-success-50 border border-success-200 text-success-800 px-4 py-3 rounded-lg flex items-center gap-2">
          <CheckCircle className="w-5 h-5" />
          {successMessage}
        </div>
      )}
      
      {error && (
        <div className="bg-error-50 border border-error-200 text-error-800 px-4 py-3 rounded-lg flex items-center gap-2">
          <AlertTriangle className="w-5 h-5" />
          {error}
        </div>
      )}

      {/* Filters Panel */}
      <FilterPanel
        fields={filterFields}
        filters={filters as any}
        onFilterChange={handleFilterChange}
        onClearFilters={clearFilters}
        activeFilters={getActiveFilterChips()}
        collapsible={true}
        defaultExpanded={false}
      />

      {/* Parcels Table */}
      <div className="card">
        <div className="p-6 border-b border-gray-200">
          <div className="flex items-center justify-between">
            <h2 className="text-lg font-semibold text-gray-900">
              Parcels ({filteredParcels.length})
            </h2>
          </div>
        </div>

        {loading ? (
          <div className="flex items-center justify-center py-12">
            <RefreshCw className="w-8 h-8 animate-spin text-primary-600" />
            <span className="ml-2 text-gray-600">Loading parcels...</span>
          </div>
        ) : filteredParcels.length === 0 ? (
          <div className="text-center py-12">
            <Package className="w-12 h-12 text-gray-400 mx-auto mb-4" />
            <h3 className="text-lg font-medium text-gray-900 mb-2">No parcels found</h3>
            <p className="text-gray-600">Try adjusting your filters or refresh the data.</p>
          </div>
        ) : (
          <>
            <div className="overflow-x-auto">
              <table className="w-full">
              <thead className="bg-gray-50">
                <tr>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Waybill #
                  </th>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Sender
                  </th>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Receiver
                  </th>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Destination
                  </th>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Amount
                  </th>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Status
                  </th>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Created By
                  </th>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Created Date
                  </th>
                  <th className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">
                    Actions
                  </th>
                </tr>
              </thead>
              <tbody className="bg-white divide-y divide-gray-200">
                {paginatedParcels.map((parcel) => (
                  <tr key={parcel.id} className="hover:bg-gray-50">
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div className="flex items-center">
                        <FileText className="w-4 h-4 text-gray-400 mr-2" />
                        <span className="text-sm font-medium text-gray-900">
                          {parcel.waybillNumber}
                        </span>
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div>
                        <div className="text-sm font-medium text-gray-900">{parcel.sender}</div>
                        <div className="text-sm text-gray-500 flex items-center">
                          <Phone className="w-3 h-3 mr-1" />
                          {parcel.senderTelephone}
                        </div>
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div>
                        <div className="text-sm font-medium text-gray-900">{parcel.receiver}</div>
                        <div className="text-sm text-gray-500 flex items-center">
                          <Phone className="w-3 h-3 mr-1" />
                          {parcel.receiverTelephone}
                        </div>
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div className="flex items-center text-sm text-gray-900">
                        <MapPin className="w-4 h-4 text-gray-400 mr-1" />
                        {parcel.destination}
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div className="flex items-center text-sm font-medium text-gray-900">
                        <DollarSign className="w-4 h-4 text-gray-400 mr-1" />
                        {formatCurrency(parcel.amount)}
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <select
                        value={parcel.status}
                        onChange={(e) => handleQuickStatusUpdate(parcel.id, Number(e.target.value))}
                        className={`text-xs font-medium px-2 py-1 rounded-full border text-center ${STATUS_COLORS[parcel.status]}`}
                      >
                        {Object.entries(STATUS_LABELS).map(([value, label]) => (
                          <option key={value} value={value}>
                            {label}
                          </option>
                        ))}
                      </select>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div className="flex items-center text-sm text-gray-900">
                        <User className="w-4 h-4 text-gray-400 mr-1" />
                        {parcel.createdBy?.username || `User ${parcel.createdById}`}
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div className="flex items-center text-sm text-gray-900">
                        <Calendar className="w-4 h-4 text-gray-400 mr-1" />
                        {formatDate(parcel.createdAt)}
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap text-sm font-medium">
                      <div className="flex items-center gap-2">
                        <button
                          onClick={() => openEditModal(parcel)}
                          className="text-primary-600 hover:text-primary-700"
                          title="Edit Parcel"
                        >
                          <Edit className="w-4 h-4" />
                        </button>
                        <button
                          onClick={() => setDeletingParcel(parcel)}
                          className="text-error-600 hover:text-error-700"
                          title="Delete Parcel"
                        >
                          <Trash2 className="w-4 h-4" />
                        </button>
                      </div>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
          
          {/* Pagination */}
          {totalPages > 1 && (
            <div className="px-6 py-4 border-t border-gray-200 flex items-center justify-between">
              <div className="flex items-center text-sm text-gray-600">
                Showing {startIndex + 1}-{Math.min(startIndex + itemsPerPage, filteredParcels.length)} of {filteredParcels.length} parcels
              </div>
              
              <div className="flex items-center space-x-2">
                <button
                  onClick={() => setCurrentPage(prev => Math.max(prev - 1, 1))}
                  disabled={currentPage === 1}
                  className="btn-secondary disabled:opacity-50 disabled:cursor-not-allowed"
                >
                  Previous
                </button>
                
                <div className="flex items-center space-x-1">
                  {Array.from({ length: Math.min(5, totalPages) }, (_, i) => {
                    let pageNum: number;
                    if (totalPages <= 5) {
                      pageNum = i + 1;
                    } else if (currentPage <= 3) {
                      pageNum = i + 1;
                    } else if (currentPage >= totalPages - 2) {
                      pageNum = totalPages - 4 + i;
                    } else {
                      pageNum = currentPage - 2 + i;
                    }
                    
                    return (
                      <button
                        key={pageNum}
                        onClick={() => setCurrentPage(pageNum)}
                        className={`px-3 py-1 text-sm rounded-md ${
                          currentPage === pageNum
                            ? 'bg-primary-500 text-white'
                            : 'text-gray-500 hover:text-gray-700 hover:bg-gray-100'
                        }`}
                      >
                        {pageNum}
                      </button>
                    );
                  })}
                </div>
                
                <button
                  onClick={() => setCurrentPage(prev => Math.min(prev + 1, totalPages))}
                  disabled={currentPage === totalPages}
                  className="btn-secondary disabled:opacity-50 disabled:cursor-not-allowed"
                >
                  Next
                </button>
              </div>
            </div>
          )}
          </>
        )}
      </div>

      {/* Edit Parcel Modal */}
      {editingParcel && editForm && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center p-4 z-50">
          <div className="bg-white rounded-lg shadow-xl max-w-2xl w-full max-h-[90vh] overflow-y-auto">
            <div className="p-6 border-b border-gray-200">
              <div className="flex items-center justify-between">
                <h3 className="text-lg font-semibold text-gray-900">
                  Edit Parcel - {editingParcel.waybillNumber}
                </h3>
                <button
                  onClick={closeEditModal}
                  className="text-gray-400 hover:text-gray-600"
                >
                  <X className="w-6 h-6" />
                </button>
              </div>
            </div>

            <div className="p-6 space-y-6">
              {/* Read-only System Info */}
              <div className="bg-gray-50 p-4 rounded-lg">
                <h4 className="text-sm font-medium text-gray-700 mb-2">System Information</h4>
                <div className="grid grid-cols-2 gap-4 text-sm">
                  <div>
                    <span className="text-gray-500">Parcel ID:</span>
                    <span className="ml-2 text-gray-900">{editingParcel.id}</span>
                  </div>
                  <div>
                    <span className="text-gray-500">Created At:</span>
                    <span className="ml-2 text-gray-900">{formatDate(editingParcel.createdAt)}</span>
                  </div>
                  {editingParcel.qrCode && (
                    <div>
                      <span className="text-gray-500">QR Code:</span>
                      <span className="ml-2 text-gray-900">{editingParcel.qrCode}</span>
                    </div>
                  )}
                </div>
              </div>

              {/* Editable Fields */}
              <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Waybill Number
                  </label>
                  <input
                    type="text"
                    value={editForm.waybillNumber}
                    onChange={(e) => handleEditFormChange('waybillNumber', e.target.value)}
                    className="input-field"
                  />
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Status
                  </label>
                  <select
                    value={editForm.status}
                    onChange={(e) => handleEditFormChange('status', Number(e.target.value))}
                    className="input-field"
                  >
                    {Object.entries(STATUS_LABELS).map(([value, label]) => (
                      <option key={value} value={value}>
                        {label}
                      </option>
                    ))}
                  </select>
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Payment Method
                  </label>
                  <select
                    value={editForm.paymentMethods}
                    onChange={(e) => handleEditFormChange('paymentMethods', e.target.value)}
                    className="input-field"
                  >
                    <option value="">Select Payment Method</option>
                    <option value="Paid">Paid</option>
                    <option value="COD">COD (Cash on Delivery)</option>
                    <option value="Contract">Contract</option>
                    {availablePaymentMethods.filter(method => !['Paid', 'COD', 'Contract'].includes(method)).map(method => (
                      <option key={method} value={method}>{method}</option>
                    ))}
                  </select>
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Destination
                  </label>
                  <select
                    value={editForm.destination}
                    onChange={(e) => handleEditFormChange('destination', e.target.value)}
                    className="input-field"
                  >
                    <option value="">Select Destination</option>
                    {availableDestinations.map(dest => (
                      <option key={dest} value={dest}>{dest}</option>
                    ))}
                  </select>
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Sender Name
                  </label>
                  <input
                    type="text"
                    value={editForm.sender}
                    onChange={(e) => handleEditFormChange('sender', e.target.value)}
                    className="input-field"
                  />
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Sender Telephone
                  </label>
                  <input
                    type="text"
                    value={editForm.senderTelephone}
                    onChange={(e) => handleEditFormChange('senderTelephone', e.target.value)}
                    className="input-field"
                  />
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Receiver Name
                  </label>
                  <input
                    type="text"
                    value={editForm.receiver}
                    onChange={(e) => handleEditFormChange('receiver', e.target.value)}
                    className="input-field"
                  />
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Receiver Telephone
                  </label>
                  <input
                    type="text"
                    value={editForm.receiverTelephone}
                    onChange={(e) => handleEditFormChange('receiverTelephone', e.target.value)}
                    className="input-field"
                  />
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Quantity
                  </label>
                  <input
                    type="number"
                    value={editForm.quantity}
                    onChange={(e) => handleEditFormChange('quantity', Number(e.target.value))}
                    className="input-field"
                  />
                </div>

                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Amount (KSh)
                  </label>
                  <input
                    type="number"
                    value={editForm.amount}
                    onChange={(e) => handleEditFormChange('amount', Number(e.target.value))}
                    className="input-field"
                  />
                </div>
              </div>

              <div>
                <label className="block text-sm font-medium text-gray-700 mb-1">
                  Description
                </label>
                <textarea
                  value={editForm.description}
                  onChange={(e) => handleEditFormChange('description', e.target.value)}
                  rows={3}
                  className="input-field"
                />
              </div>
            </div>

            <div className="p-6 border-t border-gray-200 flex items-center justify-between">
              <button
                onClick={resetEditForm}
                className="btn-secondary flex items-center gap-2"
              >
                <RotateCcw className="w-4 h-4" />
                Reset
              </button>
              
              <div className="flex items-center gap-3">
                <button
                  onClick={closeEditModal}
                  className="btn-secondary"
                >
                  Cancel
                </button>
                <button
                  onClick={saveParcelEdits}
                  disabled={saving}
                  className="btn-primary flex items-center gap-2"
                >
                  <Save className="w-4 h-4" />
                  {saving ? 'Saving...' : 'Save Changes'}
                </button>
              </div>
            </div>
          </div>
        </div>
      )}

      {/* Delete Confirmation Modal */}
      {deletingParcel && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center p-4 z-50">
          <div className="bg-white rounded-lg shadow-xl max-w-md w-full">
            <div className="p-6">
              <div className="flex items-center mb-4">
                <AlertTriangle className="w-6 h-6 text-error-600 mr-2" />
                <h3 className="text-lg font-semibold text-gray-900">
                  Delete Parcel
                </h3>
              </div>
              
              <p className="text-gray-600 mb-6">
                Are you sure you want to delete parcel <strong>{deletingParcel.waybillNumber}</strong>? 
                This action cannot be undone.
              </p>
              
              <div className="flex items-center gap-3 justify-end">
                <button
                  onClick={() => setDeletingParcel(null)}
                  className="btn-secondary"
                >
                  Cancel
                </button>
                <button
                  onClick={handleDeleteParcel}
                  className="btn-danger flex items-center gap-2"
                >
                  <Trash2 className="w-4 h-4" />
                  Delete Parcel
                </button>
              </div>
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

export default AdminParcelManagement;