import React from 'react';
import { useAuth } from '../context/AuthContext';

const Dashboard: React.FC = () => {
  const { user } = useAuth();

  return (
    <div className="space-y-6">
      <div className="bg-white shadow rounded-lg p-6">
        <h1 className="text-2xl font-bold text-gray-900">Welcome, {user?.username}!</h1>
        <p className="mt-2 text-gray-600">
          {user?.role === 'admin'
            ? 'You have access to all branches and can manage waybills across the system.'
            : `You are managing the ${user?.branch} branch.`}
        </p>
      </div>

      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
        <div className="bg-white shadow rounded-lg p-6">
          <h2 className="text-lg font-semibold text-gray-900">Quick Actions</h2>
          <ul className="mt-4 space-y-2">
            <li>
              <a
                href="/parcels"
                className="text-blue-600 hover:text-blue-800"
              >
                View Parcels
              </a>
            </li>
            {user?.role === 'branch_manager' && (
              <li>
                <a
                  href="/dispatch"
                  className="text-blue-600 hover:text-blue-800"
                >
                  Create Dispatch
                </a>
              </li>
            )}
          </ul>
        </div>

        <div className="bg-white shadow rounded-lg p-6">
          <h2 className="text-lg font-semibold text-gray-900">Role Information</h2>
          <p className="mt-2 text-gray-600">
            {user?.role === 'admin'
              ? 'As an admin, you can view and manage all waybills across all branches.'
              : 'As a branch manager, you can manage waybills for your branch and create dispatches.'}
          </p>
        </div>

        <div className="bg-white shadow rounded-lg p-6">
          <h2 className="text-lg font-semibold text-gray-900">System Status</h2>
          <p className="mt-2 text-gray-600">
            All systems are operational. You can proceed with your tasks.
          </p>
        </div>
      </div>
    </div>
  );
};

export default Dashboard; 