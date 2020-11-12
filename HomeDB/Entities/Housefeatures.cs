using System;
using System.Collections.Generic;

namespace HomeDB.Entities
{
    public partial class Housefeatures
    {
        public int Id { get; set; }
        public int? Houseid { get; set; }
        public int? Featureid { get; set; }

        public virtual Features Feature { get; set; }
        public virtual Houses House { get; set; }
    }
}
