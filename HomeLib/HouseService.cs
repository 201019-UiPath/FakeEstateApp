using System;
using HomeDB;
using HomeDB.Models;
using System.Collections.Generic;

namespace HomeLib
{
    public class HomeService
    {
        private IHouseRepo _repo;

        public HomeService(IHouseRepo repo)
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
    }
}
