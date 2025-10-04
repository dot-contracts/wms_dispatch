import React from 'react';
import { Link } from 'react-router-dom';
import { Package, Truck, BarChart3, Users, Plus, TrendingUp, CheckCircle, Clock } from 'lucide-react';
import { useAuth } from '../context/AuthContext';
import { Card, Button, Badge } from '../components/ui';

const Dashboard: React.FC = () => {
  const { user } = useAuth();

  const stats = [
    {
      title: 'Total Parcels',
      value: '2,847',
      change: '+12.5%',
      changeType: 'increase' as const,
      icon: Package,
      color: 'text-brand-600'
    },
    {
      title: 'Active Dispatches',
      value: '24',
      change: '+3.2%',
      changeType: 'increase' as const,
      icon: Truck,
      color: 'text-blue-600'
    },
    {
      title: 'Delivered Today',
      value: '156',
      change: '+8.1%',
      changeType: 'increase' as const,
      icon: CheckCircle,
      color: 'text-success-600'
    },
    {
      title: 'Pending Delivery',
      value: '89',
      change: '-2.3%',
      changeType: 'decrease' as const,
      icon: Clock,
      color: 'text-warning-600'
    }
  ];

  const quickActions = [
    {
      title: 'View All Parcels',
      description: 'Manage and track parcels',
      href: '/parcels',
      icon: Package,
      roles: ['admin', 'branch_manager', 'clerk']
    },
    {
      title: 'Create Dispatch',
      description: 'Create new dispatch orders',
      href: '/dispatches/create',
      icon: Plus,
      roles: ['admin', 'branch_manager']
    },
    {
      title: 'View Reports',
      description: 'Analytics and insights',
      href: '/reports',
      icon: BarChart3,
      roles: ['admin', 'branch_manager']
    },
    {
      title: 'User Management',
      description: 'Manage system users',
      href: '/user-management',
      icon: Users,
      roles: ['admin']
    }
  ];

  const hasAccess = (actionRoles: string[]) => {
    return user && actionRoles.includes(user.role);
  };

  const recentActivity = [
    { id: 1, action: 'Parcel WBL-2024-001 delivered', time: '2 minutes ago', status: 'success' },
    { id: 2, action: 'New dispatch DS-2024-045 created', time: '15 minutes ago', status: 'info' },
    { id: 3, action: 'Parcel WBL-2024-002 picked up', time: '1 hour ago', status: 'warning' },
    { id: 4, action: 'User john.doe logged in', time: '2 hours ago', status: 'info' }
  ];

  return (
    <div className="space-y-8">
      {/* Welcome Header */}
      <Card>
        <div className="flex items-center justify-between">
          <div>
            <h1 className="text-title-md font-bold text-gray-900 dark:text-white">
              Welcome back, {user?.username}!
            </h1>
            <p className="mt-2 text-gray-600 dark:text-gray-400">
              {user?.role === 'admin'
                ? 'You have access to all branches and can manage the entire system.'
                : user?.role === 'branch_manager'
                ? `You are managing the ${user?.branch || 'your'} branch with full operational control.`
                : `You have access to parcel operations for the ${user?.branch || 'your'} branch.`}
            </p>
          </div>
          <div className="flex items-center space-x-2">
            <Badge variant="primary">{user?.role?.replace('_', ' ').toUpperCase()}</Badge>
            {user?.branch && (
              <Badge variant="gray">{user.branch}</Badge>
            )}
          </div>
        </div>
      </Card>

      {/* Statistics Grid */}
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6">
        {stats.map((stat) => {
          const IconComponent = stat.icon;
          return (
            <Card key={stat.title}>
              <div className="flex items-center justify-between">
                <div>
                  <p className="text-theme-sm font-medium text-gray-600 dark:text-gray-400">
                    {stat.title}
                  </p>
                  <p className="text-2xl font-bold text-gray-900 dark:text-white mt-1">
                    {stat.value}
                  </p>
                  <div className="flex items-center mt-2">
                    <TrendingUp className={`w-4 h-4 mr-1 ${
                      stat.changeType === 'increase' ? 'text-success-600' : 'text-error-600'
                    }`} />
                    <span className={`text-theme-xs font-medium ${
                      stat.changeType === 'increase' ? 'text-success-600' : 'text-error-600'
                    }`}>
                      {stat.change}
                    </span>
                    <span className="text-theme-xs text-gray-500 ml-1">vs last month</span>
                  </div>
                </div>
                <div className={`p-3 rounded-lg bg-gray-50 dark:bg-gray-800`}>
                  <IconComponent className={`w-6 h-6 ${stat.color}`} />
                </div>
              </div>
            </Card>
          );
        })}
      </div>

      {/* Quick Actions and Recent Activity */}
      <div className="grid grid-cols-1 lg:grid-cols-2 gap-8">
        {/* Quick Actions */}
        <Card padding={false}>
          <Card.Header>
            <h2 className="text-lg font-semibold text-gray-900 dark:text-white">Quick Actions</h2>
          </Card.Header>
          <Card.Content>
            <div className="grid grid-cols-1 sm:grid-cols-2 gap-4">
              {quickActions.map((action) => {
                if (!hasAccess(action.roles)) return null;
                
                const IconComponent = action.icon;
                return (
                  <Link
                    key={action.title}
                    to={action.href}
                    className="p-4 border border-gray-200 dark:border-gray-700 rounded-lg hover:border-brand-300 hover:bg-brand-50 dark:hover:bg-brand-500/5 transition-all duration-200 group"
                  >
                    <div className="flex items-start space-x-3">
                      <div className="p-2 rounded-md bg-brand-100 dark:bg-brand-500/20 group-hover:bg-brand-200 dark:group-hover:bg-brand-500/30 transition-colors">
                        <IconComponent className="w-5 h-5 text-brand-600 dark:text-brand-400" />
                      </div>
                      <div>
                        <h3 className="font-medium text-gray-900 dark:text-white group-hover:text-brand-700 dark:group-hover:text-brand-300">
                          {action.title}
                        </h3>
                        <p className="text-theme-sm text-gray-600 dark:text-gray-400">
                          {action.description}
                        </p>
                      </div>
                    </div>
                  </Link>
                );
              })}
            </div>
          </Card.Content>
        </Card>

        {/* Recent Activity */}
        <Card padding={false}>
          <Card.Header>
            <h2 className="text-lg font-semibold text-gray-900 dark:text-white">Recent Activity</h2>
          </Card.Header>
          <Card.Content>
            <div className="space-y-4">
              {recentActivity.map((activity) => (
                <div key={activity.id} className="flex items-start space-x-3">
                  <div className={`w-2 h-2 rounded-full mt-2 ${
                    activity.status === 'success' ? 'bg-success-500' :
                    activity.status === 'warning' ? 'bg-warning-500' :
                    'bg-blue-500'
                  }`} />
                  <div className="flex-1 min-w-0">
                    <p className="text-theme-sm text-gray-900 dark:text-white">
                      {activity.action}
                    </p>
                    <p className="text-theme-xs text-gray-500 dark:text-gray-400">
                      {activity.time}
                    </p>
                  </div>
                </div>
              ))}
            </div>
            <div className="mt-6">
              <Button variant="outline" size="sm" className="w-full">
                View All Activity
              </Button>
            </div>
          </Card.Content>
        </Card>
      </div>

      {/* System Status */}
      <Card>
        <div className="flex items-center justify-between">
          <div className="flex items-center space-x-3">
            <div className="w-3 h-3 bg-success-500 rounded-full"></div>
            <div>
              <h3 className="font-medium text-gray-900 dark:text-white">System Status</h3>
              <p className="text-theme-sm text-gray-600 dark:text-gray-400">
                All systems operational. Last updated: {new Date().toLocaleTimeString()}
              </p>
            </div>
          </div>
          <Button variant="outline" size="sm">
            View Details
          </Button>
        </div>
      </Card>
    </div>
  );
};

export default Dashboard; 