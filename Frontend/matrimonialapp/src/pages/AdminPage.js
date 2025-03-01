import React, {useState, useEffect} from 'react';
import { Link } from 'react-router-dom';
import Navbar from "../components/common/Navbar"; // Adjust the path as necessary
import apiService from '../services/apiService';
import apiConstant from '../utils/apiConstant';
const AdminPage = () => {


    const [users, setUser] = React.useState(null);
    const [newUser, setNewUser] = React.useState({});
    const [editingUser, setEditingUser] = React.useState(null);


    useEffect(() => {
        apiService.getUsers(apiConstant.Base_URL + apiConstant.Get_Users_API
            .replace('{roleName}', 'admin'))
            .then((data) => setUser(data));
    }, []);

    const handleAddUser = async () => {
        console.log('User added'+ JSON.stringify(newUser));
        // Call the API to add the user
        const result= await apiService.addUser(apiConstant.Base_URL+apiConstant.Add_User_API,newUser);
        if(result.succeeded === true)
        {
            setUser([...users,newUser]);
            setNewUser({});
        }
        console.log('User added'+ JSON.stringify(result));
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
                                <button onClick={() => setEditingUser(user)}>Edit</button>
                                <button>Delete</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <h2>Add User</h2>
            <input type='text' placeholder='User Name' value={newUser.userName} onChange={(e)=>setNewUser({...newUser,userName: e.target.value})}/>
            <input type='text' placeholder='First Name' value={newUser.firstName} onChange={(e)=>setNewUser({...newUser,firstName: e.target.value})}/>
            <input type='text' placeholder='Middle Name' value={newUser.middleName} onChange={(e)=>setNewUser({...newUser,middleName: e.target.value})}/>
            <input type='text' placeholder='Last Name' value={newUser.lastName} onChange={(e)=>setNewUser({...newUser,lastName: e.target.value})}/>
            <input type='text' placeholder='Email' value={newUser.email} onChange={(e)=>setNewUser({...newUser,email: e.target.value})}/>
            <input type='text' placeholder='Role' value={newUser.role} onChange={(e)=>setNewUser({...newUser,role: e.target.value})}/>
            <button onClick={handleAddUser}>Add User</button>
        </div>
    );
};

export default AdminPage;