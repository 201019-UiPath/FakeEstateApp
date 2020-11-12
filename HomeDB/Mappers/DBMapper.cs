using System.Collections.Generic;
using HomeDB.Entities;
using HomeDB.Models;

namespace HomeDB.Mappers
{
    public class DBMapper : IMapper
    {
        public Features ParseFeature(Feature feature)
        {
            return new Features()
            {
                Id = feature.FeatureId,
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

        public ICollection<Features> ParseFeaturer(List<Feature> feature)
        {
            throw new System.NotImplementedException();
        }

        public House ParseHouse(Houses houses)
        {
            throw new System.NotImplementedException();
        }

        public Housefeatures ParseHouseFeature(HouseFeature houseFeature)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Housefeatures> ParseHouseFeature(List<HouseFeature> houseFeature)
        {
            ICollection<Housefeatures> HouseFeatures = new List<Housefeatures>();
            {
                
            }
            return HouseFeatures;
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
    }
}