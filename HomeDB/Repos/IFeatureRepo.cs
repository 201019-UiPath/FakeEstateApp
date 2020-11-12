using HomeDB.Mappers;
using System.Collections.Generic;
using System;

namespace HomeDB.Repos
{
    public interface IFeatureRepo
    {
        void AddFeature(Feature Feature);
        Feature GetFeatureById(int id);
        void DeleteFeature(Feature Feature);
        void UpdateFeature(Feature Feature);
    }
}