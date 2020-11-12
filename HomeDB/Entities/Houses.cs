using System;
using System.Collections.Generic;

namespace HomeDB.Entities
{
    public partial class Houses
    {
        public Houses()
        {
            Housefeatures = new HashSet<Housefeatures>();
        }

        public int Id { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? Floors { get; set; }
        public string Location { get; set; }
        public bool? Ac { get; set; }
        public bool? Heating { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Housefeatures> Housefeatures { get; set; }
    }
}
