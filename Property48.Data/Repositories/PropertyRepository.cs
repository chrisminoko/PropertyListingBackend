using Property48.Core.Entities;
using Property48.Core.Repositories;
using Property48.Data.DbConnection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Data.Repositories
{
    public class PropertyRepository : Repository<Property>, IPropertyRepository
    {
        public PropertyRepository(Property48DB context)
            :base(context)
        {
                
        }

        public Task<Property> GetPropertyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Property>> GetPropertyWithCitiesAsync()
        {
            throw new NotImplementedException();
        }

        //https://github.com/alopes2/Medium-MyMusic-Identity/blob/master/MyMusic.Data/Repositories/ArtistRepository.cs
        //https://medium.com/swlh/building-a-nice-multi-layer-net-core-3-api-c68a9ef16368
    }
}
