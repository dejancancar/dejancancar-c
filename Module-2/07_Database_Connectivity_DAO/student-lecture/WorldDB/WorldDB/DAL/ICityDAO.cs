using System.Collections.Generic;
using WorldDB.Models;

namespace WorldDB.DAL
{
    public interface ICityDAO
    {
        List<City> GetCitiesByCountry(string countryCode);
    }
}