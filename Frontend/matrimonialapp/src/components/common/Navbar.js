import React from 'react';
import { Link } from 'react-router-dom';
import '../../assets/styles/App.css'; // Assuming you will create a CSS file for styling
import './Navbar.css'; 
import { AuthContext } from '../../context/AppContext';
import { useContext } from 'react';

const Navbar = () => {
  debugger;
  const { isAuthenticated, logout } = useContext(AuthContext);
  return (
    <nav className="navbar">
      <div className="navbar-logo">
        <img src="/path/to/logo.png" alt="Logo" />
      </div>
      <div className="navbar-links">
        <Link to="/">Home</Link>
        <Link to="/about">About</Link>
        <Link to="/contact">Contact Us</Link>
        {/* <Link to="/login" className="login-button">Login</Link> */}
        {isAuthenticated ? (
          // <li><button onClick={logout}>Logout</button></li>
          <Link to="/login" onClick={logout} className="login-button">Logout</Link>
        ) : (
          <Link to="/login" className="login-button">Login</Link>
        )}
      </div>
    </nav>
  );
};

export default Navbar;