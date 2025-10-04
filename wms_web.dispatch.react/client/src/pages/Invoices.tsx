import React, { useState } from 'react';
import { 
  FileText, 
  Search, 
  Plus, 
  Edit, 
  Eye, 
  Download,
  Mail,
  DollarSign,
  Calendar,
  CheckCircle,
  AlertCircle,
  XCircle,
  Building2
} from 'lucide-react';
import { useAuth } from '../context/AuthContext';
import { Card, Button, Badge, Table, FilterPanel, FilterField } from '../components/ui';

// Mock data for demonstration
const mockInvoices = [
  {
    id: 1,
    invoiceNumber: 'INV-2024-001',
    customerId: 1,
    customer: {
      id: 1,
      name: 'Acme Corporation',
      companyName: 'Acme Corp Ltd',
      email: 'billing@acme.com'
    },
    issueDate: '2024-01-15',
    dueDate: '2024-02-14',
    status: 'sent' as const,
    subtotal: 1250.00,
    taxAmount: 106.25,
    totalAmount: 1356.25,
    notes: 'Monthly shipping services',
    createdAt: '2024-01-15T09:00:00Z',
    updatedAt: '2024-01-15T09:00:00Z',
    items: [
      {
        id: 1,
        invoiceId: 1,
        parcelId: 'P001',
        waybillNumber: 'WBL-2024-001',
        description: 'Express delivery service',
        quantity: 5,
        unitPrice: 250.00,
        totalPrice: 1250.00,
        createdAt: '2024-01-15T09:00:00Z'
      }
    ]
  },
  {
    id: 2,
    invoiceNumber: 'INV-2024-002',
    customerId: 2,
    customer: {
      id: 2,
      name: 'Global Logistics Inc',
      companyName: 'Global Logistics Inc',
      email: 'accounts@globallogistics.com'
    },
    issueDate: '2024-02-01',
    dueDate: '2024-02-16',
    status: 'paid' as const,
    subtotal: 850.00,
    taxAmount: 61.63,
    totalAmount: 911.63,
    notes: 'Weekly bulk shipments',
    createdAt: '2024-02-01T10:30:00Z',
    updatedAt: '2024-02-10T14:20:00Z',
    items: []
  },
  {
    id: 3,
    invoiceNumber: 'INV-2024-003',
    customerId: 3,
    customer: {
      id: 3,
      name: 'TechStart Solutions',
      companyName: 'TechStart Solutions LLC',
      email: 'finance@techstart.com'
    },
    issueDate: '2024-02-15',
    dueDate: '2024-03-17',
    status: 'overdue' as const,
    subtotal: 2150.00,
    taxAmount: 193.50,
    totalAmount: 2343.50,
    notes: 'Priority delivery services',
    createdAt: '2024-02-15T11:45:00Z',
    updatedAt: '2024-02-15T11:45:00Z',
    items: []
  },
  {
    id: 4,
    invoiceNumber: 'INV-2024-004',
    customerId: 1,
    customer: {
      id: 1,
      name: 'Acme Corporation',
      companyName: 'Acme Corp Ltd',
      email: 'billing@acme.com'
    },
    issueDate: '2024-03-01',
    dueDate: '2024-03-31',
    status: 'draft' as const,
    subtotal: 750.00,
    taxAmount: 63.75,
    totalAmount: 813.75,
    notes: 'Standard delivery package',
    createdAt: '2024-03-01T08:15:00Z',
    updatedAt: '2024-03-01T08:15:00Z',
    items: []
  }
];

interface InvoiceFilterState {
  search: string;
  status: string;
  customer: string;
  amountRange: { from: string; to: string };
  dateRange: { from: string; to: string };
  dueDateRange: { from: string; to: string };
}

const Invoices: React.FC = () => {
  const [invoices, setInvoices] = useState(mockInvoices);
  const [loading, setLoading] = useState(false);
  const [filters, setFilters] = useState<InvoiceFilterState>({
    search: '',
    status: '',
    customer: '',
    amountRange: { from: '', to: '' },
    dateRange: { from: '', to: '' },
    dueDateRange: { from: '', to: '' }
  });
  const { user } = useAuth();

  // Filter fields configuration
  const filterFields: FilterField[] = [
    {
      key: 'search',
      label: 'Search',
      type: 'text',
      placeholder: 'Search invoices...',
      icon: <Search className="w-4 h-4" />
    },
    {
      key: 'status',
      label: 'Status',
      type: 'select',
      placeholder: 'Select status',
      options: [
        { value: '', label: 'All Status' },
        { value: 'draft', label: 'Draft' },
        { value: 'sent', label: 'Sent' },
        { value: 'paid', label: 'Paid' },
        { value: 'overdue', label: 'Overdue' },
        { value: 'cancelled', label: 'Cancelled' }
      ]
    },
    {
      key: 'customer',
      label: 'Customer',
      type: 'select',
      placeholder: 'Select customer',
      options: [
        { value: '', label: 'All Customers' },
        ...Array.from(new Set(mockInvoices.map(inv => inv.customer.name))).map(name => ({
          value: name,
          label: name
        }))
      ],
      icon: <Building2 className="w-4 h-4" />
    },
    {
      key: 'amountRange',
      label: 'Amount Range ($)',
      type: 'dateRange',
      placeholder: 'Select amount range',
      icon: <DollarSign className="w-4 h-4" />
    },
    {
      key: 'dateRange',
      label: 'Issue Date Range',
      type: 'dateRange',
      placeholder: 'Select issue date range',
      icon: <Calendar className="w-4 h-4" />
    },
    {
      key: 'dueDateRange',
      label: 'Due Date Range',
      type: 'dateRange',
      placeholder: 'Select due date range',
      icon: <Calendar className="w-4 h-4" />
    }
  ];

  const filteredInvoices = invoices.filter(invoice => {
    const matchesSearch = 
      invoice.invoiceNumber.toLowerCase().includes(filters.search.toLowerCase()) ||
      invoice.customer.name.toLowerCase().includes(filters.search.toLowerCase()) ||
      invoice.customer.companyName?.toLowerCase().includes(filters.search.toLowerCase()) ||
      invoice.notes?.toLowerCase().includes(filters.search.toLowerCase());
    
    const matchesStatus = !filters.status || invoice.status === filters.status;
    
    const matchesCustomer = !filters.customer || invoice.customer.name === filters.customer;
    
    const matchesAmountRange = (!filters.amountRange.from && !filters.amountRange.to) ||
                             ((filters.amountRange.from ? invoice.totalAmount >= Number(filters.amountRange.from) : true) &&
                              (filters.amountRange.to ? invoice.totalAmount <= Number(filters.amountRange.to) : true));
    
    const matchesDateRange = (!filters.dateRange.from && !filters.dateRange.to) ||
                           ((filters.dateRange.from ? new Date(invoice.issueDate) >= new Date(filters.dateRange.from) : true) &&
                            (filters.dateRange.to ? new Date(invoice.issueDate) <= new Date(filters.dateRange.to) : true));
    
    const matchesDueDateRange = (!filters.dueDateRange.from && !filters.dueDateRange.to) ||
                              ((filters.dueDateRange.from ? new Date(invoice.dueDate) >= new Date(filters.dueDateRange.from) : true) &&
                               (filters.dueDateRange.to ? new Date(invoice.dueDate) <= new Date(filters.dueDateRange.to) : true));
    
    return matchesSearch && matchesStatus && matchesCustomer && matchesAmountRange && matchesDateRange && matchesDueDateRange;
  });

  const getStatusBadge = (status: string) => {
    const statusConfig = {
      draft: { label: 'Draft', variant: 'gray' as const, icon: Edit },
      sent: { label: 'Sent', variant: 'primary' as const, icon: Mail },
      paid: { label: 'Paid', variant: 'success' as const, icon: CheckCircle },
      overdue: { label: 'Overdue', variant: 'error' as const, icon: AlertCircle },
      cancelled: { label: 'Cancelled', variant: 'gray' as const, icon: XCircle }
    };

    const config = statusConfig[status as keyof typeof statusConfig] || statusConfig.draft;
    const IconComponent = config.icon;

    return (
      <Badge variant={config.variant}>
        <IconComponent className="w-3 h-3 mr-1" />
        {config.label}
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
      customer: '',
      amountRange: { from: '', to: '' },
      dateRange: { from: '', to: '' },
      dueDateRange: { from: '', to: '' }
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

    if (filters.customer) {
      chips.push({
        key: 'customer',
        label: 'Customer',
        value: filters.customer,
        onRemove: () => handleFilterChange('customer', '')
      });
    }

    if (filters.amountRange.from || filters.amountRange.to) {
      const rangeValue = `$${filters.amountRange.from || '0'} - $${filters.amountRange.to || '∞'}`;
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
        label: 'Issue Date Range',
        value: rangeValue,
        onRemove: () => handleFilterChange('dateRange', { from: '', to: '' })
      });
    }

    if (filters.dueDateRange.from || filters.dueDateRange.to) {
      const rangeValue = `${filters.dueDateRange.from || 'Start'} - ${filters.dueDateRange.to || 'End'}`;
      chips.push({
        key: 'dueDateRange',
        label: 'Due Date Range',
        value: rangeValue,
        onRemove: () => handleFilterChange('dueDateRange', { from: '', to: '' })
      });
    }

    return chips;
  };

  const formatCurrency = (amount: number) => {
    return new Intl.NumberFormat('en-US', {
      style: 'currency',
      currency: 'USD'
    }).format(amount);
  };

  const formatDate = (dateString: string) => {
    return new Date(dateString).toLocaleDateString();
  };

  const getInvoiceStats = () => {
    const total = invoices.length;
    const paid = invoices.filter(inv => inv.status === 'paid').length;
    const overdue = invoices.filter(inv => inv.status === 'overdue').length;
    const totalAmount = invoices.reduce((sum, inv) => sum + inv.totalAmount, 0);

    return { total, paid, overdue, totalAmount };
  };

  const stats = getInvoiceStats();

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
            Invoices
          </h1>
          <p className="text-gray-600 dark:text-gray-400">
            Manage customer invoices and billing
          </p>
        </div>
        <div className="flex space-x-3">
          <Button variant="outline">
            <Download className="w-4 h-4 mr-2" />
            Export
          </Button>
          <Button variant="primary">
            <Plus className="w-4 h-4 mr-2" />
            Create Invoice
          </Button>
        </div>
      </div>

      {/* Stats */}
      <div className="grid grid-cols-1 md:grid-cols-4 gap-6">
        <Card>
          <div className="flex items-center">
            <div className="p-3 rounded-lg bg-brand-100 dark:bg-brand-500/20">
              <FileText className="w-6 h-6 text-brand-600 dark:text-brand-400" />
            </div>
            <div className="ml-4">
              <p className="text-theme-sm font-medium text-gray-600 dark:text-gray-400">
                Total Invoices
              </p>
              <p className="text-2xl font-bold text-gray-900 dark:text-white">
                {stats.total}
              </p>
            </div>
          </div>
        </Card>

        <Card>
          <div className="flex items-center">
            <div className="p-3 rounded-lg bg-success-100 dark:bg-success-500/20">
              <CheckCircle className="w-6 h-6 text-success-600 dark:text-success-400" />
            </div>
            <div className="ml-4">
              <p className="text-theme-sm font-medium text-gray-600 dark:text-gray-400">
                Paid Invoices
              </p>
              <p className="text-2xl font-bold text-gray-900 dark:text-white">
                {stats.paid}
              </p>
            </div>
          </div>
        </Card>

        <Card>
          <div className="flex items-center">
            <div className="p-3 rounded-lg bg-error-100 dark:bg-error-500/20">
              <AlertCircle className="w-6 h-6 text-error-600 dark:text-error-400" />
            </div>
            <div className="ml-4">
              <p className="text-theme-sm font-medium text-gray-600 dark:text-gray-400">
                Overdue
              </p>
              <p className="text-2xl font-bold text-gray-900 dark:text-white">
                {stats.overdue}
              </p>
            </div>
          </div>
        </Card>

        <Card>
          <div className="flex items-center">
            <div className="p-3 rounded-lg bg-warning-100 dark:bg-warning-500/20">
              <DollarSign className="w-6 h-6 text-warning-600 dark:text-warning-400" />
            </div>
            <div className="ml-4">
              <p className="text-theme-sm font-medium text-gray-600 dark:text-gray-400">
                Total Value
              </p>
              <p className="text-2xl font-bold text-gray-900 dark:text-white">
                {formatCurrency(stats.totalAmount)}
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

      {/* Invoices Table */}
      <Card padding={false}>
        <Card.Header>
          <div className="flex items-center justify-between">
            <h2 className="text-lg font-semibold text-gray-900 dark:text-white">
              Invoices ({filteredInvoices.length})
            </h2>
          </div>
        </Card.Header>
        
        {filteredInvoices.length === 0 ? (
          <Card.Content>
            <div className="text-center py-12">
              <FileText className="mx-auto h-12 w-12 text-gray-400 mb-4" />
              <h3 className="text-lg font-medium text-gray-900 dark:text-white mb-2">
                No invoices found
              </h3>
              <p className="text-gray-500 dark:text-gray-400">
                {filters.search || filters.status 
                  ? 'Try adjusting your filters' 
                  : 'Get started by creating your first invoice'}
              </p>
            </div>
          </Card.Content>
        ) : (
          <Table>
            <Table.Header>
              <Table.Row>
                <Table.Head sortable>Invoice #</Table.Head>
                <Table.Head>Customer</Table.Head>
                <Table.Head>Issue Date</Table.Head>
                <Table.Head>Due Date</Table.Head>
                <Table.Head>Amount</Table.Head>
                <Table.Head>Status</Table.Head>
                <Table.Head>Actions</Table.Head>
              </Table.Row>
            </Table.Header>
            <Table.Body>
              {filteredInvoices.map((invoice) => (
                <Table.Row key={invoice.id}>
                  <Table.Cell>
                    <div className="font-medium text-gray-900 dark:text-white">
                      {invoice.invoiceNumber}
                    </div>
                    <div className="text-theme-xs text-gray-500 dark:text-gray-400">
                      Created {formatDate(invoice.createdAt)}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div>
                      <div className="font-medium text-gray-900 dark:text-white">
                        {invoice.customer.name}
                      </div>
                      <div className="text-theme-sm text-gray-500 dark:text-gray-400">
                        {invoice.customer.companyName}
                      </div>
                      <div className="text-theme-xs text-gray-500 dark:text-gray-400">
                        {invoice.customer.email}
                      </div>
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center text-gray-900 dark:text-white">
                      <Calendar className="w-4 h-4 mr-1 text-gray-400" />
                      {formatDate(invoice.issueDate)}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className={`flex items-center ${
                      invoice.status === 'overdue' ? 'text-error-600' : 'text-gray-900 dark:text-white'
                    }`}>
                      <Calendar className="w-4 h-4 mr-1 text-gray-400" />
                      {formatDate(invoice.dueDate)}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div>
                      <div className="font-medium text-gray-900 dark:text-white">
                        {formatCurrency(invoice.totalAmount)}
                      </div>
                      <div className="text-theme-xs text-gray-500 dark:text-gray-400">
                        Subtotal: {formatCurrency(invoice.subtotal)}
                      </div>
                    </div>
                  </Table.Cell>
                  <Table.Cell>{getStatusBadge(invoice.status)}</Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center space-x-2">
                      <Button variant="outline" size="sm">
                        <Eye className="w-4 h-4" />
                      </Button>
                      <Button variant="outline" size="sm">
                        <Edit className="w-4 h-4" />
                      </Button>
                      <Button variant="outline" size="sm">
                        <Download className="w-4 h-4" />
                      </Button>
                    </div>
                  </Table.Cell>
                </Table.Row>
              ))}
            </Table.Body>
          </Table>
        )}
      </Card>
    </div>
  );
};

export default Invoices;