using System;
using System.Collections.Generic;
using System.Text;
using HomeDB.Models;

namespace HomeLib
{
    public interface IHouseFeatureService
    {
        void AddHouseFeature(HouseFeature houseFeature);
    }
}
