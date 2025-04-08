import React, { useEffect } from 'react';
import { Link } from 'react-router-dom';
import Navbar from "../components/common/Navbar"; // Adjust the path as necessary
import apiService from '../services/apiService';
import apiConstant from '../utils/apiConstant';
import { toast } from '../Provider/ToastProvider';

const AdminPage = () => {


    const [users, setUser] = React.useState(null);
    const [newUser, setNewUser] = React.useState({});
    const [editingUser, setEditingUser] = React.useState(null);
    
    useEffect(() => {
        fetchUsers();
    }, []);

    const fetchUsers = async () => {
        try {
          const data = await apiService.getUsers(apiConstant.Base_URL + apiConstant.Get_Users_API.replace('{roleName}', 'admin'));
          setUser(data);
        } catch (error) {
          toast.error("Failed to fetch data");
        }
      };
    const handleAddUser = async () => {
        console.log('User added' + JSON.stringify(newUser));
        // Call the API to add the user
        const result = await apiService.addUser(apiConstant.Base_URL + apiConstant.Add_User_API, newUser);
        debugger;
        if (result?.succeeded) {
            setUser(prevUsers => [...prevUsers, newUser]);
            setNewUser({});
            console.log('User added', result);
        }
    }

    const handleEditUser = (user) => {
        setEditingUser(user);
      };
      const handleUpdateUser = async () => {
        try {
          const result = await apiService.updateUser(editingUser.id, editingUser);
          debugger
          if (result!==null && result!==undefined) {
            setUser(users.map(user => (user.id === editingUser.id ? editingUser : user)));
            debugger;
            setEditingUser(null);
            toast.success("User updated successfully");
          }
        } catch (error) {
          toast.error("Failed to update user");
        }
      };

    const deleteUser = async (user) => {
        console.log('User deleted' + JSON.stringify(user));
        // Call the API to delete the user
        const result = await apiService.deleteUser(user.id);
        debugger;
        if (result !== undefined && result.succeeded === true) {
            setUser(users.filter(u => u.id !== user.id));
            console.log('User deleted' + JSON.stringify(result));
        }
    }

    return (
        <div>
            <Navbar />
            <h1>Admin Page</h1>
            <Link to="/">Go back to Home</Link>
            <h2>Users</h2>
            <table>
                <thead>
                    <tr>
                        <th>User Name</th>
                        <th>First Name</th>
                        <th>Middle Name</th>
                        <th>Last Name</th>
                        <th>Email ID</th>
                        <th>Role</th>
                    </tr>
                </thead>
                <tbody>
                    {users && users.map((user) => (
                        <tr key={user.id}>
                            <td>{user.userName}</td>
                            <td>{user.firstName}</td>
                            <td>{user.middleName}</td>
                            <td>{user.lastName}</td>
                            <td>{user.email}</td>
                            <td>{user.role}</td>
                            <td>
                                <button onClick={() => handleEditUser(user)}>Edit</button>
                                <button onClick={()=> deleteUser(user)}>Delete</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <h2>Add User</h2>
            <input type='text' placeholder='User Name' value={newUser.userName} onChange={(e) => setNewUser({ ...newUser, userName: e.target.value })} />
            <input type='text' placeholder='First Name' value={newUser.firstName} onChange={(e) => setNewUser({ ...newUser, firstName: e.target.value })} />
            <input type='text' placeholder='Middle Name' value={newUser.middleName} onChange={(e) => setNewUser({ ...newUser, middleName: e.target.value })} />
            <input type='text' placeholder='Last Name' value={newUser.lastName} onChange={(e) => setNewUser({ ...newUser, lastName: e.target.value })} />
            <input type='text' placeholder='Email' value={newUser.email} onChange={(e) => setNewUser({ ...newUser, email: e.target.value })} />
           <input type='text' placeholder='Role' value={newUser.role} onChange={(e) => setNewUser({ ...newUser, role: e.target.value })} />
            <button onClick={handleAddUser}>Add User</button>
      {editingUser && (
          <div>
              <h2>Edit User</h2>
              <input type='text' placeholder='User Name' value={editingUser.userName || ''} onChange={(e) => setEditingUser({ ...editingUser, userName: e.target.value })} />
              <input type='text' placeholder='First Name' value={editingUser.firstName || ''} onChange={(e) => setEditingUser({ ...editingUser, firstName: e.target.value })} />
              <input type='text' placeholder='Middle Name' value={editingUser.middleName || ''} onChange={(e) => setEditingUser({ ...editingUser, middleName: e.target.value })} />
              <input type='text' placeholder='Last Name' value={editingUser.lastName || ''} onChange={(e) => setEditingUser({ ...editingUser, lastName: e.target.value })} />
              <input type='text' placeholder='Email' value={editingUser.email || ''} onChange={(e) => setEditingUser({ ...editingUser, email: e.target.value })} />
              <input type='text' placeholder='Role' value={editingUser.role || ''} onChange={(e) => setEditingUser({ ...editingUser, role: e.target.value })} />
              <button onClick={handleUpdateUser}>Update User</button>
          </div>
      )}


        </div>
    );
};

export default AdminPage;