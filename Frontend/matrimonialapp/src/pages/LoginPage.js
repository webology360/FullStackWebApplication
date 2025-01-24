import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import apiService from '../services/apiService';
import '../assets/styles/login.css'; // Assuming you will create a CSS file for styling
import apiConstant from '../utils/apiConstant';
const LoginPage = () => {
  const [showForgotPassword, setShowForgotPassword] = useState(false);
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');

  const handleForgotPasswordClick = () => {
    setShowForgotPassword(true);
  };

  const handleCloseModal = () => {
    setShowForgotPassword(false);
  };

  const handleLoginSubmit = async (event) => {
    event.preventDefault();
    // Instead of writing username: username and password: password, you can simply write { username, password }, and JavaScript will automatically assign the values of the username and password variables to the corresponding properties in the object.
    const inputData = { username, password };
    debugger;
    const data = await apiService.post(apiConstant.API_URL, inputData);
    debugger
    // Handle the response data
  };

  const handleForgotPasswordSubmit = (event) => {
    event.preventDefault();
    // Handle forgot password form submission
  };

  const loginForm = (
    <div className="login-container">
      <h2>Login Form</h2>
      <form className="login-form" onSubmit={handleLoginSubmit}>
        <div className="form-group">
          <label htmlFor="username">Username:</label>
          <input
            type="text"
            id="username"
            name="username"
            value={username}
            onChange={(e) => setUsername(e.target.value)}
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="password">Password:</label>
          <input
            type="password"
            id="password"
            name="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
          />
        </div>
        <button type="submit">Login</button>
      </form>
      <div className="forgot-links">
        <Link to="#" onClick={handleForgotPasswordClick}>Forgot Password?</Link>
      </div>
    </div>
  );

  const forgotPasswordForm = (
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
  );

  return (
    <>
      {loginForm}
      {showForgotPassword && forgotPasswordForm}
    </>
  );
};

export default LoginPage;