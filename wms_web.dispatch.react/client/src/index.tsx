import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
// If you have Tailwind or global styles, import them here
// import './index.css';

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
); 