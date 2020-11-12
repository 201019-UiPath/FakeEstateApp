using HomeDB.Models;
using System.Collections.Generic;
using System;

namespace HomeDB
{
    public interface IHouseRepo
    {
         void AddHouse(House house);
         House GetHouseById(int id);
         List <House> GetAllHouses();
         void DeleteHouse(House house);
         void UpdateHouse(House house);
    }
}