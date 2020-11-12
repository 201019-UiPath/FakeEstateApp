using System;

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
            _repo.GetAllHouses();
        }
    }
}
