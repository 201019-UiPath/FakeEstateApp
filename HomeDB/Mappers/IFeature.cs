using HomeDB.Entities;
using HomeDB.Models;
using System.Collections.Generic;

namespace HomeDB.Mappers
{
    public interface IFeature
    {
        Features ParseFeature(Feature feature);
        ICollection<Features> ParseFeature(List<Feature> feature);
        Feature ParseFeature(Features features);
        List<Feature> ParseFeature(ICollection<Features> features);
    }
}