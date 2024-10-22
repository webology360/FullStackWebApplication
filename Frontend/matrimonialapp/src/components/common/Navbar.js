import React from 'react';
import { Link } from 'react-router-dom';
import '../../assets/styles/App.css'; // Assuming you will create a CSS file for styling
import './Navbar.css'; 

const Navbar = () => {
  return (
    <nav className="navbar">
      <div className="navbar-logo">
        <img src="/path/to/logo.png" alt="Logo" />
      </div>
      <div className="navbar-links">
        <Link to="/">Home</Link>
        <Link to="/about">About</Link>
        <Link to="/contact">Contact Us</Link>
        <Link to="/login" className="login-button">Login</Link>

      </div>
    </nav>
  );
};

export default Navbar;