// import React from 'react';
// import { Navigate } from 'react-router-dom';
// import { jwtDecode } from 'jwt-decode';

// const isTokenValid = () => {
//     debugger;
//     const token = localStorage.getItem('token');
//     if (!token) {
//       return false;
//     }
  
//     try {
//       const decodedToken = jwtDecode(token);
//       const currentTime = Date.now() / 1000;
//       return decodedToken.exp > currentTime;
//     } catch (error) {
//       return false;
//     }
//   };

//   const PrivateRoute = ({ children }) => {
//     debugger;
//     const isAuthenticated = isTokenValid();
//     return isAuthenticated ? children : <Navigate to="/login" />;
//   };
  
//   export default PrivateRoute;