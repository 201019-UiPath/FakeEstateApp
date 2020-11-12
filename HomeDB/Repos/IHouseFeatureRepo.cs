using HomeDB.Mappers;
using System.Collections.Generic;
using System;

namespace HomeDB.Repos
{
    public interface IHouseFeatureRepo
    {
         void AddHouseFeature(HouseFeature housefeature);
         House GetHouseFeatureById(int id);
         void DeleteHouseFeature(HouseFeature housefeature);
         void UpdateHouseFeature(HouseFeature housefeature);
    }
}