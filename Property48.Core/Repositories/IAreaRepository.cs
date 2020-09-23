using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Core.Repositories
{
    public interface IAreaRepository:IRepository<Area>
    {
        Task<IEnumerable<Area>> GetAllAreaWithCitiesAsync();
        Task<IEnumerable<Area>> GetAllAreaByCityID(int id);
    }
}
