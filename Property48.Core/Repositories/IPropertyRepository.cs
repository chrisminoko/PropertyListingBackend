using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Core.Repositories
{
    public interface IPropertyRepository :IRepository<Property>
    {
        Task<IEnumerable<Property>> GetPropertyWithCitiesAsync();
        Task<Property> GetPropertyByIdAsync(int id);
    }
}
