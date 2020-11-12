using System.Collections.Generic;
using HomeDB.Models;

namespace HomeLib
{
    public interface IFeatureService
    {
        void AddFeature(Feature feature);
        void DeleteFeature(Feature feature);
        Feature GetFeature(int featureId);
        List<Feature> GetAllFeatures();
    }
}