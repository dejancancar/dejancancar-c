//this service contains all of the functions which call our API
import axios from 'axios';

const http = axios.create({
    //Base URL of every end point that we will be calling
    baseURL: process.env.VUE_APP_REMOTE_API
});

export default {
    getCities(countryCode, district){
        let url = '/cities';
        if(countryCode){
            url += '?countryCode=' + countryCode;
            if(district){
                url += `&district=${district}`;
            }
        }
        return http.get(url);
    },
    getCity(cityId){
        return http.get(`/cities/${cityId}`);
    },
    
    addCity(city){
        return http.post('/cities', city);
    }
}