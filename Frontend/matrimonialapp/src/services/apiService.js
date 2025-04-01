import { toast } from '../Provider/ToastProvider';
import apiConstant from '../utils/apiConstant';

const apiService = {
  post: async (url, requireSecurityToken, data) => {
    debugger;
    try {
      if (requireSecurityToken === null || requireSecurityToken === undefined) {
        requireSecurityToken = true;
      }
      const response = await fetch(url, {
        method: 'POST',
        headers: createHeaders(requireSecurityToken),
        body: JSON.stringify(data),
      });
      if (!response.ok) {
        throw new Error(`Response status: ${response.status}`);
      }
      const jsonResponse = await response.json();
      console.log(jsonResponse);
      debugger
      toast.success("Login successful");
      return jsonResponse;
    }
    catch (error) {

      console.error(error.message);
      toast.error("Login failed");
    }

  }
  ,
  get: async (url) => {
    try {
      const response = await fetch(url, {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json',
        },
      });
      if (!response.ok) {
        throw new Error(`Response status: ${response.status}`);
      }
      const jsonResponse = await response.json();
      
      console.log(jsonResponse);
      return jsonResponse;

    } catch (error) {
      console.error(error.message);
    }
  }
  ,
  getUsers: async (url) => {
    try {
      const response = await fetch(url, {
        method: 'GET',
        headers: createHeaders(true)
      });
      if (!response.ok) {
        throw new Error(`Response status: ${response.status}`);
      }
      const jsonResponse = await response.json();
      console.log(jsonResponse);
      return jsonResponse;

    } catch (error) {
      console.error(error.message);
    }
  },
  addUser: async (url, user) => {
    try {
      const response = await fetch(url, {
        method: 'POST',
        headers: createHeaders(true),
        body: JSON.stringify(user),
      });
     // toast("User added successfully");
      if (!response.ok) {

        throw new Error(`Response status: ${response.status}`);
      }
      const jsonResponse = await response.json();
      console.log(jsonResponse);
      return jsonResponse;

    } catch (error) {
      //toast.error("Error in adding user");
      console.error(error.message);
    }
  },
  updateUser: async (id, user) => {
    const url = (apiConstant.Base_URL + apiConstant.Update_User_API).replace('{id}', id); 

    try
    {
    const response = await fetch(url, {
      method: 'PUT',
      headers: createHeaders(true),
      body: JSON.stringify(user),
    });
    if (!response.ok) {
      throw new Error(`Response status: ${response.status}`);
    }
    const jsonResponse = await response.json();
    console.log(jsonResponse);
    toast.success("User updated successfully");
    return jsonResponse;

  } catch (error) {
    console.error(error.message);
    toast.error("Error in updating user");
  }
  },
  deleteUser: async (id) => {
    debugger;
    const url = (apiConstant.Base_URL + apiConstant.Delete_User_API).replace('{id}', id);

    try{
    const response = await fetch(url, {
      method: 'DELETE',
      headers: createHeaders(true)
    });
    if (!response.ok) {
      throw new Error(`Response status: ${response.status}`);
    }
    const jsonResponse = await response.json();
    console.log(jsonResponse);
    return jsonResponse;

  } catch (error) {
    console.error(error.message);
  }
  }
}
const createHeaders = (requireSecurityToken) => {
  debugger;
  const headers = {
    'Content-Type': 'application/json',
  };
  if (requireSecurityToken !== null && requireSecurityToken !== undefined && requireSecurityToken === true) {
    // Add security token to headers if required
    headers['Authorization'] = `Bearer ${localStorage.getItem('token')}`;
  }
  return headers;
};

export default apiService;