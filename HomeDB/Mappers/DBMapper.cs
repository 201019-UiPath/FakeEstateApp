using System.Collections.Generic;
using HomeDB.Entities;
using HomeDB.Models;
using System;

namespace HomeDB.Mappers
{
    public class DBMapper : IMapper
    {
        public Features ParseFeature(Feature feature)
        {
            return new Features()
            {
                Description = feature.Description,
                Fee = feature.Fee
            };
        }

        public Feature ParseFeature(Features features)
        {
            return new Feature()
            {
                FeatureId = features.Id,
                Description = features.Description,
                Fee = features.Fee
            };
        }

        public List<Feature> ParseFeature(ICollection<Features> features)
        {
            List<Feature> Feature = new List<Feature>();
            
                foreach (var feature in features)
            {
                Feature.Add(ParseFeature(feature));
            }
            return Feature;
        }

        public ICollection<Features> ParseFeature(List<Feature> feature)
        {
            ICollection<Features> Features = new List<Features>();
            
                foreach (var f in feature)
            {
                Features.Add(ParseFeature(f));
            }
            return Features;
        }

        public House ParseHouse(Houses houses)
        {
            return new House(){
                HouseId = houses.Id,
                Bedrooms = Convert.ToInt32(houses.Bedrooms),
                Bathroom = Convert.ToInt32(houses.Bathrooms),
                Floors = Convert.ToInt32(houses.Floors),
                Location = houses.Location,
                AC = Convert.ToBoolean(houses.Ac),
                Heating = Convert.ToBoolean(houses.Heating),
                Price = Convert.ToDecimal(houses.Price)
            };
        }

        public Houses ParseHouse(House house)
        {
            return new Houses(){
                Bedrooms = house.Bedrooms,
                Bathrooms = house.Bathrooms,
                Floors = house.Floors,
                Location = house.Location,
                Ac = house.AC,
                Heating = house.Heating,
                Price = house.Price
            };
        }

        public ICollection<Houses> ParseHouse(List<House> house)
        {
            ICollection<Houses> houses = new List<Houses>();
            foreach (var h in house)
                {
                    houses.Add(ParseHouse(h));
                }
            return houses;
        }

        public List<House> ParseHouse(ICollection<Houses> houses)
        {
            List<House> house = new List<House>();
            foreach (var h in houses)
                {
                    house.Add(ParseHouse(h));
                }
            return house;
        }

        

        

        public HouseFeature ParseHouseFeature(Housefeatures housefeatures)
        {
            return new HouseFeature()
            {
                FeatureId = housefeatures.Featureid,
                HouseId = housefeatures.Houseid,
                HouseFeatureId = housefeatures.Id
            };
        }

        public List<HouseFeature> ParseHouseFeature(ICollection<Housefeatures> housefeatures)
        {
            List<HouseFeature> HouseFeatures = new List<HouseFeature>();
            foreach (var cust in housefeatures)
                {
                    HouseFeatures.Add(ParseHouseFeature(cust));
                }
            return HouseFeatures;
        }

        public ICollection<Housefeatures> ParseHouseFeature(List<HouseFeature> houseFeature)
        {
            ICollection<Housefeatures> HouseFeatures = new List<Housefeatures>();
            foreach (var cust in houseFeature)
                {
                    HouseFeatures.Add(ParseHouseFeature(cust));
                }
            return HouseFeatures;
        }

        public Housefeatures ParseHouseFeature(HouseFeature houseFeature)
        {
            return new Housefeatures(){
                Houseid = houseFeature.HouseId,
                Featureid = houseFeature.FeatureId
        };
        }
        
    }
}
