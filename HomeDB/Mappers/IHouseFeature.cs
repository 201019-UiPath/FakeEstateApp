using HomeDB.Entities;
using HomeDB.Models;
using System.Collections.Generic;

namespace HomeDB.Mappers
{
    public interface IHouseFeature
    {
        Housefeatures ParseHouseFeature(HouseFeature houseFeature);
        ICollection<Housefeatures> ParseHouseFeature(List<HouseFeature> houseFeature);
        HouseFeature ParseHouseFeature(Housefeatures housefeatures);
        List<HouseFeature> ParseHouseFeature(ICollection<Housefeatures> housefeatures);
    }
}