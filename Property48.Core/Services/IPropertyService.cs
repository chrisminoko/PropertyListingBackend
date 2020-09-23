using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Property48.Core.Services
{
    public interface IPropertyService
    {
        Task<IEnumerable<Property>> GetAllProperties();
        Task<Property> GetPropertyByID(int id);
        Task<Property> AddProperty(Property newProperty);
        Task UpdateProperty(Property propertyToUpdated, Property property);
        Task RemoveProperty(Property property);
    }
}
