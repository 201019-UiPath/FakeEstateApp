using System;
using HomeDB;
using HomeDB.Models;
using System.Collections.Generic;

namespace HomeLib
{
    public class HouseService : IHouseService
    {
        private IHouseRepo _repo;
        private FeatureService featureService;

        public HouseService(IHouseRepo repo)
        {
            _repo = repo;
            featureService = new FeatureService((IFeatureRepo)repo);
        }

        public void AddHouse(House house)
        {
            _repo.AddHouse(house);
        }

        public List<House> GetAllHouses()
        {
            List<House> houses = _repo.GetAllHouses();
            foreach (House house in houses)
            {
                house.Features = new List<Feature>();
                if (house.Housefeature != null)
                {
                    foreach (HouseFeature houseFeature in house.Housefeature)
                    {
                        house.Features.Add( featureService.GetFeature(Convert.ToInt32(houseFeature.FeatureId)) );
                    }
                }
            }
            return houses;
        }

        public House GetHouse(int id)
        {
            House house = _repo.GetHouseById(id);
            house.Features = new List<Feature>();
            if (house.Housefeature != null)
            {
                foreach (HouseFeature houseFeature in house.Housefeature)
                {
                    house.Features.Add( featureService.GetFeature(Convert.ToInt32(houseFeature.FeatureId)) );
                }
            }
            return house;
        }

        public void DeleteHouse(int id)
        {
            _repo.DeleteHouseById(id);
        }
    }
}
