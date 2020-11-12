using HomeDB.Models;
using System.Collections.Generic;
using System;

namespace HomeDB
{
    public interface IHouseFeatureRepo
    {
         void AddHouseFeature(HouseFeature housefeature);
         HouseFeature GetHouseFeatureById(int id);
         List <House> GetHouseByLocation(string location);
         void DeleteHouseFeature(HouseFeature housefeature);
         void UpdateHouseFeature(HouseFeature housefeature);
    }
}