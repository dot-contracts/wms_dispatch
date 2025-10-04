import React, { useState, useEffect, useCallback } from 'react';
import { useAuth } from '../context/AuthContext';
import { wmsApi, Parcel, Dispatch } from '../services/wmsApi';
import { 
  BarChart, 
  LineChart,
  TrendingUp,
  TrendingDown,
  Users,
  Package,
  FileText,
  Download,
  Filter,
  Calendar,
  DollarSign,
  Truck,
  CheckCircle,
  AlertCircle,
  Printer,
  RefreshCw,
  Search,
  Eye,
  X,
  ChevronRight,
  MapPin,
  Clock
} from 'lucide-react';
import Chart from 'react-apexcharts';
import { Card, Button, Badge, Table, FilterPanel, FilterField } from '../components/ui';

interface ReportFilters {
  startDate: string;
  endDate: string;
  branch: string;
  destination: string;
  clerk: string;
}

interface SalesPerClerkData {
  clerkName: string;
  clerkUsername: string;
  totalParcels: number;
  totalSales: number;
  averagePerParcel: number;
  performance: 'excellent' | 'good' | 'average' | 'below-average';
}

interface DeliveryRateData {
  destination: string;
  totalParcels: number;
  deliveredParcels: number;
  pendingParcels: number;
  inTransitParcels: number;
  deliveryRate: number;
}

interface UndeliveredParcelData {
  dispatchCode: string;
  destination: string;
  driver: string;
  vehicleNumber: string;
  totalParcels: number;
  undeliveredParcels: number;
  totalAmount: number;
  dispatchDate: string;
}

type ReportType = 
  | 'dashboard'
  | 'sales-per-clerk' 
  | 'contract-invoices'
  | 'undelivered-parcels'
  | 'cod-delivered'
  | 'delivery-rate'
  | 'parcel-list';

const Reports: React.FC = () => {
  const [currentReport, setCurrentReport] = useState<ReportType>('dashboard');
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState('');
  const [parcels, setParcels] = useState<Parcel[]>([]);
  const [dispatches, setDispatches] = useState<Dispatch[]>([]);
  const [reportData, setReportData] = useState<any>(null);
  const [showFilters, setShowFilters] = useState(false);
  const [filteredParcels, setFilteredParcels] = useState<Parcel[]>([]);
  const [parcelListLoading, setParcelListLoading] = useState(false);
  const [showParcelFilters, setShowParcelFilters] = useState(false);
  const [destinations, setDestinations] = useState<string[]>([]);
  const [userCache, setUserCache] = useState<Map<number, string>>(new Map());
  
  const [filters, setFilters] = useState<ReportFilters>({
    startDate: '',
    endDate: '',
    branch: '',
    destination: '',
    clerk: ''
  });

  const [parcelFilters, setParcelFilters] = useState({
    dateFrom: '',
    dateTo: '',
    destination: '',
    status: 'all'
  });

  const { user } = useAuth();

  // Chart configurations
  const salesPerClerkChartOptions = {
    chart: {
      type: 'bar' as const,
      height: 350,
      toolbar: {
        show: true,
        tools: {
          download: true,
          selection: true,
          zoom: true,
          zoomin: true,
          zoomout: true,
          pan: true,
          reset: true
        }
      }
    },
    plotOptions: {
      bar: {
        horizontal: false,
        columnWidth: '55%',
        endingShape: 'rounded'
      }
    },
    dataLabels: {
      enabled: false
    },
    stroke: {
      show: true,
      width: 2,
      colors: ['transparent']
    },
    xaxis: {
      categories: [] as string[],
      title: {
        text: 'Clerks'
      }
    },
    yaxis: {
      title: {
        text: 'Sales Amount (KSh)'
      }
    },
    fill: {
      opacity: 1
    },
    tooltip: {
      y: {
        formatter: function (val: number) {
          return "KSh " + val.toLocaleString()
        }
      }
    },
    colors: ['#10B981', '#3B82F6', '#8B5CF6', '#F59E0B', '#EF4444']
  };

  const deliveryRateChartOptions = {
    chart: {
      type: 'donut' as const,
      height: 350
    },
    labels: [] as string[],
    colors: ['#10B981', '#F59E0B', '#EF4444', '#6B7280'],
    plotOptions: {
      pie: {
        donut: {
          size: '70%',
          labels: {
            show: true,
            name: {
              show: true,
              fontSize: '16px',
              fontWeight: 600,
              color: '#374151'
            },
            value: {
              show: true,
              fontSize: '14px',
              fontWeight: 400,
              color: '#6B7280',
              formatter: function (val: string) {
                return val + '%'
              }
            },
            total: {
              show: true,
              showAlways: false,
              label: 'Total',
              fontSize: '16px',
              fontWeight: 600,
              color: '#374151',
              formatter: function (w: any) {
                return w.globals.seriesTotals.reduce((a: number, b: number) => a + b, 0)
              }
            }
          }
        }
      }
    },
    legend: {
      position: 'bottom' as const,
      horizontalAlign: 'center' as const
    },
    responsive: [{
      breakpoint: 480,
      options: {
        chart: {
          width: 200
        },
        legend: {
          position: 'bottom'
        }
      }
    }]
  };

  const monthlyTrendsChartOptions = {
    chart: {
      type: 'line' as const,
      height: 350,
      toolbar: {
        show: true
      }
    },
    stroke: {
      curve: 'smooth' as const,
      width: 3
    },
    xaxis: {
      categories: [] as string[],
      title: {
        text: 'Month'
      }
    },
    yaxis: {
      title: {
        text: 'Number of Parcels'
      }
    },
    colors: ['#10B981', '#3B82F6', '#8B5CF6'],
    markers: {
      size: 6,
      hover: {
        size: 8
      }
    },
    tooltip: {
      shared: true,
      intersect: false
    }
  };

  // Sample report data generators
  const generateSalesPerClerkData = useCallback((parcels: Parcel[]): SalesPerClerkData[] => {
    const clerkData: Record<string, { parcels: number; sales: number; name: string }> = {};
    
    parcels.forEach(parcel => {
      const clerk = parcel.createdBy || 'Unknown';
      if (!clerkData[clerk]) {
        clerkData[clerk] = { parcels: 0, sales: 0, name: clerk };
      }
      clerkData[clerk].parcels++;
      clerkData[clerk].sales += parcel.totalAmount || 0;
    });

    return Object.entries(clerkData).map(([username, data]) => ({
      clerkName: data.name,
      clerkUsername: username,
      totalParcels: data.parcels,
      totalSales: data.sales,
      averagePerParcel: data.parcels > 0 ? data.sales / data.parcels : 0,
      performance: data.sales >= 50000 ? 'excellent' : 
                   data.sales >= 25000 ? 'good' : 
                   data.sales >= 10000 ? 'average' : 'below-average'
    }));
  }, []);

  const generateDeliveryRateData = useCallback((parcels: Parcel[]): DeliveryRateData[] => {
    const destinationData: Record<string, { total: number; delivered: number; pending: number; inTransit: number }> = {};
    
    parcels.forEach(parcel => {
      const dest = parcel.destination || 'Unknown';
      if (!destinationData[dest]) {
        destinationData[dest] = { total: 0, delivered: 0, pending: 0, inTransit: 0 };
      }
      destinationData[dest].total++;
      
      if (parcel.status === 3) destinationData[dest].delivered++;
      else if (parcel.status === 0) destinationData[dest].pending++;
      else if (parcel.status === 2) destinationData[dest].inTransit++;
    });

    return Object.entries(destinationData).map(([destination, data]) => ({
      destination,
      totalParcels: data.total,
      deliveredParcels: data.delivered,
      pendingParcels: data.pending,
      inTransitParcels: data.inTransit,
      deliveryRate: data.total > 0 ? (data.delivered / data.total) * 100 : 0
    }));
  }, []);

  // Helper function to normalize parcelIds
  const normalizeParcelIds = useCallback((parcelIds: string[] | { $values: string[] } | undefined): string[] => {
    if (!parcelIds) return [];
    if (Array.isArray(parcelIds)) return parcelIds;
    if (typeof parcelIds === 'object' && parcelIds.$values && Array.isArray(parcelIds.$values)) {
      return parcelIds.$values;
    }
    return [];
  }, []);

  const generateUndeliveredParcelData = useCallback((dispatches: Dispatch[], parcels: Parcel[]): UndeliveredParcelData[] => {
    return dispatches.map(dispatch => {
      const normalizedParcelIds = normalizeParcelIds(dispatch.parcelIds);
      const dispatchParcels = parcels.filter(p => 
        normalizedParcelIds.includes(p.id) && p.status !== 3
      );
      
      return {
        dispatchCode: dispatch.dispatchCode,
        destination: dispatch.destination,
        driver: dispatch.driver,
        vehicleNumber: dispatch.vehicleNumber,
        totalParcels: dispatch.totalParcels || 0,
        undeliveredParcels: dispatchParcels.length,
        totalAmount: dispatchParcels.reduce((sum, p) => sum + (p.totalAmount || 0), 0),
        dispatchDate: dispatch.dispatchTime
      };
    }).filter(d => d.undeliveredParcels > 0);
  }, [normalizeParcelIds]);

  const generateMonthlyTrendsData = useCallback((parcels: Parcel[]) => {
    const monthlyData: Record<string, { total: number; delivered: number; pending: number }> = {};
    
    parcels.forEach(parcel => {
      const date = new Date(parcel.createdAt);
      const monthKey = `${date.getFullYear()}-${String(date.getMonth() + 1).padStart(2, '0')}`;
      
      if (!monthlyData[monthKey]) {
        monthlyData[monthKey] = { total: 0, delivered: 0, pending: 0 };
      }
      
      monthlyData[monthKey].total++;
      if (parcel.status === 3) monthlyData[monthKey].delivered++;
      else if (parcel.status === 0) monthlyData[monthKey].pending++;
    });

    const sortedMonths = Object.keys(monthlyData).sort();
    
    return {
      categories: sortedMonths.map(month => {
        const [year, monthNum] = month.split('-');
        const date = new Date(parseInt(year), parseInt(monthNum) - 1);
        return date.toLocaleDateString('en-US', { month: 'short', year: 'numeric' });
      }),
      series: [
        {
          name: 'Total Parcels',
          data: sortedMonths.map(month => monthlyData[month].total)
        },
        {
          name: 'Delivered',
          data: sortedMonths.map(month => monthlyData[month].delivered)
        },
        {
          name: 'Pending',
          data: sortedMonths.map(month => monthlyData[month].pending)
        }
      ]
    };
  }, []);

  const fetchReportData = useCallback(async () => {
    try {
      setLoading(true);
      setError('');
      
      // Fetch base data
      const [parcelsData, dispatchesData] = await Promise.all([
        wmsApi.getParcels(user?.isBranchManager ? user.branch : undefined),
        wmsApi.getDispatches(user?.isBranchManager ? user.branch : undefined)
      ]);
      
      setParcels(parcelsData);
      setDispatches(dispatchesData);
      
      // Filter data based on filters
      let filteredParcels = parcelsData;
      
      if (filters.startDate) {
        filteredParcels = filteredParcels.filter(p => 
          p.createdAt && new Date(p.createdAt) >= new Date(filters.startDate)
        );
      }
      
      if (filters.endDate) {
        filteredParcels = filteredParcels.filter(p => 
          p.createdAt && new Date(p.createdAt) <= new Date(filters.endDate)
        );
      }
      
      if (filters.destination) {
        filteredParcels = filteredParcels.filter(p => p.destination === filters.destination);
      }
      
      if (filters.clerk) {
        filteredParcels = filteredParcels.filter(p => 
          p.createdBy?.toLowerCase().includes(filters.clerk.toLowerCase())
        );
      }
      
      // Generate report data based on current report type
      let data: any = {};
      
      switch (currentReport) {
        case 'sales-per-clerk':
          data.salesPerClerk = generateSalesPerClerkData(filteredParcels);
          break;
        case 'delivery-rate':
          data.deliveryRate = generateDeliveryRateData(filteredParcels);
          break;
        case 'undelivered-parcels':
          data.undeliveredParcels = generateUndeliveredParcelData(dispatchesData, filteredParcels);
          break;
        case 'dashboard':
          data.salesPerClerk = generateSalesPerClerkData(filteredParcels);
          data.deliveryRate = generateDeliveryRateData(filteredParcels);
          data.monthlyTrends = generateMonthlyTrendsData(filteredParcels);
          break;
        default:
          data.parcels = filteredParcels;
      }
      
      setReportData(data);
      
    } catch (err) {
      setError('Failed to fetch report data');
      console.error('Error fetching report data:', err);
    } finally {
      setLoading(false);
    }
  }, [currentReport, filters, user, generateSalesPerClerkData, generateDeliveryRateData, generateUndeliveredParcelData, generateMonthlyTrendsData]);

  const fetchFilteredParcels = useCallback(async () => {
    if (!parcelFilters.dateFrom && !parcelFilters.dateTo && !parcelFilters.destination) {
      // Don't fetch if no filters are applied to avoid loading all parcels
      setFilteredParcels([]);
      return;
    }

    try {
      setParcelListLoading(true);
      setError('');
      
      // Build filters for API call
      const apiFilters: any = {};
      
      if (parcelFilters.dateFrom) {
        apiFilters.dateFrom = parcelFilters.dateFrom;
      }
      
      if (parcelFilters.dateTo) {
        apiFilters.dateTo = parcelFilters.dateTo;
      }
      
      if (parcelFilters.destination) {
        apiFilters.destination = parcelFilters.destination;
      }
      
      if (parcelFilters.status !== 'all') {
        apiFilters.status = parcelFilters.status;
      }
      
      const branch = user?.isBranchManager ? user.branch : undefined;
      const parcelsData = await wmsApi.getParcels(branch, apiFilters);
      
      setFilteredParcels(parcelsData);
    } catch (err) {
      setError('Failed to fetch parcels. Please try again.');
      console.error('Error fetching filtered parcels:', err);
    } finally {
      setParcelListLoading(false);
    }
  }, [parcelFilters, user]);

  const fetchDestinations = useCallback(async () => {
    try {
      const branch = user?.isBranchManager ? user.branch : undefined;
      const parcelsData = await wmsApi.getParcels(branch);
      
      // Extract unique destinations
      const destinationSet = new Set(parcelsData.map(p => p.destination).filter(Boolean));
      const uniqueDestinations = Array.from(destinationSet);
      setDestinations(uniqueDestinations.sort());
    } catch (err) {
      console.error('Error fetching destinations:', err);
    }
  }, [user]);

  const getUserDisplayName = useCallback(async (userId: number): Promise<string> => {
    // Check cache first
    if (userCache.has(userId)) {
      return userCache.get(userId)!;
    }

    try {
      const user = await wmsApi.getUserById(userId);
      const displayName = user ? 
        (user.username || user.firstName || `User ${userId}`) : 
        `User ${userId}`;
      
      // Cache the result
      setUserCache(prev => new Map(prev.set(userId, displayName)));
      return displayName;
    } catch (error) {
      console.error(`Error fetching user ${userId}:`, error);
      const fallbackName = `User ${userId}`;
      setUserCache(prev => new Map(prev.set(userId, fallbackName)));
      return fallbackName;
    }
  }, [userCache]);

  useEffect(() => {
    fetchReportData();
    fetchDestinations();
  }, [fetchReportData, fetchDestinations]);

  useEffect(() => {
    if (currentReport === 'parcel-list') {
      fetchFilteredParcels();
    }
  }, [parcelFilters, currentReport, fetchFilteredParcels]);

  // Prefetch user data when parcels are loaded
  useEffect(() => {
    if (filteredParcels.length > 0) {
      const userIdSet = new Set(filteredParcels.map(p => p.createdById).filter(Boolean));
      const uniqueUserIds = Array.from(userIdSet);
      uniqueUserIds.forEach(userId => {
        if (!userCache.has(userId)) {
          getUserDisplayName(userId);
        }
      });
    }
  }, [filteredParcels, userCache, getUserDisplayName]);

  const handleParcelFilterChange = (key: string, value: string | { from: string; to: string }) => {
    if (typeof value === 'string') {
      setParcelFilters(prev => ({ ...prev, [key]: value }));
    }
  };

  const clearParcelFilters = () => {
    setParcelFilters({
      dateFrom: '',
      dateTo: '',
      destination: '',
      status: 'all'
    });
    setFilteredParcels([]);
  };

  const handleFilterChange = (key: string, value: string | { from: string; to: string }) => {
    setFilters(prev => ({ ...prev, [key]: value }));
  };

  const clearFilters = () => {
    setFilters({
      startDate: '',
      endDate: '',
      branch: '',
      destination: '',
      clerk: ''
    });
  };

  const getActiveFilterChips = () => {
    const chips: any[] = [];

    if (filters.startDate) {
      chips.push({
        key: 'startDate',
        label: 'Start Date',
        value: filters.startDate,
        onRemove: () => handleFilterChange('startDate', '')
      });
    }

    if (filters.endDate) {
      chips.push({
        key: 'endDate',
        label: 'End Date',
        value: filters.endDate,
        onRemove: () => handleFilterChange('endDate', '')
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

    if (filters.clerk) {
      chips.push({
        key: 'clerk',
        label: 'Clerk',
        value: filters.clerk,
        onRemove: () => handleFilterChange('clerk', '')
      });
    }

    return chips;
  };

  const filterFields: FilterField[] = [
    {
      key: 'startDate',
      label: 'Start Date',
      type: 'date',
      placeholder: 'Select start date',
      icon: <Calendar className="w-4 h-4" />
    },
    {
      key: 'endDate',
      label: 'End Date',
      type: 'date',
      placeholder: 'Select end date',
      icon: <Calendar className="w-4 h-4" />
    },
    {
      key: 'destination',
      label: 'Destination',
      type: 'text',
      placeholder: 'Filter by destination',
      icon: <MapPin className="w-4 h-4" />
    },
    {
      key: 'clerk',
      label: 'Clerk',
      type: 'text',
      placeholder: 'Filter by clerk',
      icon: <Users className="w-4 h-4" />
    }
  ];

  const formatCurrency = (amount: number) => {
    return new Intl.NumberFormat('en-KE', {
      style: 'currency',
      currency: 'KES',
      minimumFractionDigits: 0
    }).format(amount).replace('KES', 'KSh');
  };

  const formatDate = (dateString: string) => {
    return new Date(dateString).toLocaleDateString('en-US', {
      year: 'numeric',
      month: 'short',
      day: 'numeric'
    });
  };

  const getPerformanceBadge = (performance: string) => {
    const variants = {
      'excellent': 'success',
      'good': 'primary',
      'average': 'warning',
      'below-average': 'error'
    } as const;
    
    return (
      <Badge variant={variants[performance as keyof typeof variants] || 'gray'}>
        {performance.replace('-', ' ').toUpperCase()}
      </Badge>
    );
  };

  const renderDashboard = () => {
    if (!reportData) return null;

    const { salesPerClerk, deliveryRate, monthlyTrends } = reportData;

    // Prepare chart data
    const salesChartData = {
      series: [{
        name: 'Sales Amount',
        data: salesPerClerk?.map((clerk: SalesPerClerkData) => clerk.totalSales) || []
      }],
      options: {
        ...salesPerClerkChartOptions,
        xaxis: {
          ...salesPerClerkChartOptions.xaxis,
          categories: salesPerClerk?.map((clerk: SalesPerClerkData) => clerk.clerkName) || []
        }
      }
    };

    const deliveryChartData = {
      series: deliveryRate?.map((dest: DeliveryRateData) => dest.deliveryRate) || [],
      options: {
        ...deliveryRateChartOptions,
        labels: deliveryRate?.map((dest: DeliveryRateData) => dest.destination) || []
      }
    };

    const trendsChartData = {
      series: monthlyTrends?.series || [],
      options: {
        ...monthlyTrendsChartOptions,
        xaxis: {
          ...monthlyTrendsChartOptions.xaxis,
          categories: monthlyTrends?.categories || []
        }
      }
    };

    return (
      <div className="space-y-6">
        {/* Key Metrics */}
        <div className="grid grid-cols-1 md:grid-cols-4 gap-6">
          <Card>
            <div className="flex items-center">
              <div className="p-3 rounded-lg bg-brand-100 dark:bg-brand-500/20">
                <Package className="w-6 h-6 text-brand-600 dark:text-brand-400" />
              </div>
              <div className="ml-4">
                <p className="text-sm font-medium text-gray-600 dark:text-gray-400">
                  Total Parcels
                </p>
                <p className="text-2xl font-bold text-gray-900 dark:text-white">
                  {parcels.length}
                </p>
              </div>
            </div>
          </Card>

          <Card>
            <div className="flex items-center">
              <div className="p-3 rounded-lg bg-success-100 dark:bg-success-500/20">
                <DollarSign className="w-6 h-6 text-success-600 dark:text-success-400" />
              </div>
              <div className="ml-4">
                <p className="text-sm font-medium text-gray-600 dark:text-gray-400">
                  Total Sales
                </p>
                <p className="text-2xl font-bold text-gray-900 dark:text-white">
                  {formatCurrency(parcels.reduce((sum, p) => sum + (p.totalAmount || 0), 0))}
                </p>
              </div>
            </div>
          </Card>

          <Card>
            <div className="flex items-center">
              <div className="p-3 rounded-lg bg-warning-100 dark:bg-warning-500/20">
                <Truck className="w-6 h-6 text-warning-600 dark:text-warning-400" />
              </div>
              <div className="ml-4">
                <p className="text-sm font-medium text-gray-600 dark:text-gray-400">
                  Dispatches
                </p>
                <p className="text-2xl font-bold text-gray-900 dark:text-white">
                  {dispatches.length}
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
                <p className="text-sm font-medium text-gray-600 dark:text-gray-400">
                  Pending Delivery
                </p>
                <p className="text-2xl font-bold text-gray-900 dark:text-white">
                  {parcels.filter(p => p.status === 0).length}
                </p>
              </div>
            </div>
          </Card>
        </div>

        {/* Charts */}
        <div className="grid grid-cols-1 lg:grid-cols-2 gap-6">
          {/* Sales Per Clerk Chart */}
          <Card>
            <div className="p-6">
              <h3 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
                Sales Performance by Clerk
              </h3>
              <Chart
                options={salesChartData.options}
                series={salesChartData.series}
                type="bar"
                height={350}
              />
            </div>
          </Card>

          {/* Delivery Rate Chart */}
          <Card>
            <div className="p-6">
              <h3 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
                Delivery Rate by Destination
              </h3>
              <Chart
                options={deliveryChartData.options}
                series={deliveryChartData.series}
                type="donut"
                height={350}
              />
            </div>
          </Card>
        </div>

        {/* Monthly Trends Chart */}
        <Card>
          <div className="p-6">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
              Monthly Parcel Trends
            </h3>
            <Chart
              options={trendsChartData.options}
              series={trendsChartData.series}
              type="line"
              height={350}
            />
          </div>
        </Card>
      </div>
    );
  };

  const renderSalesPerClerk = () => {
    if (!reportData?.salesPerClerk) return null;

    return (
      <div className="space-y-6">
        <Card>
          <div className="p-6">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
              Sales Performance by Clerk
            </h3>
            <Chart
              options={{
                ...salesPerClerkChartOptions,
                xaxis: {
                  ...salesPerClerkChartOptions.xaxis,
                  categories: reportData.salesPerClerk.map((clerk: SalesPerClerkData) => clerk.clerkName)
                }
              }}
              series={[{
                name: 'Sales Amount',
                data: reportData.salesPerClerk.map((clerk: SalesPerClerkData) => clerk.totalSales)
              }]}
              type="bar"
              height={350}
            />
          </div>
        </Card>

        <Card padding={false}>
          <div className="p-6 border-b border-gray-200">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
              Detailed Clerk Performance
            </h3>
          </div>
          <Table>
            <Table.Header>
              <Table.Row>
                <Table.Head>Clerk Name</Table.Head>
                <Table.Head>Total Parcels</Table.Head>
                <Table.Head>Total Sales</Table.Head>
                <Table.Head>Average per Parcel</Table.Head>
                <Table.Head>Performance</Table.Head>
              </Table.Row>
            </Table.Header>
            <Table.Body>
              {reportData.salesPerClerk.map((clerk: SalesPerClerkData, index: number) => (
                <Table.Row key={index}>
                  <Table.Cell>
                    <div className="font-medium text-gray-900 dark:text-white">
                      {clerk.clerkName}
                    </div>
                    <div className="text-sm text-gray-500 dark:text-gray-400">
                      @{clerk.clerkUsername}
                    </div>
                  </Table.Cell>
                  <Table.Cell>{clerk.totalParcels}</Table.Cell>
                  <Table.Cell>{formatCurrency(clerk.totalSales)}</Table.Cell>
                  <Table.Cell>{formatCurrency(clerk.averagePerParcel)}</Table.Cell>
                  <Table.Cell>{getPerformanceBadge(clerk.performance)}</Table.Cell>
                </Table.Row>
              ))}
            </Table.Body>
          </Table>
        </Card>
      </div>
    );
  };

  const renderDeliveryRate = () => {
    if (!reportData?.deliveryRate) return null;

    return (
      <div className="space-y-6">
        <Card>
          <div className="p-6">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
              Delivery Rate by Destination
            </h3>
            <Chart
              options={{
                ...deliveryRateChartOptions,
                labels: reportData.deliveryRate.map((dest: DeliveryRateData) => dest.destination)
              }}
              series={reportData.deliveryRate.map((dest: DeliveryRateData) => dest.deliveryRate)}
              type="donut"
              height={350}
            />
          </div>
        </Card>

        <Card padding={false}>
          <div className="p-6 border-b border-gray-200">
            <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
              Delivery Rate Details
            </h3>
          </div>
          <Table>
            <Table.Header>
              <Table.Row>
                <Table.Head>Destination</Table.Head>
                <Table.Head>Total Parcels</Table.Head>
                <Table.Head>Delivered</Table.Head>
                <Table.Head>Pending</Table.Head>
                <Table.Head>In Transit</Table.Head>
                <Table.Head>Delivery Rate</Table.Head>
              </Table.Row>
            </Table.Header>
            <Table.Body>
              {reportData.deliveryRate.map((dest: DeliveryRateData, index: number) => (
                <Table.Row key={index}>
                  <Table.Cell>
                    <div className="flex items-center text-gray-900 dark:text-white">
                      <MapPin className="w-4 h-4 mr-2 text-gray-400" />
                      {dest.destination}
                    </div>
                  </Table.Cell>
                  <Table.Cell>{dest.totalParcels}</Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center text-success-600">
                      <CheckCircle className="w-4 h-4 mr-1" />
                      {dest.deliveredParcels}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center text-warning-600">
                      <Clock className="w-4 h-4 mr-1" />
                      {dest.pendingParcels}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <div className="flex items-center text-primary-600">
                      <Truck className="w-4 h-4 mr-1" />
                      {dest.inTransitParcels}
                    </div>
                  </Table.Cell>
                  <Table.Cell>
                    <Badge variant={dest.deliveryRate >= 80 ? 'success' : dest.deliveryRate >= 60 ? 'warning' : 'error'}>
                      {dest.deliveryRate.toFixed(1)}%
                    </Badge>
                  </Table.Cell>
                </Table.Row>
              ))}
            </Table.Body>
          </Table>
        </Card>
      </div>
    );
  };

  const renderUndeliveredParcels = () => {
    if (!reportData?.undeliveredParcels) return null;

    return (
      <Card padding={false}>
        <div className="p-6 border-b border-gray-200">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
            Undelivered Parcels by Dispatch
          </h3>
        </div>
        <Table>
          <Table.Header>
            <Table.Row>
              <Table.Head>Dispatch Code</Table.Head>
              <Table.Head>Destination</Table.Head>
              <Table.Head>Driver</Table.Head>
              <Table.Head>Vehicle</Table.Head>
              <Table.Head>Total Parcels</Table.Head>
              <Table.Head>Undelivered</Table.Head>
              <Table.Head>Total Amount</Table.Head>
              <Table.Head>Dispatch Date</Table.Head>
            </Table.Row>
          </Table.Header>
          <Table.Body>
            {reportData.undeliveredParcels.map((dispatch: UndeliveredParcelData, index: number) => (
              <Table.Row key={index}>
                <Table.Cell>
                  <div className="font-medium text-gray-900 dark:text-white">
                    {dispatch.dispatchCode}
                  </div>
                </Table.Cell>
                <Table.Cell>
                  <div className="flex items-center text-gray-900 dark:text-white">
                    <MapPin className="w-4 h-4 mr-2 text-gray-400" />
                    {dispatch.destination}
                  </div>
                </Table.Cell>
                <Table.Cell>{dispatch.driver}</Table.Cell>
                <Table.Cell>{dispatch.vehicleNumber}</Table.Cell>
                <Table.Cell>{dispatch.totalParcels}</Table.Cell>
                <Table.Cell>
                  <Badge variant="error">
                    {dispatch.undeliveredParcels}
                  </Badge>
                </Table.Cell>
                <Table.Cell>{formatCurrency(dispatch.totalAmount)}</Table.Cell>
                <Table.Cell>{formatDate(dispatch.dispatchDate)}</Table.Cell>
              </Table.Row>
            ))}
          </Table.Body>
        </Table>
      </Card>
    );
  };

  const getClerkName = (parcel: Parcel): string => {
    if (parcel.createdBy) {
      if (typeof parcel.createdBy === 'object') {
        return parcel.createdBy.username || parcel.createdBy.firstName || `User ${parcel.createdById}`;
      }
      return parcel.createdBy;
    }
    
    // Try to get from cache
    if (userCache.has(parcel.createdById)) {
      return userCache.get(parcel.createdById)!;
    }
    
    // Fetch user data in background and return fallback for now
    getUserDisplayName(parcel.createdById);
    return `User ${parcel.createdById}`;
  };

  const renderParcelList = () => {
    const getStatusText = (status: number) => {
      const statusMap = {
        0: 'Pending',
        1: 'Finalized',
        2: 'In Transit',
        3: 'Delivered',
        4: 'Cancelled'
      };
      return statusMap[status as keyof typeof statusMap] || 'Unknown';
    };

    const getStatusBadge = (status: number) => {
      const statusConfig = {
        0: { variant: 'warning', text: 'Pending' },
        1: { variant: 'info', text: 'Finalized' },
        2: { variant: 'primary', text: 'In Transit' },
        3: { variant: 'success', text: 'Delivered' },
        4: { variant: 'error', text: 'Cancelled' }
      };
      const config = statusConfig[status as keyof typeof statusConfig] || { variant: 'secondary', text: 'Unknown' };
      return <Badge variant={config.variant as any}>{config.text}</Badge>;
    };

    const printParcelList = () => {
      const printWindow = window.open('', '_blank');
      if (printWindow) {
        const filterInfo = [];
        if (parcelFilters.dateFrom) filterInfo.push(`From: ${parcelFilters.dateFrom}`);
        if (parcelFilters.dateTo) filterInfo.push(`To: ${parcelFilters.dateTo}`);
        if (parcelFilters.destination) filterInfo.push(`Destination: ${parcelFilters.destination}`);
        if (parcelFilters.status !== 'all') filterInfo.push(`Status: ${getStatusText(parseInt(parcelFilters.status))}`);

        printWindow.document.write(`
          <html>
            <head>
              <title>Parcel List Report</title>
              <style>
                body { font-family: Arial, sans-serif; padding: 20px; margin: 0; font-size: 12px; }
                h1 { color: #333; margin-bottom: 10px; }
                .filters { margin-bottom: 20px; color: #666; }
                table { width: 100%; border-collapse: collapse; margin-top: 20px; }
                th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }
                th { background-color: #f5f5f5; font-weight: bold; }
                .status { padding: 2px 6px; border-radius: 3px; font-size: 10px; }
                .status-pending { background: #fef3c7; color: #92400e; }
                .status-finalized { background: #dbeafe; color: #1e40af; }
                .status-transit { background: #e0e7ff; color: #3730a3; }
                .status-delivered { background: #d1fae5; color: #065f46; }
                .status-cancelled { background: #fee2e2; color: #991b1b; }
                @media print { body { print-color-adjust: exact; } }
              </style>
            </head>
            <body>
              <h1>Parcel List Report</h1>
              <div class="filters">Filters Applied: ${filterInfo.length > 0 ? filterInfo.join(', ') : 'None'}</div>
              <div>Total Parcels: ${filteredParcels.length}</div>
              <table>
                <thead>
                  <tr>
                    <th>Waybill Number</th>
                    <th>Destination</th>
                    <th>Sender</th>
                    <th>Receiver</th>
                    <th>Quantity</th>
                    <th>Description</th>
                    <th>Amount</th>
                    <th>Status</th>
                    <th>Clerk</th>
                    <th>Created Date</th>
                  </tr>
                </thead>
                <tbody>
                  ${filteredParcels.map(parcel => `
                    <tr>
                      <td>${parcel.waybillNumber}</td>
                      <td>${parcel.destination}</td>
                      <td>${parcel.sender}</td>
                      <td>${parcel.receiver}</td>
                      <td>${parcel.quantity}</td>
                      <td>${parcel.description || 'No description'}</td>
                      <td>KSh ${parcel.totalAmount.toLocaleString()}</td>
                      <td><span class="status status-${getStatusText(parcel.status).toLowerCase()}">${getStatusText(parcel.status)}</span></td>
                      <td>${getClerkName(parcel)}</td>
                      <td>${new Date(parcel.createdAt).toLocaleDateString()}</td>
                    </tr>
                  `).join('')}
                </tbody>
              </table>
            </body>
          </html>
        `);
        printWindow.document.close();
        printWindow.print();
      }
    };

    const parcelFilterFields = [
      {
        key: 'dateFrom',
        label: 'Date From',
        type: 'date' as const,
        placeholder: 'Select start date'
      },
      {
        key: 'dateTo',
        label: 'Date To',
        type: 'date' as const,
        placeholder: 'Select end date'
      },
      {
        key: 'destination',
        label: 'Destination',
        type: 'select' as const,
        placeholder: 'Select destination',
        options: [
          { value: '', label: 'All Destinations' },
          ...destinations.map(dest => ({ value: dest, label: dest }))
        ]
      },
      {
        key: 'status',
        label: 'Status',
        type: 'select' as const,
        placeholder: 'Filter by status',
        options: [
          { value: 'all', label: 'All Status' },
          { value: '0', label: 'Pending' },
          { value: '1', label: 'Finalized' },
          { value: '2', label: 'In Transit' },
          { value: '3', label: 'Delivered' },
          { value: '4', label: 'Cancelled' }
        ]
      }
    ];

    const getActiveParcelFilterChips = () => {
      const chips: any[] = [];

      if (parcelFilters.dateFrom) {
        chips.push({
          key: 'dateFrom',
          label: 'Date From',
          value: parcelFilters.dateFrom,
          onRemove: () => handleParcelFilterChange('dateFrom', '')
        });
      }

      if (parcelFilters.dateTo) {
        chips.push({
          key: 'dateTo',
          label: 'Date To',
          value: parcelFilters.dateTo,
          onRemove: () => handleParcelFilterChange('dateTo', '')
        });
      }

      if (parcelFilters.destination) {
        chips.push({
          key: 'destination',
          label: 'Destination',
          value: parcelFilters.destination,
          onRemove: () => handleParcelFilterChange('destination', '')
        });
      }

      if (parcelFilters.status !== 'all') {
        chips.push({
          key: 'status',
          label: 'Status',
          value: getStatusText(parseInt(parcelFilters.status)),
          onRemove: () => handleParcelFilterChange('status', 'all')
        });
      }

      return chips;
    };

    return (
      <div className="space-y-6">
        {/* Filters */}
        <Card>
          <div className="p-6">
            <div className="flex items-center justify-between mb-4">
              <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
                Parcel List Filters
              </h3>
              <div className="flex items-center gap-2">
                <Button
                  variant="outline"
                  onClick={() => setShowParcelFilters(!showParcelFilters)}
                >
                  <Filter className="w-4 h-4 mr-2" />
                  {showParcelFilters ? 'Hide' : 'Show'} Filters
                </Button>
                {filteredParcels.length > 0 && (
                  <Button
                    variant="outline"
                    onClick={printParcelList}
                  >
                    <Printer className="w-4 h-4 mr-2" />
                    Print List
                  </Button>
                )}
              </div>
            </div>
            
            {showParcelFilters && (
              <FilterPanel
                fields={parcelFilterFields}
                filters={parcelFilters as any}
                onFilterChange={handleParcelFilterChange}
                onClearFilters={clearParcelFilters}
                activeFilters={getActiveParcelFilterChips()}
                collapsible={false}
                defaultExpanded={true}
              />
            )}

            {!parcelFilters.dateFrom && !parcelFilters.dateTo && !parcelFilters.destination && (
              <div className="mt-4 p-4 bg-blue-50 border border-blue-200 rounded-lg">
                <div className="flex items-center gap-2 text-blue-800">
                  <AlertCircle className="w-5 h-5" />
                  <span className="font-medium">Apply filters to load parcels</span>
                </div>
                <p className="text-blue-600 mt-1 text-sm">
                  Please select a date range or destination to fetch and display parcels. This helps avoid loading too much data at once.
                </p>
              </div>
            )}
          </div>
        </Card>

        {/* Parcel List */}
        {(parcelFilters.dateFrom || parcelFilters.dateTo || parcelFilters.destination) && (
          <Card padding={false}>
            <div className="p-6 border-b border-gray-200">
              <div className="flex items-center justify-between">
                <h3 className="text-lg font-semibold text-gray-900 dark:text-white">
                  Parcel List ({filteredParcels.length} parcels)
                </h3>
                {parcelListLoading && (
                  <div className="flex items-center gap-2 text-gray-500">
                    <RefreshCw className="w-4 h-4 animate-spin" />
                    Loading...
                  </div>
                )}
              </div>
            </div>

            {filteredParcels.length === 0 && !parcelListLoading ? (
              <div className="p-6 text-center">
                <Package className="w-12 h-12 text-gray-400 mx-auto mb-4" />
                <h3 className="text-lg font-medium text-gray-900 dark:text-white mb-2">
                  No parcels found
                </h3>
                <p className="text-gray-500 dark:text-gray-400">
                  No parcels match your current filter criteria.
                </p>
              </div>
            ) : (
              <Table>
                <Table.Header>
                  <Table.Row>
                    <Table.Head>Waybill Number</Table.Head>
                    <Table.Head>Destination</Table.Head>
                    <Table.Head>Sender</Table.Head>
                    <Table.Head>Receiver</Table.Head>
                    <Table.Head>Qty</Table.Head>
                    <Table.Head>Description</Table.Head>
                    <Table.Head>Amount</Table.Head>
                    <Table.Head>Status</Table.Head>
                    <Table.Head>Clerk</Table.Head>
                    <Table.Head>Created</Table.Head>
                  </Table.Row>
                </Table.Header>
                <Table.Body>
                  {filteredParcels.map((parcel) => (
                    <Table.Row key={parcel.id}>
                      <Table.Cell>
                        <div className="font-medium text-gray-900 dark:text-white">
                          {parcel.waybillNumber}
                        </div>
                      </Table.Cell>
                      <Table.Cell>
                        <div className="flex items-center text-gray-900 dark:text-white">
                          <MapPin className="w-4 h-4 mr-1 text-gray-400" />
                          {parcel.destination}
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
                      <Table.Cell>{parcel.quantity}</Table.Cell>
                      <Table.Cell>
                        <div className="text-gray-900 dark:text-white max-w-xs truncate" title={parcel.description}>
                          {parcel.description || 'No description'}
                        </div>
                      </Table.Cell>
                      <Table.Cell>KSh {parcel.totalAmount.toLocaleString()}</Table.Cell>
                      <Table.Cell>{getStatusBadge(parcel.status)}</Table.Cell>
                      <Table.Cell>
                        <div className="text-gray-900 dark:text-white">
                          {getClerkName(parcel)}
                        </div>
                      </Table.Cell>
                      <Table.Cell>
                        <div className="text-sm text-gray-500">
                          {new Date(parcel.createdAt).toLocaleDateString()}
                        </div>
                        <div className="text-sm text-gray-400">
                          {new Date(parcel.createdAt).toLocaleTimeString()}
                        </div>
                      </Table.Cell>
                    </Table.Row>
                  ))}
                </Table.Body>
              </Table>
            )}
          </Card>
        )}
      </div>
    );
  };

  const renderReportContent = () => {
    switch (currentReport) {
      case 'dashboard':
        return renderDashboard();
      case 'sales-per-clerk':
        return renderSalesPerClerk();
      case 'delivery-rate':
        return renderDeliveryRate();
      case 'undelivered-parcels':
        return renderUndeliveredParcels();
      case 'parcel-list':
        return renderParcelList();
      default:
        return (
          <Card>
            <div className="p-6 text-center">
              <FileText className="w-12 h-12 text-gray-400 mx-auto mb-4" />
              <h3 className="text-lg font-medium text-gray-900 dark:text-white mb-2">
                Report Not Available
              </h3>
              <p className="text-gray-500 dark:text-gray-400">
                This report type is not yet implemented.
              </p>
            </div>
          </Card>
        );
    }
  };

  const reportTypes = [
    { key: 'dashboard', label: 'Dashboard', icon: BarChart },
    { key: 'sales-per-clerk', label: 'Sales per Clerk', icon: Users },
    { key: 'delivery-rate', label: 'Delivery Rate', icon: CheckCircle },
    { key: 'undelivered-parcels', label: 'Undelivered Parcels', icon: AlertCircle },
    { key: 'contract-invoices', label: 'Contract Invoices', icon: FileText },
    { key: 'cod-delivered', label: 'COD Delivered', icon: DollarSign },
    { key: 'parcel-list', label: 'Parcel List', icon: Package }
  ];

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
          <h1 className="text-2xl font-bold text-gray-900 dark:text-white">
            Reports & Analytics
          </h1>
          <p className="text-gray-600 dark:text-gray-400 mt-1">
            Comprehensive business intelligence and reporting
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
            onClick={fetchReportData}
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

      {/* Report Type Selector */}
      <Card>
        <div className="p-6">
          <h3 className="text-lg font-semibold text-gray-900 dark:text-white mb-4">
            Select Report Type
          </h3>
          <div className="grid grid-cols-2 md:grid-cols-4 lg:grid-cols-7 gap-3">
            {reportTypes.map((report) => {
              const IconComponent = report.icon;
              return (
                <button
                  key={report.key}
                  onClick={() => setCurrentReport(report.key as ReportType)}
                  className={`p-4 rounded-lg border-2 transition-all duration-200 ${
                    currentReport === report.key
                      ? 'border-brand-500 bg-brand-50 text-brand-700 dark:bg-brand-500/20 dark:text-brand-400'
                      : 'border-gray-200 hover:border-gray-300 text-gray-700 hover:text-gray-900 dark:border-gray-700 dark:hover:border-gray-600 dark:text-gray-300 dark:hover:text-gray-100'
                  }`}
                >
                  <IconComponent className="w-6 h-6 mx-auto mb-2" />
                  <div className="text-sm font-medium text-center">
                    {report.label}
                  </div>
                </button>
              );
            })}
          </div>
        </div>
      </Card>

      {/* Report Content */}
      {renderReportContent()}
    </div>
  );
};

export default Reports;