using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Property48.Core.Entities
{
    public class City
    {
        public City()
        {
            Properties = new Collection<Property>();
            Areas = new Collection<Area>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Property> Properties {get; set;}
        public ICollection<Area> Areas { get; set; }

    }
}
