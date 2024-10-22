import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import '../assets/styles/login.css'; // Assuming you will create a CSS file for styling

const LoginPage = () => {
  const [showForgotPassword, setShowForgotPassword] = useState(false);

  const handleForgotPasswordClick = () => {
    setShowForgotPassword(true);
  };

  const handleCloseModal = () => {
    setShowForgotPassword(false);
  };

  const handleLoginSubmit = (event) => {
    event.preventDefault();
    // Handle login form submission
  };

  const handleForgotPasswordSubmit = (event) => {
    event.preventDefault();
    // Handle forgot password form submission
  };

  return (
    <div className="login-container">
      <h2>Login Form</h2>
      <form className="login-form" onSubmit={handleLoginSubmit}>
        <div className="form-group">
          <label htmlFor="username">Username:</label>
          <input type="text" id="username" name="username" required />
        </div>
        <div className="form-group">
          <label htmlFor="password">Password:</label>
          <input type="password" id="password" name="password" required />
        </div>
        <button type="submit">Login</button>
      </form>
      <div className="forgot-links">
        <Link to="#" onClick={handleForgotPasswordClick}>Forgot Password?</Link>
      </div>

      {showForgotPassword && (
        <div className="modal-overlay">
          <div className="modal-content">
            <button className="close-button" onClick={handleCloseModal}>×</button>
            <h2>Forgot Password</h2>
            <form className="forgot-password-form" onSubmit={handleForgotPasswordSubmit}>
              <div className="form-group">
                <label htmlFor="email">Email:</label>
                <input type="email" id="email" name="email" required />
              </div>
              <button type="submit">Submit</button>
            </form>
          </div>
        </div>
      )}
    </div>
  );
};

export default LoginPage;