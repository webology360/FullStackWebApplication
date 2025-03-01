import React from 'react';
import { Link } from 'react-router-dom';
import '../../assets/styles/App.css'; // Assuming you will create a CSS file for styling
import './Navbar.css'; 
import { AuthContext } from '../../context/AppContext';
import { useContext } from 'react';

const Navbar = () => {
  debugger;
  const { isAuthenticated,user,logout } = useContext(AuthContext);
  
  return (
    <nav className="navbar">
      <div className="navbar-logo">
        <img src="/path/to/logo.png" alt="Logo" />
      </div>
      <div className="navbar-links">
        {isAuthenticated ? (
          <button  onClick={logout} className="login-button">Logout</button>
        ) : (
          <Link to="/login" className="login-button">Login</Link>
        )}
        {isAuthenticated&&user&&user.role==='superadmin' ? (
          <Link to="/admin" className="admin-button">Admin</Link>
        ) : null}

      </div>
    </nav>
  );
};

export default Navbar;