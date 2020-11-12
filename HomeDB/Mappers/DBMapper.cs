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
            throw new System.NotImplementedException();
        }

        public ICollection<Features> ParseFeaturer(List<Feature> feature)
        {
            throw new System.NotImplementedException();
        }

        public Houses ParseHouse(Houses houses)
        {
            throw new System.NotImplementedException();
        }

        public Housefeatures ParseHouseFeature(HouseFeature houseFeature)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Housefeatures> ParseHouseFeature(List<HouseFeature> houseFeature)
        {
            throw new System.NotImplementedException();
        }

        public HouseFeature ParseHouseFeature(Housefeatures housefeatures)
        {
            throw new System.NotImplementedException();
        }

        public List<HouseFeature> ParseHouseFeature(ICollection<Housefeatures> housefeatures)
        {
            throw new System.NotImplementedException();
        }
    }
}