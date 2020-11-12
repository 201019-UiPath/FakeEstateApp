using System;
using HomeDB;
using HomeDB.Models;
using System.Collections.Generic;

namespace HomeLib
{
    public class HouseService : IHouseService
    {
        private IHouseRepo _repo;

        public HouseService(IHouseRepo repo)
        {
            _repo = repo;
        }

        public void AddHouse(House house)
        {
            _repo.AddHouse(house);
        }

        public List<House> GetAllHouses()
        {
            return _repo.GetAllHouses();
        }

        public House GetHouse(int id)
        {
            return _repo.GetHouseById(id);
        }

        public void DeleteHouse(House house)
        {
            _repo.DeleteHouse(house);
        }
    }
}
