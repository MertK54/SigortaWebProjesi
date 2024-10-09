import axios, { type AxiosInstance } from 'axios';

// Axios'u TypeScript ile yapılandır
const apiClient: AxiosInstance = axios.create({
  baseURL: 'http://localhost:5000',  // ASP.NET Core API'nin URL'si
  headers: {
    'Content-Type': 'application/json',
  },
});

// API isteklerini yaz (örnek olarak bir Post listesini alalım)
export const getPosts = async () => {
  try {
    const response = await apiClient.get('/api/posts');
    return response.data;
  } catch (error) {
    console.error('Error fetching posts', error);
    throw error;
  }
};
