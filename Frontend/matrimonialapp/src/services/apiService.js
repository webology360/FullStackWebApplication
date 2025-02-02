const apiService = {
  post: async (url, requireSecurityToken,data) => {
    debugger;
    if (requireSecurityToken === null || requireSecurityToken === undefined) {
      requireSecurityToken = true;
    }
    try {
      const response = await fetch(url, {
        method: 'POST',
        headers: createHeaders (requireSecurityToken),
        body: JSON.stringify(data),
      });
      if (!response.ok) {
        const errorData = await response.json();
        throw new Error(errorData.message || 'Something went wrong');
      }
     
      return response.json();
    } catch (error) {
      console.error('API POST Error:', error);
      //I am not thorwing the exception here, jsut logging it into console.
      //throw error;
    }
  },
  get: async (url) => {
    try {
      const response = await fetch(url, {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json',
        },
      });
      if (!response.ok) {
        const errorData = await response.json();
        throw new Error(errorData.message || 'Something went wrong');
      }
      return response.json();
    } catch (error) {
      console.error('API GET Error:', error);
      //I am not thorwing the exception here, jsut logging it into console.
      //throw error;
    }
  },
  // Similarly, update the put and delete methods
};

const createHeaders = (requireSecurityToken) => {
  debugger;
  const headers = {
    'Content-Type': 'application/json',
  };
  if(requireSecurityToken !== null && requireSecurityToken !== undefined && requireSecurityToken===true){
     // Add security token to headers if required
     headers['Authorization'] = `Bearer ${localStorage.getItem('token')}`;
  }
  return headers;
};

export default apiService;