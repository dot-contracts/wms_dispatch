import React, { useState } from 'react';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import { AuthProvider } from './context/AuthContext';
import { SidebarProvider } from './context/SidebarContext';
import { useAuth } from './context/AuthContext';
import AppHeader from './layout/AppHeader';
import AppSidebar from './layout/AppSidebar';
import Login from './pages/Login';
import Dashboard from './pages/Dashboard';
import Parcels from './pages/Parcels';
import CreateDispatch from './pages/CreateDispatch';
import ViewDispatch from './pages/ViewDispatch';
import ContractCustomers from './pages/ContractCustomers';
import Invoices from './pages/Invoices';
import Reports from './pages/Reports';
import UserManagement from './pages/UserManagement';
import AdminParcelManagement from './pages/AdminParcelManagement';

// Protected Route component
const ProtectedRoute: React.FC<{ 
  children: React.ReactNode;
  allowedRoles?: string[];
}> = ({ children, allowedRoles }) => {
  const { isAuthenticated, user } = useAuth();

  if (!isAuthenticated) {
    return <Navigate to="/login" />;
  }

  if (allowedRoles && user && !allowedRoles.includes(user.role)) {
    return <Navigate to="/dashboard" />;
  }

  return <>{children}</>;
};

// Modern Layout with Green Theme - Like Django but better
const ModernLayout: React.FC<{ children: React.ReactNode }> = ({ children }) => {
  const [darkMode, setDarkMode] = useState(false);

  const toggleDarkMode = () => {
    setDarkMode(!darkMode);
    document.documentElement.classList.toggle('dark');
  };

  return (
    <SidebarProvider>
      <div className={`min-h-screen bg-gray-50 dark:bg-gray-900 ${darkMode ? 'dark' : ''}`}>
        {/* Green-themed Sidebar like Django */}
        <AppSidebar />
        
        {/* Main content area */}
        <div className="lg:ml-[290px] transition-all duration-300">
          {/* Header */}
          <AppHeader darkMode={darkMode} toggleDarkMode={toggleDarkMode} />
          
          {/* Page content */}
          <main className="p-6">
            {children}
          </main>
        </div>
      </div>
    </SidebarProvider>
  );
};

const App: React.FC = () => {
  return (
    <AuthProvider>
      <Router>
        <Routes>
          {/* Login page without layout */}
          <Route path="/login" element={<Login />} />
          
          {/* All authenticated pages with modern green layout */}
          <Route
            path="/dashboard"
            element={
              <ProtectedRoute>
                <ModernLayout>
                  <Dashboard />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route
            path="/parcels"
            element={
              <ProtectedRoute>
                <ModernLayout>
                  <Parcels />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route
            path="/dispatches/create"
            element={
              <ProtectedRoute allowedRoles={['admin', 'branch_manager']}>
                <ModernLayout>
                  <CreateDispatch />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route
            path="/dispatches/view"
            element={
              <ProtectedRoute allowedRoles={['admin', 'branch_manager']}>
                <ModernLayout>
                  <ViewDispatch />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route
            path="/contract-customers"
            element={
              <ProtectedRoute allowedRoles={['admin', 'branch_manager']}>
                <ModernLayout>
                  <ContractCustomers />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route
            path="/invoices"
            element={
              <ProtectedRoute allowedRoles={['admin', 'branch_manager']}>
                <ModernLayout>
                  <Invoices />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route
            path="/reports"
            element={
              <ProtectedRoute allowedRoles={['admin', 'branch_manager']}>
                <ModernLayout>
                  <Reports />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route
            path="/user-management"
            element={
              <ProtectedRoute allowedRoles={['admin']}>
                <ModernLayout>
                  <UserManagement />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route
            path="/admin/parcels"
            element={
              <ProtectedRoute allowedRoles={['admin']}>
                <ModernLayout>
                  <AdminParcelManagement />
                </ModernLayout>
              </ProtectedRoute>
            }
          />
          <Route path="/" element={<Navigate to="/dashboard" />} />
        </Routes>
      </Router>
    </AuthProvider>
  );
};

export default App;
