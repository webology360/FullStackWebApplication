import React, { useState, useEffect } from 'react';
import { toast } from '../Provider/ToastProvider'; // Import toast for notifications
import apiService from '../services/apiService'; // Import API service
import apiConstant from '../utils/apiConstant'; // Import API constants


const ProfileManagement = () => {
  const [profiles, setProfiles] = useState([]);
  const [searchTerm, setSearchTerm] = useState('');
  const [currentPage, setCurrentPage] = useState(1);
  const [profilesPerPage] = useState(5); // Number of profiles per page
  const [editingProfile, setEditingProfile] = useState(null);
  const [isLoading, setIsLoading] = useState(true);
  const [newProfile, setNewProfile] = useState({
    firstName: '',
    middleName: '',
    lastName: '',
    dateOfBirth: '',
    height: '',
    bodyComplexion: '',
    gender: '',
    zodiacSign: '',
    isBride: false,
    isGroom: false,
    imageURL: '',
    biodataURL: '',
    religion: '',
    contact: { phoneNumber: '', emailId: '' },
    address: { street: '', city: '', state: '', postalCode: '', country: '' },
    occupation: { name: '', description: '' },
    matchPreferance: { preferredChoice: '', remark: '' },
    educationalQualification: [{ name: '', description: '' }],
    relative: [{ name: '', relationship: '', remark: '' }],
  });

  useEffect(() => {
    fetchProfiles();
  }, []);

  const fetchProfiles = async () => {
    try {
//setIsLoading(true);
      const data = await apiService.get(apiConstant.Base_URL + apiConstant.Get_Profiles_API);
      setProfiles(data);
      toast.success('Profiles fetched successfully');
    } catch (error) {
      toast.error('Failed to fetch profiles');
    } finally {
     // setIsLoading(false);
    }
  };

  const handleSearch = (e) => {
    setSearchTerm(e.target.value);
  };

  const handleAddProfile = async () => {
    try {
      const result = await apiService.post(apiConstant.Base_URL + apiConstant.Add_Profile_API, true, newProfile);
      if (result) {
        setProfiles([...profiles, result]);
        resetNewProfile();
        toast.success('Profile added successfully');
      }
    } catch (error) {
      toast.error('Failed to add profile');
    }
  };

  const handleEditProfile = (profile) => {
    setEditingProfile(profile);
  };

  const handleUpdateProfile = async () => {
    try {
      const result = await apiService.updateUser(apiConstant.Base_URL + apiConstant.Update_Profile_API, editingProfile.id, editingProfile);
      if (result) {
        setProfiles(profiles.map((profile) => (profile.id === editingProfile.id ? editingProfile : profile)));
        setEditingProfile(null);
        toast.success('Profile updated successfully');
      }
    } catch (error) {
      toast.error('Failed to update profile');
    }
  };

  const handleDeleteProfile = async (id) => {
    try {
      await apiService.deleteUser(apiConstant.Base_URL + apiConstant.Delete_Profile_API, id);
      setProfiles(profiles.filter((profile) => profile.id !== id));
      toast.success('Profile deleted successfully');
    } catch (error) {
      toast.error('Failed to delete profile');
    }
  };

  const resetNewProfile = () => {
    setNewProfile({
      firstName: '',
      middleName: '',
      lastName: '',
      dateOfBirth: '',
      height: '',
      bodyComplexion: '',
      gender: '',
      zodiacSign: '',
      isBride: false,
      isGroom: false,
      imageURL: '',
      biodataURL: '',
      religion: '',
      contact: { phoneNumber: '', emailId: '' },
      address: { street: '', city: '', state: '', postalCode: '', country: '' },
      occupation: { name: '', description: '' },
      matchPreferance: { preferredChoice: '', remark: '' },
      educationalQualification: [{ name: '', description: '' }],
      relative: [{ name: '', relationship: '', remark: '' }],
    });
  };

  // Pagination logic
  // Pagination logic
const indexOfLastProfile = currentPage * profilesPerPage;
const indexOfFirstProfile = indexOfLastProfile - profilesPerPage;
const currentProfiles = profiles && profiles.length > 0 
  ? profiles.slice(indexOfFirstProfile, indexOfLastProfile) 
  : [];

  const paginate = (pageNumber) => setCurrentPage(pageNumber);

  return (
    <div>
      <h1>Profile Management</h1>
      <input
        type="text"
        placeholder="Search profiles..."
        value={searchTerm}
        onChange={handleSearch}
      />
      <table>
        <thead>
          <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Gender</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {currentProfiles && currentProfiles
            .filter((profile) =>
              profile.firstName.toLowerCase().includes(searchTerm.toLowerCase())
            )
            .map((profile) => (
              <tr key={profile.id}>
                <td>{profile.firstName}</td>
                <td>{profile.lastName}</td>
                <td>{profile.gender}</td>
                <td>
                  <button onClick={() => handleEditProfile(profile)}>Edit</button>
                  <button onClick={() => handleDeleteProfile(profile.id)}>Delete</button>
                </td>
              </tr>
            ))}
        </tbody>
      </table>
      <div>
        { profiles && profiles.length > 0 &&
          Array.from({ length: Math.ceil(profiles.length / profilesPerPage) }, (_, i) => (
            <button key={i} onClick={() => paginate(i + 1)}>
              {i + 1}
            </button>
          ))}
        
      </div>
      {editingProfile && (
        <div>
          <h2>Edit Profile</h2>
          <form>
            <input
              type="text"
              placeholder="First Name"
              value={editingProfile.firstName}
              onChange={(e) => setEditingProfile({ ...editingProfile, firstName: e.target.value })}
            />
            <input
              type="text"
              placeholder="Last Name"
              value={editingProfile.lastName}
              onChange={(e) => setEditingProfile({ ...editingProfile, lastName: e.target.value })}
            />
            {/* Add other fields here */}
            <button type="button" onClick={handleUpdateProfile}>
              Update Profile
            </button>
          </form>
        </div>
      )}
      <h2>Add Profile</h2>
      <form>
        <input
          type="text"
          placeholder="First Name"
          value={newProfile.firstName}
          onChange={(e) => setNewProfile({ ...newProfile, firstName: e.target.value })}
        />
        <input
          type="text"
          placeholder="Last Name"
          value={newProfile.lastName}
          onChange={(e) => setNewProfile({ ...newProfile, lastName: e.target.value })}
        />
        {/* Add other fields here */}
        <button type="button" onClick={handleAddProfile}>
          Add Profile
        </button>
      </form>
    </div>
  );
};

export default ProfileManagement;