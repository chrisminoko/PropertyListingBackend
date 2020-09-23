using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Core.Services
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAllCity();
        Task<City> GetCityByID(int id);
        Task<City> AddCity(City newCity);
        Task UpdateCity(City cityoUpdated, City city);
        Task RemoveCity(City city);
    }
}
