import Axios, { AxiosInstance } from "axios";
export class HttpClient {
  static async apiClient(): Promise<AxiosInstance> {
    const axios: AxiosInstance = Axios.create({
      timeout: 30 * 1000,
      baseURL: process.env.VUE_APP_API_BASE_URL,
    });

    return axios;
  }
}
