import React, { createContext, useContext, useState, useEffect } from 'react';
import { buildApiUrl } from '../config/api';

interface User {
  id: string;
  username: string;
  role: 'admin' | 'branch_manager';
  branch?: string;
  isBranchManager: boolean;
  isAdmin: boolean;
  isClerk: boolean;
}

interface AuthContextType {
  user: User | null;
  token: string | null;
  login: (username: string, password: string) => Promise<void>;
  logout: () => void;
  isAuthenticated: boolean;
}

const AuthContext = createContext<AuthContextType | undefined>(undefined);

export const AuthProvider: React.FC<{ children: React.ReactNode }> = ({ children }) => {
  const [user, setUser] = useState<User | null>(null);
  const [token, setToken] = useState<string | null>(localStorage.getItem('token'));

  useEffect(() => {
    if (token) {
      const userData = localStorage.getItem('user');
      if (userData) {
        const parsedUser = JSON.parse(userData);
        // Ensure backward compatibility by adding missing properties if needed
        const completeUser: User = {
          ...parsedUser,
          isBranchManager: parsedUser.isBranchManager ?? parsedUser.role === 'branch_manager',
          isAdmin: parsedUser.isAdmin ?? parsedUser.role === 'admin',
          isClerk: parsedUser.isClerk ?? parsedUser.role === 'clerk'
        };
        setUser(completeUser);
      }
    }
  }, [token]);

  const login = async (username: string, password: string) => {
    try {
      const response = await fetch(buildApiUrl('api/Auth/login'), {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({ Username: username, Password: password }),
      });

      if (!response.ok) {
        const errorText = await response.text();
        try {
          const errorData = JSON.parse(errorText);
          throw new Error(errorData.message || `Login failed: ${response.status}`);
        } catch {
          throw new Error(`Login failed: ${response.status} - ${errorText}`);
        }
      }

      const data = await response.json();
      
      // The .NET API returns { Token, Username, Role, UserId }
      // Block clerk users from accessing this dispatch system
      const userRole = (data.Role || data.role || '').toLowerCase();
      if (userRole === 'clerk') {
        throw new Error('Access denied: Clerks are not allowed to access the dispatch system');
      }
      
      // Map the response to our User interface
      const userData: User = {
        id: (data.UserId || data.userId || data.id || '').toString(),
        username: data.Username || data.username || '',
        role: userRole === 'manager' ? 'branch_manager' : userRole as 'admin' | 'branch_manager',
        branch: undefined, // Will be populated if needed
        isBranchManager: userRole === 'manager',
        isAdmin: userRole === 'admin',
        isClerk: false // Always false since clerks are blocked
      };

      const token = data.Token || data.token;
      setToken(token);
      setUser(userData);
      localStorage.setItem('token', token);
      localStorage.setItem('user', JSON.stringify(userData));
    } catch (error) {
      console.error('Login error:', error);
      throw error;
    }
  };

  const logout = () => {
    setToken(null);
    setUser(null);
    localStorage.removeItem('token');
    localStorage.removeItem('user');
  };

  return (
    <AuthContext.Provider
      value={{
        user,
        token,
        login,
        logout,
        isAuthenticated: !!token,
      }}
    >
      {children}
    </AuthContext.Provider>
  );
};

export const useAuth = () => {
  const context = useContext(AuthContext);
  if (context === undefined) {
    throw new Error('useAuth must be used within an AuthProvider');
  }
  return context;
}; 