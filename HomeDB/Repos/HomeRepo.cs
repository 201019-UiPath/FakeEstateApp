using System.Collections.Generic;
using System;
using HomeDB.Models;
using System.Linq;
using HomeDB.Entities;
using HomeDB.Mappers;
using Microsoft.EntityFrameworkCore;

namespace HomeDB
{
    public class HomeRepo : IRepo
    {
        private HomeContext context;
        private IMapper mapper;
        
        public HomeRepo (HomeContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddFeature(Feature Feature)
        {
            context.Features.Add(mapper.ParseFeature(Feature));
            context.SaveChanges();
        }

        public void AddHouse(House house)
        {
            throw new NotImplementedException();
        }

        public void AddHouseFeature(HouseFeature housefeature)
        {
            throw new NotImplementedException();
        }

        public void DeleteFeature(Feature Feature)
        {
            throw new NotImplementedException();
        }

        public void DeleteHouse(House house)
        {
            throw new NotImplementedException();
        }

        public void DeleteHouseFeature(HouseFeature housefeature)
        {
            throw new NotImplementedException();
        }

        public List<House> GetAllHouses()
        {
            throw new NotImplementedException();
        }

        public Feature GetFeatureById(int id)
        {
            throw new NotImplementedException();
        }

        public House GetHouseById(int id)
        {
            throw new NotImplementedException();
        }

        public House GetHouseFeatureById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateFeature(Feature Feature)
        {
            throw new NotImplementedException();
        }

        public void UpdateHouse(House house)
        {
            throw new NotImplementedException();
        }

        public void UpdateHouseFeature(HouseFeature housefeature)
        {
            throw new NotImplementedException();
        }
    }
}