using HomeDB.Models;
using System.Collections.Generic;
using System;

namespace HomeDB
{
    public interface IFeatureRepo
    {
        void AddFeature(Feature feature);
        Feature GetFeatureById(int id);
        List<Feature> GetAllFeatures();
        void DeleteFeature(Feature feature);
        void UpdateFeature(Feature feature);
    }
}