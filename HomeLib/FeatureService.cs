using System;
using System.Collections.Generic;
using System.Text;
using HomeDB;
using HomeDB.Models;

namespace HomeLib
{
    public class FeatureService : IFeatureService
    {
        IFeatureRepo _repo;

        public FeatureService(IFeatureRepo repo)
        {
            _repo = repo;
        }

        public void AddFeature(Feature feature)
        {
            _repo.AddFeature(feature);
        }

        public Feature GetFeature(int featureId)
        {
            return _repo.GetFeatureById(featureId);
        }

        public void DeleteFeature(Feature feature)
        {
            _repo.DeleteFeature(feature);
        }
    }
}
