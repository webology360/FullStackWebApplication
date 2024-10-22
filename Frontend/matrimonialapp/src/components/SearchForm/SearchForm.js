import React, { useState, useEffect } from 'react';
import './SearchForm.css'; // Assuming you will create a CSS file for styling

const SearchForm = () => {
  const [dropdownData, setDropdownData] = useState({
    dropdown1: [],
    dropdown2: [],
    dropdown3: [],
    dropdown4: [],
    dropdown5: []
  });

  useEffect(() => {
    // Fetch data from the API and populate the dropdowns
    const fetchData = async () => {
      try {
        const response = await fetch('https://api.example.com/dropdown-data');
        const data = await response.json();
        setDropdownData({
          dropdown1: data.dropdown1,
          dropdown2: data.dropdown2,
          dropdown3: data.dropdown3,
          dropdown4: data.dropdown4,
          dropdown5: data.dropdown5
        });
      } catch (error) {
        console.error('Error fetching dropdown data:', error);
      }
    };

    fetchData();
  }, []);

  const handleSubmit = (event) => {
    event.preventDefault();
    // Implement your search and filter functionality here
    console.log('Form submitted');
  };

  return (
    <form onSubmit={handleSubmit} className="search-form">
      {Object.keys(dropdownData).map((dropdown, index) => (
        <div key={index} className="form-group">
          <label htmlFor={dropdown}>Dropdown {index + 1}:</label>
          <select id={dropdown} name={dropdown}>
            {dropdownData[dropdown].map((option, idx) => (
              <option key={idx} value={option.value}>{option.label}</option>
            ))}
          </select>
        </div>
      ))}
      <button type="submit" className="submit-button">Submit</button>
    </form>
  );
};

export default SearchForm;