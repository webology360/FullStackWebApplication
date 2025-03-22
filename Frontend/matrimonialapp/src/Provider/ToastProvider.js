import React from 'react';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

const ToastProvider = ({ children }) => {
  return (
    <>
      <ToastContainer autoClose={5000} hideProgressBar={true} />
      {children}
    </>
  );
};

export { toast };
export default ToastProvider;