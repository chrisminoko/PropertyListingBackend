using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Core.Repositories
{
    public  interface ICityRepository :IRepository<City>
    {
        Task<IEnumerable<City>> GetAllWithArea();
        Task<City> GetWithAreaByIdAsync(int id);
        Task<IEnumerable<City>> GetAllWithCityByAreatIdAsync(int area);
    }
}
