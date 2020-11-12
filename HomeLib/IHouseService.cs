using System.Collections.Generic;
using HomeDB.Models;

namespace HomeLib
{
    public interface IHouseService
    {
        void AddHouse(House house);
        void DeleteHouse(int id);
        List<House> GetAllHouses();
        House GetHouse(int id);
    }
}