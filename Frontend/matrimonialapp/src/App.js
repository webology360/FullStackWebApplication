import React from 'react';
import { BrowserRouter as Router, Route, Routes,Navigate } from 'react-router-dom';
import Header from './components/common/Header';
import Footer from './components/common/Footer';
import Navbar from './components/common/Navbar';
import HomePage from './pages/HomePage';
import AboutPage from './pages/AboutPage';
import ContactPage from './pages/ContactPage';
import './assets/styles/App.css';
import LoginPage from './pages/LoginPage';
import { AuthContext } from './context/AppContext';
import { useContext } from 'react';
import AdminPage from './pages/AdminPage';
import ProfileManagement from './pages/ProfileManagement';

const App = () => {
  debugger;
const {isAuthenticated} = useContext(AuthContext);
debugger;
console.log('isAuthenticated in App.js',isAuthenticated);
  return (
   <>
      {/* <Header /> */}
    
      <Routes>
          {/* <Route path="/" element={isAuthenticated ? <HomePage /> : <Navigate to="/login" />} /> */}
          <Route path="/" element={isAuthenticated ? <HomePage /> : <Navigate to="/login"/>} />
          <Route path="/about" element={isAuthenticated ? <AboutPage /> : <Navigate to="/login" />} />
          <Route path="/contact" element={isAuthenticated ? <ContactPage /> : <Navigate to="/login" />} />
          <Route path="/admin" element={isAuthenticated ? <AdminPage /> : <Navigate to="/login" />} />
          <Route path="/login" element={<LoginPage />} />
          <Route path="/profileManagement" element={isAuthenticated ? <ProfileManagement /> : <Navigate to="/login" />} />
      </Routes>
      <Footer />
   </>
   
 
  );
};

export default App;