using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Core.Services
{
    public interface IAreaService
    {
        Task<IEnumerable<Area>> GetAllArea();
        Task<Area> GetAreaByID(int id);
        Task<Area> AddArea(Area newArea);
        Task UpdateArea(Area areaToUpdated, Area area);
        Task RemoveArea(Area area);
    }
}
