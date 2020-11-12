using HomeDB.Mappers;
using System.Collections.Generic;
using System;

namespace HomeDB.Repos
{
    public interface IHouseRepo
    {
         void AddHouse(House house);
         House GetHouseById(int id);
         void DeleteHouse(House house);
         void UpdateHouse(House house);
    }
}