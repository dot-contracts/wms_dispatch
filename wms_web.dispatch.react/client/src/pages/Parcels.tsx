import React, { useState, useEffect } from 'react';
import { Package, Search, Filter, Download, Eye, Edit, RefreshCw, Calendar, MapPin, DollarSign, User, Phone } from 'lucide-react';
import { useAuth } from '../context/AuthContext';
import { Card, Button, Badge, Table, FilterPanel, FilterField } from '../components/ui';
import { wmsApi, Parcel } from '../services/wmsApi';

interface ParcelFilterState {
  search: string;
  status: string;
  destination: string;
  paymentMethod: string;
  amountRange: { from: string; to: string };
  dateRange: { from: string; to: string };
  sender: string;
  receiver: string;
}

const Parcels: React.FC = () => {
  const [parcels, setParcels] = useState<Parcel[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');
  const [showFilters, setShowFilters] = useState(false);
  
  const [filters, setFilters] = useState<ParcelFilterState>({
    search: '',
    status: '',
    destination: '',
    paymentMethod: '',
    amountRange: { from: '', to: '' },
    dateRange: { from: '', to: '' },
    sender: '',
    receiver: ''
  });

  const { user } = useAuth();

  useEffect(() => {
    fetchParcels();
  }, []);

  const fetchParcels = async () => {
    try {
      setLoading(true);
      setError('');
      
      // Use the branch if user is a branch manager
      const branch = user?.isBranchManager ? user.branch : undefined;
      
      const data = await wmsApi.getParcels(branch);
      setParcels(data);
    } catch (err) {
      setError('Failed to load parcels');
      console.error('Error fetching parcels:', err);
    } finally {
      setLoading(false);
    }
  };

  const getStatusBadge = (status: number) => {
    const statusMap = {
      0: { label: 'Pending', variant: 'warning' as const },
      1: { label: 'Finalized', variant: 'primary' as const },
      2: { label: 'In Transit', variant: 'primary' as const },
      3: { label: 'Delivered', variant: 'success' as const },
      4: { label: 'Cancelled', variant: 'error' as const },
    };
    
    const statusInfo = statusMap[status as keyof typeof statusMap] || { label: 'Unknown', variant: 'gray' as const };
    return <Badge variant={statusInfo.variant}>{statusInfo.label}</Badge>;
  };

  const handleFilterChange = (key: string, value: string | { from: string; to: string }) => {
    setFilters(prev => ({ ...prev, [key]: value }));
  };

  const clearFilters = () => {
    setFilters({
      search: '',
      status: '',
      destination: '',
      paymentMethod: '',
      amountRange: { from: '', to: '' },
      dateRange: { from: '', to: '' },
      sender: '',
      receiver: ''
    });
  };

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
      const statusOptions = [
        { value: '0', label: 'Pending' },
        { value: '1', label: 'Finalized' },
        { value: '2', label: 'In Transit' },
        { value: '3', label: 'Delivered' },
        { value: '4', label: 'Cancelled' }
      ];
      const statusLabel = statusOptions.find(s => s.value === filters.status)?.label || filters.status;
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
      const rangeValue = `${filters.dateRange.from || 'Start'} to ${filters.dateRange.to || 'End'}`;
      chips.push({
        key: 'dateRange',
        label: 'Date Range',
        value: rangeValue,
        onRemove: () => handleFilterChange('dateRange', { from: '', to: '' })
      });
    }

    if (filters.sender) {
      chips.push({
        key: 'sender',
        label: 'Sender',
        value: filters.sender,
        onRemove: () => handleFilterChange('sender', '')
      });
    }

    if (filters.receiver) {
      chips.push({
        key: 'receiver',
        label: 'Receiver',
        value: filters.receiver,
        onRemove: () => handleFilterChange('receiver', '')
      });
    }

    return chips;
  };

  const filterFields: FilterField[] = [
    {
      key: 'search',
      label: 'Search',
      type: 'text',
      placeholder: 'Search by waybill, destination, sender, or receiver',
      icon: <Search className="w-4 h-4" />
    },
    {
      key: 'status',
      label: 'Status',
      type: 'select',
      placeholder: 'Select status',
      icon: <Package className="w-4 h-4" />,
      options: [
        { value: '0', label: 'Pending' },
        { value: '1', label: 'Finalized' },
        { value: '2', label: 'In Transit' },
        { value: '3', label: 'Delivered' },
        { value: '4', label: 'Cancelled' }
      ]
    },
    {
      key: 'destination',
      label: 'Destination',
      type: 'text',
      placeholder: 'Filter by destination',
      icon: <MapPin className="w-4 h-4" />
    },
    {
      key: 'paymentMethod',
      label: 'Payment Method',
      type: 'text',
      placeholder: 'Filter by payment method',
      icon: <DollarSign className="w-4 h-4" />
    },
    {
      key: 'amountRange',
      label: 'Amount Range',
      type: 'numberRange',
      placeholder: 'Enter amount range',
      icon: <DollarSign className="w-4 h-4" />
    },
    {
      key: 'dateRange',
      label: 'Date Range',
      type: 'dateRange',
      placeholder: 'Select date range',
      icon: <Calendar className="w-4 h-4" />
    },
    {
      key: 'sender',
      label: 'Sender',
      type: 'text',
      placeholder: 'Filter by sender name',
      icon: <User className="w-4 h-4" />
    },
    {
      key: 'receiver',
      label: 'Receiver',
      type: 'text',
      placeholder: 'Filter by receiver name',
      icon: <User className="w-4 h-4" />
    }
  ];

  const filteredParcels = parcels.filter(parcel => {
    // Search filter
    const matchesSearch = !filters.search || 
      parcel.waybillNumber.toLowerCase().includes(filters.search.toLowerCase()) ||
      parcel.destination.toLowerCase().includes(filters.search.toLowerCase()) ||
      parcel.sender.toLowerCase().includes(filters.search.toLowerCase()) ||
      parcel.receiver.toLowerCase().includes(filters.search.toLowerCase());
    
    // Status filter
    const matchesStatus = !filters.status || parcel.status.toString() === filters.status;
    
    // Destination filter
    const matchesDestination = !filters.destination || 
      parcel.destination.toLowerCase().includes(filters.destination.toLowerCase());
    
    // Payment method filter
    const matchesPaymentMethod = !filters.paymentMethod || 
      parcel.paymentMethods.toLowerCase().includes(filters.paymentMethod.toLowerCase());
    
    // Amount range filter
    const matchesAmountRange = (!filters.amountRange.from && !filters.amountRange.to) ||
      ((filters.amountRange.from ? parcel.totalAmount >= Number(filters.amountRange.from) : true) &&
       (filters.amountRange.to ? parcel.totalAmount <= Number(filters.amountRange.to) : true));
    
    // Date range filter
    const matchesDateRange = (!filters.dateRange.from && !filters.dateRange.to) ||
      ((filters.dateRange.from ? new Date(parcel.createdAt) >= new Date(filters.dateRange.from) : true) &&
       (filters.dateRange.to ? new Date(parcel.createdAt) <= new Date(filters.dateRange.to) : true));
    
    // Sender filter
    const matchesSender = !filters.sender || 
      parcel.sender.toLowerCase().includes(filters.sender.toLowerCase());
    
    // Receiver filter
    const matchesReceiver = !filters.receiver || 
      parcel.receiver.toLowerCase().includes(filters.receiver.toLowerCase());
    
    return matchesSearch && matchesStatus && matchesDestination && matchesPaymentMethod && 
           matchesAmountRange && matchesDateRange && matchesSender && matchesReceiver;
  });

  const formatCurrency = (amount: number) => {
    return new Intl.NumberFormat('en-KE', {
      style: 'currency',
      currency: 'KES',
      minimumFractionDigits: 0
    }).format(amount).replace('KES', 'KSh');
  };

  if (loading) {
    return (
      <div className="flex items-center justify-center min-h-96">
        <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-brand-500"></div>
      </div>
    );
  }

  if (error) {
    return (
      <Card>
        <div className="text-center py-12">
          <Package className="mx-auto h-12 w-12 text-gray-400 mb-4" />
          <h3 className="text-lg font-medium text-gray-900 mb-2">Error Loading Parcels</h3>
          <p className="text-gray-500 mb-4">{error}</p>
          <Button onClick={fetchParcels}>Try Again</Button>
        </div>
      </Card>
    );
  }

  return (
    <div className="space-y-6">
      {/* Header */}
      <div className="flex items-center justify-between">
        <div>
          <h1 className="text-title-md font-bold text-gray-900 dark:text-white">Parcels</h1>
          <p className="text-gray-600 dark:text-gray-400">
            {user?.isBranchManager ? `Showing parcels for ${user.branch || 'your'} branch` : 'Showing all parcels'}
          </p>
        </div>
        <div className="flex items-center gap-3">
          <Button
            variant="outline"
            onClick={() => setShowFilters(!showFilters)}
          >
            <Filter className="w-4 h-4 mr-2" />
            Filters
          </Button>
          <Button
            variant="primary"
            onClick={fetchParcels}
            disabled={loading}
          >
            <RefreshCw className={`w-4 h-4 mr-2 ${loading ? 'animate-spin' : ''}`} />
            Refresh
          </Button>
          <Button variant="primary">
            <Package className="w-4 h-4 mr-2" />
            Add Parcel
          </Button>
        </div>
      </div>

      {/* Filters */}
      {showFilters && (
        <FilterPanel
          fields={filterFields}
          filters={filters as any}
          onFilterChange={handleFilterChange}
          onClearFilters={clearFilters}
          activeFilters={getActiveFilterChips()}
          collapsible={true}
          defaultExpanded={true}
        />
      )}

      {/* Parcels Table */}
      <Card padding={false}>
        <Card.Header>
          <div className="flex items-center justify-between">
            <h2 className="text-lg font-semibold text-gray-900 dark:text-white">
              Parcels ({filteredParcels.length})
            </h2>
            <Button variant="outline" size="sm">
              <Download className="w-4 h-4 mr-2" />
              Export
            </Button>
          </div>
        </Card.Header>
        
        {filteredParcels.length === 0 ? (
          <Card.Content>
            <div className="text-center py-12">
              <Package className="mx-auto h-12 w-12 text-gray-400 mb-4" />
              <h3 className="text-lg font-medium text-gray-900 dark:text-white mb-2">No parcels found</h3>
              <p className="text-gray-500 dark:text-gray-400">
                {Object.values(filters).some(filter => 
                  typeof filter === 'string' ? filter : 
                  typeof filter === 'object' && filter !== null ? 
                    Object.values(filter).some(v => v) : false
                ) ? 'Try adjusting your filters' : 'No parcels have been created yet'}
              </p>
            </div>
          </Card.Content>
        ) : (
          <Table>
            <Table.Header>
              <Table.Row>
                <Table.Head>Waybill Number</Table.Head>
                <Table.Head>Destination</Table.Head>
                <Table.Head>Status</Table.Head>
                <Table.Head>Sender</Table.Head>
                <Table.Head>Receiver</Table.Head>
                <Table.Head>Amount</Table.Head>
                <Table.Head>Payment Method</Table.Head>
                <Table.Head>Created Date</Table.Head>
                <Table.Head>Actions</Table.Head>
              </Table.Row>
            </Table.Header>
            <Table.Body>
              {filteredParcels.map((parcel) => (
                <Table.Row key={parcel.id}>
                  <Table.Cell>
                    <div className="font-medium text-gray-900 dark:text-white">
                      {parcel.waybillNumber}
                    </div>
                    <div className="text-theme-xs text-gray-500">
                      ID: {parcel.id}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center text-gray-900 dark:text-white">
                      <MapPin className="w-4 h-4 mr-1 text-gray-400" />
                      {parcel.destination}
                    </div>
                  </Table.Cell>
                  <Table.Cell>{getStatusBadge(parcel.status)}</Table.Cell>
                  <Table.Cell>
                    <div className="text-gray-900 dark:text-white">{parcel.sender}</div>
                    <div className="text-theme-xs text-gray-500 flex items-center">
                      <Phone className="w-3 h-3 mr-1" />
                      {parcel.senderTelephone}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="text-gray-900 dark:text-white">{parcel.receiver}</div>
                    <div className="text-theme-xs text-gray-500 flex items-center">
                      <Phone className="w-3 h-3 mr-1" />
                      {parcel.receiverTelephone}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="font-medium">{formatCurrency(parcel.totalAmount)}</div>
                    <div className="text-theme-xs text-gray-500">Qty: {parcel.quantity}</div>
                  </Table.Cell>
                  <Table.Cell>
                    <Badge variant="gray">
                      {parcel.paymentMethods}
                    </Badge>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="text-theme-xs text-gray-500">
                      {new Date(parcel.createdAt).toLocaleDateString()}
                    </div>
                    <div className="text-theme-xs text-gray-400">
                      {new Date(parcel.createdAt).toLocaleTimeString()}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center space-x-2">
                      <Button variant="outline" size="sm" title="View Details">
                        <Eye className="w-4 h-4" />
                      </Button>
                      <Button variant="outline" size="sm" title="Edit Parcel">
                        <Edit className="w-4 h-4" />
                      </Button>
                      <Button variant="outline" size="sm" title="Download">
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

export default Parcels;