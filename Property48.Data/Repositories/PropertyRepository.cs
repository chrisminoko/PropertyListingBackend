using Property48.Core.Entities;
using Property48.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Data.Repositories
{
    public class PropertyRepository : Repository<Property>, IPropertyRepository
    {
      
        public Task<Property> GetPropertyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetPropertyWithCitiesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
