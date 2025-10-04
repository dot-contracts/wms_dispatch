import React, { useState } from 'react';
import { 
  Users, 
  Search, 
  Plus, 
  Edit, 
  Trash2, 
  Mail, 
  Phone,
  Building2,
  Calendar,
  DollarSign
} from 'lucide-react';
import { Card, Button, Badge, Table, FilterPanel, FilterField } from '../components/ui';
import ContractCustomerForm from '../components/forms/ContractCustomerForm';
import { ContractCustomer } from '../services/wmsApi';

// Mock data for demonstration - in real app this would come from API
const mockCustomers = [
  {
    id: 1,
    name: 'Acme Corporation',
    companyName: 'Acme Corp Ltd',
    email: 'contact@acme.com',
    phone: '+1-555-0123',
    address: '123 Business St, City, State 12345',
    contactPerson: 'John Smith',
    contractNumber: 'CNT-2024-001',
    paymentTerms: 'Net 30',
    taxRate: 8.5,
    isActive: true,
    createdAt: '2024-01-15T09:00:00Z',
    updatedAt: '2024-01-15T09:00:00Z'
  },
  {
    id: 2,
    name: 'Global Logistics Inc',
    companyName: 'Global Logistics Inc',
    email: 'billing@globallogistics.com',
    phone: '+1-555-0456',
    address: '456 Commerce Ave, Business City, BC 67890',
    contactPerson: 'Sarah Johnson',
    contractNumber: 'CNT-2024-002',
    paymentTerms: 'Net 15',
    taxRate: 7.25,
    isActive: true,
    createdAt: '2024-02-01T10:30:00Z',
    updatedAt: '2024-02-01T10:30:00Z'
  },
  {
    id: 3,
    name: 'TechStart Solutions',
    companyName: 'TechStart Solutions LLC',
    email: 'admin@techstart.com',
    phone: '+1-555-0789',
    address: '789 Innovation Blvd, Tech City, TC 13579',
    contactPerson: 'Mike Chen',
    contractNumber: 'CNT-2024-003',
    paymentTerms: 'Net 45',
    taxRate: 9.0,
    isActive: false,
    createdAt: '2024-01-20T14:15:00Z',
    updatedAt: '2024-03-01T16:45:00Z'
  }
];

interface CustomerFilterState {
  search: string;
  status: string;
  paymentTerms: string;
  taxRateRange: { from: string; to: string };
  dateRange: { from: string; to: string };
  contactPerson: string;
}

const ContractCustomers: React.FC = () => {
  const [customers, setCustomers] = useState(mockCustomers);
  const [loading, setLoading] = useState(false);
  const [filters, setFilters] = useState<CustomerFilterState>({
    search: '',
    status: '',
    paymentTerms: '',
    taxRateRange: { from: '', to: '' },
    dateRange: { from: '', to: '' },
    contactPerson: ''
  });
  const [isFormOpen, setIsFormOpen] = useState(false);
  const [editingCustomer, setEditingCustomer] = useState<ContractCustomer | null>(null);

  // Filter fields configuration
  const filterFields: FilterField[] = [
    {
      key: 'search',
      label: 'Search',
      type: 'text',
      placeholder: 'Search customers...',
      icon: <Search className="w-4 h-4" />
    },
    {
      key: 'status',
      label: 'Status',
      type: 'select',
      placeholder: 'Select status',
      options: [
        { value: '', label: 'All Status' },
        { value: 'active', label: 'Active' },
        { value: 'inactive', label: 'Inactive' }
      ]
    },
    {
      key: 'paymentTerms',
      label: 'Payment Terms',
      type: 'select',
      placeholder: 'Select payment terms',
      options: [
        { value: '', label: 'All Payment Terms' },
        { value: 'Net 15', label: 'Net 15' },
        { value: 'Net 30', label: 'Net 30' },
        { value: 'Net 45', label: 'Net 45' }
      ],
      icon: <DollarSign className="w-4 h-4" />
    },
    {
      key: 'contactPerson',
      label: 'Contact Person',
      type: 'text',
      placeholder: 'Search contact person...',
      icon: <Users className="w-4 h-4" />
    },
    {
      key: 'taxRateRange',
      label: 'Tax Rate Range (%)',
      type: 'dateRange',
      placeholder: 'Select tax rate range'
    },
    {
      key: 'dateRange',
      label: 'Date Range',
      type: 'dateRange',
      placeholder: 'Select date range',
      icon: <Calendar className="w-4 h-4" />
    }
  ];

  const filteredCustomers = customers.filter(customer => {
    const matchesSearch = customer.name.toLowerCase().includes(filters.search.toLowerCase()) ||
                         customer.companyName?.toLowerCase().includes(filters.search.toLowerCase()) ||
                         customer.email?.toLowerCase().includes(filters.search.toLowerCase()) ||
                         customer.contactPerson?.toLowerCase().includes(filters.search.toLowerCase());
    
    const matchesStatus = !filters.status || 
                         (filters.status === 'active' && customer.isActive) ||
                         (filters.status === 'inactive' && !customer.isActive);
    
    const matchesPaymentTerms = !filters.paymentTerms || customer.paymentTerms === filters.paymentTerms;
    
    const matchesContactPerson = !filters.contactPerson || 
                               customer.contactPerson?.toLowerCase().includes(filters.contactPerson.toLowerCase());
    
    const matchesTaxRate = (!filters.taxRateRange.from && !filters.taxRateRange.to) ||
                          ((filters.taxRateRange.from ? customer.taxRate >= Number(filters.taxRateRange.from) : true) &&
                           (filters.taxRateRange.to ? customer.taxRate <= Number(filters.taxRateRange.to) : true));
    
    const matchesDateRange = (!filters.dateRange.from && !filters.dateRange.to) ||
                            ((filters.dateRange.from ? new Date(customer.createdAt) >= new Date(filters.dateRange.from) : true) &&
                             (filters.dateRange.to ? new Date(customer.createdAt) <= new Date(filters.dateRange.to) : true));
    
    return matchesSearch && matchesStatus && matchesPaymentTerms && matchesContactPerson && matchesTaxRate && matchesDateRange;
  });

  const getStatusBadge = (isActive: boolean) => {
    return (
      <Badge variant={isActive ? 'success' : 'gray'}>
        {isActive ? 'Active' : 'Inactive'}
      </Badge>
    );
  };

  // Handle filter changes
  const handleFilterChange = (key: string, value: string | { from: string; to: string }) => {
    setFilters(prev => ({ ...prev, [key]: value }));
  };

  // Clear all filters
  const clearFilters = () => {
    setFilters({
      search: '',
      status: '',
      paymentTerms: '',
      taxRateRange: { from: '', to: '' },
      dateRange: { from: '', to: '' },
      contactPerson: ''
    });
  };

  // Generate active filter chips
  const getActiveFilterChips = () => {
    const chips: any[] = [];

    if (filters.search) {
      chips.push({
        key: 'search',
        label: 'Search',
        value: filters.search,
        onRemove: () => handleFilterChange('search', '')
      });
    }

    if (filters.status) {
      const statusLabel = filterFields.find(f => f.key === 'status')?.options?.find((o: any) => o.value === filters.status)?.label || filters.status;
      chips.push({
        key: 'status',
        label: 'Status',
        value: statusLabel,
        onRemove: () => handleFilterChange('status', '')
      });
    }

    if (filters.paymentTerms) {
      chips.push({
        key: 'paymentTerms',
        label: 'Payment Terms',
        value: filters.paymentTerms,
        onRemove: () => handleFilterChange('paymentTerms', '')
      });
    }

    if (filters.contactPerson) {
      chips.push({
        key: 'contactPerson',
        label: 'Contact Person',
        value: filters.contactPerson,
        onRemove: () => handleFilterChange('contactPerson', '')
      });
    }

    if (filters.taxRateRange.from || filters.taxRateRange.to) {
      const rangeValue = `${filters.taxRateRange.from || '0'}% - ${filters.taxRateRange.to || '∞'}%`;
      chips.push({
        key: 'taxRateRange',
        label: 'Tax Rate Range',
        value: rangeValue,
        onRemove: () => handleFilterChange('taxRateRange', { from: '', to: '' })
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

  const formatDate = (dateString: string) => {
    return new Date(dateString).toLocaleDateString();
  };

  const handleCreateCustomer = () => {
    setEditingCustomer(null);
    setIsFormOpen(true);
  };

  const handleEditCustomer = (customer: any) => {
    setEditingCustomer(customer);
    setIsFormOpen(true);
  };

  const handleFormSubmit = async (data: any) => {
    try {
      setLoading(true);
      
      if (editingCustomer) {
        // Update existing customer
        setCustomers(prev => prev.map(customer => 
          customer.id === editingCustomer.id 
            ? { ...customer, ...data, updatedAt: new Date().toISOString() }
            : customer
        ));
      } else {
        // Create new customer
        const newCustomer = {
          id: Math.max(...customers.map(c => c.id)) + 1,
          ...data,
          createdAt: new Date().toISOString(),
          updatedAt: new Date().toISOString(),
        };
        setCustomers(prev => [...prev, newCustomer]);
      }
      
      setIsFormOpen(false);
      setEditingCustomer(null);
    } catch (error) {
      console.error('Error saving customer:', error);
    } finally {
      setLoading(false);
    }
  };

  const handleDeleteCustomer = (customerId: number) => {
    if (window.confirm('Are you sure you want to delete this customer?')) {
      setCustomers(prev => prev.filter(customer => customer.id !== customerId));
    }
  };

  if (loading) {
    return (
      <div className="flex items-center justify-center min-h-96">
        <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-brand-500"></div>
      </div>
    );
  }

  return (
    <div className="space-y-6">
      {/* Header */}
      <div className="flex items-center justify-between">
        <div>
          <h1 className="text-title-md font-bold text-gray-900 dark:text-white">
            Contract Customers
          </h1>
          <p className="text-gray-600 dark:text-gray-400">
            Manage contract customers and billing information
          </p>
        </div>
        <Button variant="primary" onClick={handleCreateCustomer}>
          <Plus className="w-4 h-4 mr-2" />
          Add Customer
        </Button>
      </div>

      {/* Stats */}
      <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
        <Card>
          <div className="flex items-center">
            <div className="p-3 rounded-lg bg-brand-100 dark:bg-brand-500/20">
              <Users className="w-6 h-6 text-brand-600 dark:text-brand-400" />
            </div>
            <div className="ml-4">
              <p className="text-theme-sm font-medium text-gray-600 dark:text-gray-400">
                Total Customers
              </p>
              <p className="text-2xl font-bold text-gray-900 dark:text-white">
                {customers.length}
              </p>
            </div>
          </div>
        </Card>

        <Card>
          <div className="flex items-center">
            <div className="p-3 rounded-lg bg-success-100 dark:bg-success-500/20">
              <Building2 className="w-6 h-6 text-success-600 dark:text-success-400" />
            </div>
            <div className="ml-4">
              <p className="text-theme-sm font-medium text-gray-600 dark:text-gray-400">
                Active Contracts
              </p>
              <p className="text-2xl font-bold text-gray-900 dark:text-white">
                {customers.filter(c => c.isActive).length}
              </p>
            </div>
          </div>
        </Card>

        <Card>
          <div className="flex items-center">
            <div className="p-3 rounded-lg bg-warning-100 dark:bg-warning-500/20">
              <Calendar className="w-6 h-6 text-warning-600 dark:text-warning-400" />
            </div>
            <div className="ml-4">
              <p className="text-theme-sm font-medium text-gray-600 dark:text-gray-400">
                This Month
              </p>
              <p className="text-2xl font-bold text-gray-900 dark:text-white">
                2
              </p>
            </div>
          </div>
        </Card>
      </div>

      {/* Filters */}
      <FilterPanel
        fields={filterFields}
        filters={filters as any}
        onFilterChange={handleFilterChange}
        onClearFilters={clearFilters}
        activeFilters={getActiveFilterChips()}
        collapsible={true}
        defaultExpanded={false}
      />

      {/* Customers Table */}
      <Card padding={false}>
        <Card.Header>
          <div className="flex items-center justify-between">
            <h2 className="text-lg font-semibold text-gray-900 dark:text-white">
              Customers ({filteredCustomers.length})
            </h2>
          </div>
        </Card.Header>
        
        {filteredCustomers.length === 0 ? (
          <Card.Content>
            <div className="text-center py-12">
              <Users className="mx-auto h-12 w-12 text-gray-400 mb-4" />
              <h3 className="text-lg font-medium text-gray-900 dark:text-white mb-2">
                No customers found
              </h3>
              <p className="text-gray-500 dark:text-gray-400">
                {filters.search || filters.status 
                  ? 'Try adjusting your filters' 
                  : 'Get started by adding your first contract customer'}
              </p>
            </div>
          </Card.Content>
        ) : (
          <Table>
            <Table.Header>
              <Table.Row>
                <Table.Head sortable>Company</Table.Head>
                <Table.Head>Contact</Table.Head>
                <Table.Head>Contract</Table.Head>
                <Table.Head>Payment Terms</Table.Head>
                <Table.Head>Status</Table.Head>
                <Table.Head>Created</Table.Head>
                <Table.Head>Actions</Table.Head>
              </Table.Row>
            </Table.Header>
            <Table.Body>
              {filteredCustomers.map((customer) => (
                <Table.Row key={customer.id}>
                  <Table.Cell>
                    <div>
                      <div className="font-medium text-gray-900 dark:text-white">
                        {customer.name}
                      </div>
                      <div className="text-theme-sm text-gray-500 dark:text-gray-400">
                        {customer.companyName}
                      </div>
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="space-y-1">
                      <div className="flex items-center text-theme-sm text-gray-900 dark:text-white">
                        <Mail className="w-3 h-3 mr-1 text-gray-400" />
                        {customer.email}
                      </div>
                      <div className="flex items-center text-theme-sm text-gray-500 dark:text-gray-400">
                        <Phone className="w-3 h-3 mr-1 text-gray-400" />
                        {customer.phone}
                      </div>
                      <div className="text-theme-xs text-gray-500 dark:text-gray-400">
                        Contact: {customer.contactPerson}
                      </div>
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="font-medium text-gray-900 dark:text-white">
                      {customer.contractNumber}
                    </div>
                    <div className="text-theme-xs text-gray-500 dark:text-gray-400">
                      Tax Rate: {customer.taxRate}%
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <span className="text-gray-900 dark:text-white">
                      {customer.paymentTerms}
                    </span>
                  </Table.Cell>
                  <Table.Cell>{getStatusBadge(customer.isActive)}</Table.Cell>
                  <Table.Cell>
                    <span className="text-gray-900 dark:text-white">
                      {formatDate(customer.createdAt)}
                    </span>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center space-x-2">
                      <Button 
                        variant="outline" 
                        size="sm"
                        onClick={() => handleEditCustomer(customer)}
                      >
                        <Edit className="w-4 h-4" />
                      </Button>
                      <Button 
                        variant="outline" 
                        size="sm"
                        onClick={() => handleDeleteCustomer(customer.id)}
                      >
                        <Trash2 className="w-4 h-4" />
                      </Button>
                    </div>
                  </Table.Cell>
                </Table.Row>
              ))}
            </Table.Body>
          </Table>
        )}
      </Card>

      {/* Contract Customer Form Modal */}
      <ContractCustomerForm
        isOpen={isFormOpen}
        onClose={() => setIsFormOpen(false)}
        onSubmit={handleFormSubmit}
        customer={editingCustomer}
        isLoading={loading}
      />
    </div>
  );
};

export default ContractCustomers;