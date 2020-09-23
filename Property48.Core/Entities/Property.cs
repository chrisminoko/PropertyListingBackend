using System;
using System.Collections.Generic;
using System.Text;

namespace Property48.Core.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LandArea { get; set; }
        public decimal Rate { get; set; }
        public string AreaDescription { get; set; }

        public int CityID { get; set; }
        public City City { get; set; }
    }
}
