using System;
using System.Collections.Generic;

namespace HomeDB.Entities
{
    public partial class Features
    {
        public Features()
        {
            Housefeatures = new HashSet<Housefeatures>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal? Fee { get; set; }

        public virtual ICollection<Housefeatures> Housefeatures { get; set; }
    }
}
