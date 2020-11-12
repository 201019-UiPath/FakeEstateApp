using HomeDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using HomeDB;
using HomeDB.Models;

namespace HomeLib
{
    public class HouseFeatureService : IHouseFeatureService
    {
        IHouseFeatureRepo _repo;

        public HouseFeatureService(IHouseFeatureRepo repo)
        {
            _repo = repo;
        }

        public void AddHouseFeature(HouseFeature houseFeature)
        {
            _repo.AddHouseFeature(houseFeature);
        }
    }
}
