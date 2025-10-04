import React, { useState, useEffect } from 'react';
import { 
  Truck, 
  Package, 
  User, 
  MapPin, 
  CheckCircle, 
  AlertCircle, 
  RefreshCw,
  Search,
  Filter,
  Eye,
  Download,
  Printer,
  ArrowLeft,
  DollarSign
} from 'lucide-react';
import { useAuth } from '../context/AuthContext';
import { Card, Button, Badge, Table, FilterPanel, FilterField } from '../components/ui';
import { wmsApi, Dispatch, Parcel } from '../services/wmsApi';

interface DispatchFilterState {
  search: string;
  status: string;
  destination: string;
  driver: string;
  vehicleNumber: string;
}

interface EnhancedDispatch extends Omit<Dispatch, 'parcelIds'> {
  parcelIds: string[]; // Always normalized to array in UI
  totalWeight?: number;
  totalAmount?: number;
  totalParcels?: number;
}

interface EnhancedParcel extends Parcel {
  createdByDisplayName?: string;
}

const ViewDispatch: React.FC = () => {
  const { user } = useAuth();
  const [dispatches, setDispatches] = useState<EnhancedDispatch[]>([]);
  const [filteredDispatches, setFilteredDispatches] = useState<EnhancedDispatch[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');
  const [showFilters, setShowFilters] = useState(false);
  const [selectedDispatch, setSelectedDispatch] = useState<EnhancedDispatch | null>(null);
  const [dispatchParcels, setDispatchParcels] = useState<EnhancedParcel[]>([]);
  const [loadingParcels, setLoadingParcels] = useState(false);
  const [userCache, setUserCache] = useState<Map<number, string>>(new Map());

  const [filters, setFilters] = useState<DispatchFilterState>({
    search: '',
    status: '',
    destination: '',
    driver: '',
    vehicleNumber: ''
  });

  useEffect(() => {
    fetchDispatches();
  }, []);

  useEffect(() => {
    applyFilters();
  }, [dispatches, filters]);

  const fetchDispatches = async () => {
    try {
      setLoading(true);
      setError('');
      
      const branch = user?.isBranchManager ? user.branch : undefined;
      const data = await wmsApi.getDispatches(branch);
      
      // Cast to EnhancedDispatch since API service normalizes parcelIds
      const enhancedDispatches = data.map(dispatch => dispatch as EnhancedDispatch);
      setDispatches(enhancedDispatches);
    } catch (err) {
      setError('Failed to load dispatches');
      console.error('Error fetching dispatches:', err);
    } finally {
      setLoading(false);
    }
  };

  const applyFilters = () => {
    let filtered = dispatches;

    // Apply filters
    if (filters.search) {
      filtered = filtered.filter(dispatch =>
        dispatch.dispatchCode.toLowerCase().includes(filters.search.toLowerCase()) ||
        dispatch.driver.toLowerCase().includes(filters.search.toLowerCase()) ||
        dispatch.vehicleNumber.toLowerCase().includes(filters.search.toLowerCase()) ||
        dispatch.destination.toLowerCase().includes(filters.search.toLowerCase())
      );
    }

    if (filters.status) {
      filtered = filtered.filter(dispatch => dispatch.status === filters.status);
    }

    if (filters.destination) {
      filtered = filtered.filter(dispatch =>
        dispatch.destination.toLowerCase().includes(filters.destination.toLowerCase())
      );
    }

    if (filters.driver) {
      filtered = filtered.filter(dispatch =>
        dispatch.driver.toLowerCase().includes(filters.driver.toLowerCase())
      );
    }

    if (filters.vehicleNumber) {
      filtered = filtered.filter(dispatch =>
        dispatch.vehicleNumber.toLowerCase().includes(filters.vehicleNumber.toLowerCase())
      );
    }

    setFilteredDispatches(filtered);
  };

  const handleFilterChange = (key: string, value: string | { from: string; to: string }) => {
    setFilters(prev => ({ ...prev, [key]: value }));
  };

  const clearFilters = () => {
    setFilters({
      search: '',
      status: '',
      destination: '',
      driver: '',
      vehicleNumber: ''
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
      chips.push({
        key: 'status',
        label: 'Status',
        value: filters.status,
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

    if (filters.driver) {
      chips.push({
        key: 'driver',
        label: 'Driver',
        value: filters.driver,
        onRemove: () => handleFilterChange('driver', '')
      });
    }

    if (filters.vehicleNumber) {
      chips.push({
        key: 'vehicleNumber',
        label: 'Vehicle',
        value: filters.vehicleNumber,
        onRemove: () => handleFilterChange('vehicleNumber', '')
      });
    }

    return chips;
  };

  const filterFields: FilterField[] = [
    {
      key: 'search',
      label: 'Search',
      type: 'text',
      placeholder: 'Search by dispatch code, driver, vehicle, or destination',
      icon: <Search className="w-4 h-4" />
    },
    {
      key: 'status',
      label: 'Status',
      type: 'select',
      placeholder: 'Select status',
      icon: <CheckCircle className="w-4 h-4" />,
      options: [
        { value: 'pending', label: 'Pending' },
        { value: 'in_transit', label: 'In Transit' },
        { value: 'delivered', label: 'Delivered' },
        { value: 'cancelled', label: 'Cancelled' }
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
      key: 'driver',
      label: 'Driver',
      type: 'text',
      placeholder: 'Filter by driver name',
      icon: <User className="w-4 h-4" />
    },
    {
      key: 'vehicleNumber',
      label: 'Vehicle Number',
      type: 'text',
      placeholder: 'Filter by vehicle number',
      icon: <Truck className="w-4 h-4" />
    }
  ];

  const handleViewDispatch = async (dispatch: EnhancedDispatch) => {
    setSelectedDispatch(dispatch);
    setLoadingParcels(true);
    
    try {
      console.log('Viewing dispatch:', dispatch);
      console.log('Dispatch parcelIds (normalized by API):', dispatch.parcelIds);
      console.log('Dispatch parcels:', dispatch.parcels);
      console.log('ParcelIds length:', dispatch.parcelIds.length);
      
      // Fetch parcels for this dispatch
      const parcels: EnhancedParcel[] = [];
      
      // If dispatch already has parcels, use them and enhance with user info
      if (dispatch.parcels && dispatch.parcels.length > 0) {
        console.log('Using existing parcels from dispatch');
        for (const parcel of dispatch.parcels) {
          const enhancedParcel: EnhancedParcel = {
            ...parcel,
            createdByDisplayName: await getUserDisplayName(parcel.createdById)
          };
          parcels.push(enhancedParcel);
        }
        setDispatchParcels(parcels);
      } else if (dispatch.parcelIds && dispatch.parcelIds.length > 0) {
        console.log('Fetching parcels individually for IDs:', dispatch.parcelIds);
        // Otherwise fetch parcels individually
        for (const parcelId of dispatch.parcelIds) {
          try {
            console.log('Fetching parcel:', parcelId);
            const parcel = await wmsApi.getParcelById(parcelId);
            if (parcel) {
              console.log('Found parcel:', parcel.waybillNumber);
              const enhancedParcel: EnhancedParcel = {
                ...parcel,
                createdByDisplayName: await getUserDisplayName(parcel.createdById)
              };
              parcels.push(enhancedParcel);
            } else {
              console.warn('Parcel not found:', parcelId);
            }
          } catch (err) {
            console.warn(`Failed to fetch parcel ${parcelId}:`, err);
          }
        }
        console.log(`All fetched parcels for ${dispatch.dispatchCode}:`, parcels.length);
        setDispatchParcels(parcels);
      } else {
        console.log('No parcel IDs or parcels found in dispatch');
        setDispatchParcels([]);
      }
    } catch (err) {
      console.error('Error in handleViewDispatch:', err);
      setError('Failed to load dispatch parcels');
    } finally {
      setLoadingParcels(false);
    }
  };

  const handlePrintDispatchNote = async (dispatch: EnhancedDispatch) => {
    try {
      const dispatchNote = await wmsApi.getDispatchById(dispatch.id);
      
      if (dispatchNote) {
        // Create a new window for printing
        const printWindow = window.open('', '_blank');
        if (printWindow) {
          const eatDateTime = formatDateTime(dispatch.dispatchTime);
        printWindow.document.write(`
            <html>
              <head>
                <title>Dispatch Note - ${dispatch.dispatchCode}</title>
                <style>
                  body { 
                    font-family: Arial, sans-serif; 
                    padding: 20px; 
                    margin: 0;
                    font-size: 12px;
                  }
                  .header { 
                    text-align: center; 
                    margin-bottom: 20px; 
                    border-bottom: 2px solid #000;
                    padding-bottom: 15px;
                  }
                  .header h1 {
                    margin: 0;
                    font-size: 18px;
                    font-weight: bold;
                  }
                  .header h2 {
                    margin: 5px 0 0 0;
                    font-size: 14px;
                    color: #666;
                  }
                  .info-grid { 
                    display: grid;
                    grid-template-columns: 1fr 1fr 1fr;
                    gap: 20px;
                    margin-bottom: 20px;
                    background: #f8f9fa;
                    padding: 15px;
                    border-radius: 5px;
                  }
                  .info-item {
                    display: flex;
                    flex-direction: column;
                  }
                  .info-label {
                    font-weight: bold;
                    color: #333;
                    font-size: 11px;
                    margin-bottom: 2px;
                  }
                  .info-value {
                    color: #000;
                    font-size: 12px;
                  }
                  .status-badge {
                    background: #007bff;
                    color: white;
                    padding: 2px 8px;
                    border-radius: 3px;
                    font-size: 10px;
                    display: inline-block;
                  }
                  .parcels-header {
                    background: #f0f0f0;
                    padding: 10px;
                    margin: 20px 0 10px 0;
                    font-weight: bold;
                    font-size: 14px;
                  }
                  table { 
                    width: 100%; 
                    border-collapse: collapse; 
                    font-size: 10px;
                  }
                  th, td { 
                    border: 1px solid #ccc; 
                    padding: 8px 4px; 
                    text-align: left; 
                    vertical-align: top;
                  }
                  th { 
                    background-color: #f8f9fa; 
                    font-weight: bold;
                    font-size: 9px;
                    text-align: center;
                  }
                  td {
                    font-size: 9px;
                  }
                  .total-row {
                    background-color: #f8f9fa;
                    font-weight: bold;
                  }
                  .signatures {
                    margin-top: 40px;
                    display: grid;
                    grid-template-columns: 1fr 1fr 1fr;
                    gap: 50px;
                  }
                  .signature-line {
                    border-bottom: 1px solid #000;
                    height: 40px;
                    margin-bottom: 5px;
                  }
                  .signature-label {
                    font-size: 10px;
                    font-weight: bold;
                    text-align: center;
                  }
                  .payment-summary {
                    margin-top: 20px;
                    font-size: 11px;
                    font-weight: bold;
                  }
                  @media print {
                    body { margin: 0; }
                    .no-print { display: none; }
                  }
                </style>
              </head>
              <body>
                <div class="header">
                  <h1>LOGISTICS DISPATCH NOTE</h1>
                  <h2>WMS DISPATCH SYSTEM</h2>
                </div>
                
                <div class="info-grid">
                  <div class="info-item">
                    <span class="info-label">Dispatch Code:</span>
                    <span class="info-value">${dispatch.dispatchCode}</span>
                  </div>
                  <div class="info-item">
                    <span class="info-label">Destination:</span>
                    <span class="info-value">${dispatch.destination}</span>
                  </div>
                  <div class="info-item">
                    <span class="info-label">Date:</span>
                    <span class="info-value">${eatDateTime.full}</span>
                  </div>
                  <div class="info-item">
                    <span class="info-label">Total Parcels:</span>
                    <span class="info-value">${dispatch.totalParcels || dispatch.parcelIds?.length || 0}</span>
                  </div>
                  <div class="info-item">
                    <span class="info-label">Total Amount:</span>
                    <span class="info-value">KES ${dispatchParcels.reduce((sum, p) => sum + (p.totalAmount || 0), 0).toFixed(2)}</span>
                  </div>
                  <div class="info-item">
                    <span class="info-label">Status:</span>
                    <span class="status-badge">${dispatch.status}</span>
                  </div>
                  <div class="info-item">
                    <span class="info-label">Vehicle Reg:</span>
                    <span class="info-value">${dispatch.vehicleNumber}</span>
                  </div>
                  <div class="info-item">
                    <span class="info-label">Driver:</span>
                    <span class="info-value">${dispatch.driver}</span>
                  </div>
                </div>

                <div class="parcels-header">PARCELS LIST</div>
                
                <table>
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Waybill</th>
                      <th>Sender</th>
                      <th>Receiver</th>
                      <th>Description</th>
                      <th>Qty</th>
                      <th>Amount</th>
                      <th>Payment Mode</th>
                      <th>Created By</th>
                      <th>Confirmed by</th>
                      <th>Receiver Signature</th>
                      <th>ID Number</th>
                    </tr>
                  </thead>
                  <tbody>
                    ${dispatchParcels.map((parcel, index) => `
                      <tr>
                        <td>${index + 1}</td>
                        <td>${parcel.waybillNumber}</td>
                        <td>${parcel.sender}<br>Tel: ${parcel.senderTelephone}</td>
                        <td>${parcel.receiver}<br>Tel: ${parcel.receiverTelephone}</td>
                        <td>${parcel.description}</td>
                        <td>${parcel.quantity || 0}</td>
                        <td>KES ${(parcel.totalAmount || 0).toFixed(2)}</td>
                        <td>${parcel.paymentMethods || 'N/A'}</td>
                        <td>${parcel.createdByDisplayName || 'N/A'}</td>
                        <td></td>
                        <td></td>
                        <td></td>
                      </tr>
                    `).join('')}
                  </tbody>
                </table>
                
                <div style="text-align: right; margin-top: 20px; font-weight: bold; font-size: 12px;">
                  TOTAL: KES ${dispatchParcels.reduce((sum, p) => sum + (p.totalAmount || 0), 0).toFixed(2)}
                </div>

                <div class="signatures">
                  <div>
                    <div class="signature-line"></div>
                    <div class="signature-label">Dispatcher Signature</div>
                  </div>
                  <div>
                    <div class="signature-line"></div>
                    <div class="signature-label">Driver Signature</div>
                  </div>
                  <div>
                    <div class="signature-line"></div>
                    <div class="signature-label">Supervisor Signature</div>
                  </div>
                </div>

                <div class="payment-summary">
                  <h3>Payment Method Totals:</h3>
                </div>
              </body>
            </html>
          `);
          printWindow.document.close();
          printWindow.print();
        }
      }
    } catch (err) {
      setError('Failed to generate dispatch note');
    }
  };

  const getStatusBadge = (status: string) => {
    const statusMap = {
      'pending': { variant: 'warning' as const, label: 'Pending' },
      'in_transit': { variant: 'primary' as const, label: 'In Transit' },
      'delivered': { variant: 'success' as const, label: 'Delivered' },
      'cancelled': { variant: 'error' as const, label: 'Cancelled' },
    };
    
    const statusInfo = statusMap[status as keyof typeof statusMap] || { variant: 'gray' as const, label: status };
    return <Badge variant={statusInfo.variant}>{statusInfo.label}</Badge>;
  };

  const formatCurrency = (amount: number) => {
    return new Intl.NumberFormat('en-KE', {
      style: 'currency',
      currency: 'KES',
      minimumFractionDigits: 0
    }).format(amount).replace('KES', 'KSh');
  };

  const formatDateTime = (dateString: string) => {
    const date = new Date(dateString);
    // Display timestamp as-is (no timezone conversion)
    return {
      date: date.toLocaleDateString('en-KE'),
      time: date.toLocaleTimeString('en-KE', { hour12: false }),
      full: date.toLocaleString('en-KE', { hour12: false })
    };
  };

  const getUserDisplayName = async (userId: number): Promise<string> => {
    // Check cache first
    if (userCache.has(userId)) {
      return userCache.get(userId)!;
    }

    try {
      const user = await wmsApi.getUserById(userId);
      const displayName = user?.username || user?.firstName || `User ${userId}`;
      
      // Cache the result
      setUserCache(prev => new Map(prev).set(userId, displayName));
      
      return displayName;
    } catch (error) {
      console.error(`Failed to fetch user ${userId}:`, error);
      const fallback = `User ${userId}`;
      setUserCache(prev => new Map(prev).set(userId, fallback));
      return fallback;
    }
  };

  if (loading) {
    return (
      <div className="flex items-center justify-center min-h-96">
        <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-brand-500"></div>
      </div>
    );
  }

  if (selectedDispatch) {
    return (
      <div className="space-y-6">
        {/* Header */}
        <div className="flex items-center justify-between">
          <div className="flex items-center gap-4">
            <Button
              variant="outline"
              onClick={() => setSelectedDispatch(null)}
            >
              <ArrowLeft className="w-4 h-4 mr-2" />
              Back to Dispatches
            </Button>
            <div>
              <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
                Dispatch Details
              </h1>
              <p className="text-gray-600 dark:text-gray-400 mt-1">
                {selectedDispatch.dispatchCode}
              </p>
            </div>
          </div>
          <div className="flex items-center gap-3">
            <Button
              variant="outline"
              onClick={() => handlePrintDispatchNote(selectedDispatch)}
            >
              <Printer className="w-4 h-4 mr-2" />
              Print Note
            </Button>
            <Button
              variant="primary"
              onClick={() => handlePrintDispatchNote(selectedDispatch)}
            >
              <Download className="w-4 h-4 mr-2" />
              Download PDF
            </Button>
          </div>
        </div>

        {/* Dispatch Information */}
        <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
          <Card>
            <div className="p-6">
              <h3 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
                Dispatch Information
              </h3>
              <div className="space-y-3">
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Dispatch Code:</span>
                  <span className="font-medium text-gray-900 dark:text-white">{selectedDispatch.dispatchCode}</span>
                </div>
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Source Branch:</span>
                  <span className="font-medium text-gray-900 dark:text-white">{selectedDispatch.sourceBranch}</span>
                </div>
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Destination:</span>
                  <span className="font-medium text-gray-900 dark:text-white">{selectedDispatch.destination}</span>
                </div>
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Driver:</span>
                  <span className="font-medium text-gray-900 dark:text-white">{selectedDispatch.driver}</span>
                </div>
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Vehicle:</span>
                  <span className="font-medium text-gray-900 dark:text-white">{selectedDispatch.vehicleNumber}</span>
                </div>
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Status:</span>
                  {getStatusBadge(selectedDispatch.status)}
                </div>
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Dispatch Time:</span>
                  <span className="font-medium text-gray-900 dark:text-white">
                    {formatDateTime(selectedDispatch.dispatchTime).full}
                  </span>
                </div>
              </div>
            </div>
          </Card>

          <Card>
            <div className="p-6">
              <h3 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
                Summary
              </h3>
              <div className="space-y-3">
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Total Parcels:</span>
                  <span className="font-medium text-gray-900 dark:text-white">
                    {selectedDispatch.totalParcels || selectedDispatch.parcelIds?.length || 0}
                  </span>
                </div>
                <div className="flex justify-between">
                  <span className="text-gray-600 dark:text-gray-400">Total Amount:</span>
                  <span className="font-medium text-gray-900 dark:text-white">
                    {formatCurrency(dispatchParcels.reduce((sum, p) => sum + (p.totalAmount || 0), 0))}
                  </span>
                </div>
              </div>
            </div>
          </Card>
        </div>

        {/* Parcels Table */}
        <Card padding={false}>
          <div className="p-6 border-b border-gray-200">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
              Dispatch Parcels ({dispatchParcels.length})
            </h3>
          </div>
          
          {loadingParcels ? (
            <div className="p-6 text-center">
              <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-brand-500 mx-auto"></div>
            </div>
          ) : dispatchParcels.length === 0 ? (
            <div className="p-6 text-center">
              <Package className="w-12 h-12 text-gray-400 mx-auto mb-4" />
              <h3 className="text-lg font-medium text-gray-900 dark:text-white mb-2">
                No parcels found
              </h3>
              <p className="text-gray-500 dark:text-gray-400">
                This dispatch doesn't have any parcels associated with it.
              </p>
            </div>
          ) : (
            <Table>
              <Table.Header>
                <Table.Row>
                  <Table.Head>Waybill Number</Table.Head>
                  <Table.Head>Sender</Table.Head>
                  <Table.Head>Receiver</Table.Head>
                  <Table.Head>Destination</Table.Head>
                  <Table.Head>Qty</Table.Head>
                  <Table.Head>Amount</Table.Head>
                  <Table.Head>Payment Mode</Table.Head>
                  <Table.Head>Clerk</Table.Head>
                  <Table.Head>Status</Table.Head>
                </Table.Row>
              </Table.Header>
              <Table.Body>
                {dispatchParcels.map((parcel) => (
                  <Table.Row key={parcel.id}>
                    <Table.Cell>
                      <div className="font-medium text-gray-900 dark:text-white">
                        {parcel.waybillNumber}
                      </div>
                    </Table.Cell>
                    <Table.Cell>
                      <div className="text-gray-900 dark:text-white">{parcel.sender}</div>
                      <div className="text-sm text-gray-500">{parcel.senderTelephone}</div>
                    </Table.Cell>
                    <Table.Cell>
                      <div className="text-gray-900 dark:text-white">{parcel.receiver}</div>
                      <div className="text-sm text-gray-500">{parcel.receiverTelephone}</div>
                    </Table.Cell>
                    <Table.Cell>
                      <div className="flex items-center text-gray-900 dark:text-white">
                        <MapPin className="w-4 h-4 mr-1 text-gray-400" />
                        {parcel.destination}
                      </div>
                    </Table.Cell>
                    <Table.Cell>{parcel.quantity}</Table.Cell>
                    <Table.Cell>{formatCurrency(parcel.totalAmount)}</Table.Cell>
                    <Table.Cell>
                      <Badge variant="gray">
                        {parcel.paymentMethods || 'N/A'}
                      </Badge>
                    </Table.Cell>
                    <Table.Cell>
                      <span className="text-gray-900 dark:text-white">
                        {parcel.createdByDisplayName || 'Loading...'}
                      </span>
                    </Table.Cell>
                    <Table.Cell>
                      <Badge variant={parcel.status === 3 ? 'success' : parcel.status === 2 ? 'primary' : 'warning'}>
                        {parcel.status === 0 ? 'Pending' : parcel.status === 1 ? 'Finalized' : parcel.status === 2 ? 'In Transit' : parcel.status === 3 ? 'Delivered' : 'Cancelled'}
                      </Badge>
                    </Table.Cell>
                  </Table.Row>
                ))}
              </Table.Body>
            </Table>
          )}
        </Card>
      </div>
    );
  }

  return (
    <div className="space-y-6">
      {/* Header */}
      <div className="flex items-center justify-between">
        <div>
          <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
            View Dispatches
          </h1>
          <p className="text-gray-600 dark:text-gray-400 mt-1">
            Manage and track dispatch operations
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
            onClick={fetchDispatches}
            disabled={loading}
          >
            <RefreshCw className={`w-4 h-4 mr-2 ${loading ? 'animate-spin' : ''}`} />
            Refresh
          </Button>
        </div>
      </div>

      {/* Error Message */}
      {error && (
        <div className="bg-error-50 border border-error-200 text-error-800 px-4 py-3 rounded-lg flex items-center gap-2">
          <AlertCircle className="w-5 h-5" />
          {error}
        </div>
      )}

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

      {/* Dispatches Table */}
      <Card padding={false}>
        <div className="p-6 border-b border-gray-200">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
            Dispatches ({filteredDispatches.length})
          </h3>
        </div>

        {filteredDispatches.length === 0 ? (
          <div className="p-6 text-center">
            <Truck className="w-12 h-12 text-gray-400 mx-auto mb-4" />
            <h3 className="text-lg font-medium text-gray-900 dark:text-white mb-2">
              No dispatches found
            </h3>
            <p className="text-gray-500 dark:text-gray-400">
              {Object.values(filters).some(filter => filter) ? 'Try adjusting your filters' : 'No dispatches have been created yet'}
            </p>
          </div>
        ) : (
          <Table>
            <Table.Header>
              <Table.Row>
                <Table.Head>Dispatch Code</Table.Head>
                <Table.Head>Source Branch</Table.Head>
                <Table.Head>Destination</Table.Head>
                <Table.Head>Driver</Table.Head>
                <Table.Head>Vehicle</Table.Head>
                <Table.Head>Parcels</Table.Head>
                <Table.Head>Status</Table.Head>
                <Table.Head>Dispatch Time</Table.Head>
                <Table.Head>Actions</Table.Head>
              </Table.Row>
            </Table.Header>
            <Table.Body>
              {filteredDispatches.map((dispatch) => (
                <Table.Row key={dispatch.id}>
                  <Table.Cell>
                    <div className="font-medium text-gray-900 dark:text-white">
                      {dispatch.dispatchCode}
                    </div>
                  </Table.Cell>
                  <Table.Cell>{dispatch.sourceBranch}</Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center text-gray-900 dark:text-white">
                      <MapPin className="w-4 h-4 mr-1 text-gray-400" />
                      {dispatch.destination}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center text-gray-900 dark:text-white">
                      <User className="w-4 h-4 mr-1 text-gray-400" />
                      {dispatch.driver}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center text-gray-900 dark:text-white">
                      <Truck className="w-4 h-4 mr-1 text-gray-400" />
                      {dispatch.vehicleNumber}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center gap-2">
                      <Package className="w-4 h-4 text-gray-400" />
                      <Badge variant="gray">
                        {dispatch.totalParcels || dispatch.parcelIds?.length || dispatch.parcels?.length || 0}
                      </Badge>
                    </div>
                  </Table.Cell>
                  <Table.Cell>{getStatusBadge(dispatch.status)}</Table.Cell>
                  <Table.Cell>
                    <div className="text-sm text-gray-500">
                      {formatDateTime(dispatch.dispatchTime).date}
                    </div>
                    <div className="text-sm text-gray-400">
                      {formatDateTime(dispatch.dispatchTime).time}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center space-x-2">
                      <Button
                        variant="outline"
                        size="sm"
                        onClick={() => handleViewDispatch(dispatch)}
                        title="View Details"
                      >
                        <Eye className="w-4 h-4" />
                      </Button>
                      <Button
                        variant="outline"
                        size="sm"
                        onClick={() => handlePrintDispatchNote(dispatch)}
                        title="Print Note"
                      >
                        <Printer className="w-4 h-4" />
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

export default ViewDispatch;