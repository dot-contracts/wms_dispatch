// API Configuration for WMS React App

export const API_CONFIG = {
  BASE_URL: process.env.REACT_APP_API_BASE_URL || 'https://wmsandroidapi-w74du.ondigitalocean.app',
  TIMEOUT: 15000,
  HEADERS: {
    'Content-Type': 'application/json',
    'Accept': 'application/json'
  }
};

export const buildApiUrl = (endpoint: string): string => {
  const baseUrl = API_CONFIG.BASE_URL.endsWith('/') 
    ? API_CONFIG.BASE_URL.slice(0, -1) 
    : API_CONFIG.BASE_URL;
  
  const cleanEndpoint = endpoint.startsWith('/') 
    ? endpoint.slice(1) 
    : endpoint;
  
  return `${baseUrl}/${cleanEndpoint}`;
};

export const getAuthHeaders = (): Record<string, string> => {
  const token = localStorage.getItem('token');
  const headers: Record<string, string> = { ...API_CONFIG.HEADERS };
  
  if (token) {
    headers['Authorization'] = `Bearer ${token}`;
  }
  
  return headers;
};

// Debug logging
console.log('API Configuration:', {
  baseUrl: API_CONFIG.BASE_URL,
  environment: process.env.NODE_ENV,
  customApiUrl: process.env.REACT_APP_API_BASE_URL
});