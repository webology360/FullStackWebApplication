import React, { createContext, useState, useEffect } from 'react';
import {jwtDecode} from 'jwt-decode';
import { Navigate,useNavigate } from 'react-router-dom';

export const AuthContext = createContext();

const AuthProvider = ({ children }) => {
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const [user, setUser] = useState(null);
  //const navigate = useNavigate();

  useEffect(() => {
    debugger
    const token = localStorage.getItem('token');
    if (token) {
      try {
        const decodedToken = jwtDecode(token);
        const currentTime = Date.now() / 1000;
        if (decodedToken.exp > currentTime) {
          setIsAuthenticated(true);
          setUser(JSON.parse(localStorage.getItem('user')));
        } else {
          removeUserCredentials();
        }
      } catch (error) {
        removeUserCredentials();
      }
    }
  }, []);

  const login = (token) => {
    localStorage.setItem('token', token);
    const decodedToken = jwtDecode(token);
    localStorage.setItem('user', JSON.stringify(decodedToken));
    setIsAuthenticated(true);
    setUser(JSON.parse(localStorage.getItem('user')));
  };

  const logout = () => {
    debugger;
    removeUserCredentials();
    setIsAuthenticated(false);
    
  };

  const removeUserCredentials = () => {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
  }

  return (
    <AuthContext.Provider value={{ isAuthenticated,user, login, logout }}>
      {children}
    </AuthContext.Provider>
  );
};

export default AuthProvider;