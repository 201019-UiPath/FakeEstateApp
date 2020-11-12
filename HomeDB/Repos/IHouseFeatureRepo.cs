using HomeDB.Models;
using System.Collections.Generic;
using System;

namespace HomeDB
{
    public interface IHouseFeatureRepo
    {
         void AddHouseFeature(HouseFeature housefeature);
         House GetHouseFeatureById(int id);
         void DeleteHouseFeature(HouseFeature housefeature);
         void UpdateHouseFeature(HouseFeature housefeature);
    }
}