import React from 'react';
import { Link } from 'react-router-dom';
import '../../assets/styles/App.css'; // Assuming you will create a CSS file for styling
import './Navbar.css'; 
import { AuthContext } from '../../context/AppContext';
import { useContext } from 'react';
import logo from '../../assets/images/Logo.png';

const Navbar = () => {
  debugger;
  const { isAuthenticated,user,logout } = useContext(AuthContext);
  
  return (
    <nav className="navbar">
      <div className="navbar-logo">
        <img src={logo} alt="Logo" />
      </div>
      <div className="navbar-links">
        {isAuthenticated ? (
          <button  onClick={logout} className="login-button">Logout</button>
        ) : (
          <Link to="/login" className="login-button">Login</Link>
        )}
        {isAuthenticated&&user&&user.role==='superadmin' ? (
          <div>
            <Link to="/admin">Admin</Link>
            <Link to="/profileManagement">Profile Management</Link>
          </div>
        ) : null}

      </div>

    </nav>
  );
};

export default Navbar;