using System.Collections.Generic;
namespace HomeDB.Models
{
    public class House
    {
        public int HouseId {get; set;}
        public int? Bathrooms {get; set;}
        public int? Bedrooms {get; set;}
        public int? Floors {get; set;}
        public string Location {get; set;}
        public bool? AC {get; set;}
        public bool? Heating {get; set;}
        public decimal? Price {get; set;}

        public List<HouseFeature> Housefeature {get;set;}
        public List<Feature> Features {get; set;}
    }
}