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

        public void AddFeature(Feature feature)
        {
            context.Features.Add(mapper.ParseFeature(feature));
            context.SaveChanges();
        }

        public void AddHouse(House house)
        {
            context.Houses.Add(mapper.ParseHouse(house));
            context.SaveChanges();
        }

        public void AddHouseFeature(HouseFeature housefeature)
        {
            context.Housefeatures.Add(mapper.ParseHouseFeature(housefeature));
            context.SaveChanges();
        }

        public void DeleteFeature(Feature feature)
        {
            context.Features.Remove(mapper.ParseFeature(feature));
            context.SaveChanges();
        }

        public void DeleteHouse(House house)
        {
            context.Houses.Remove(mapper.ParseHouse(house));
            context.SaveChanges();
        }

        public void DeleteHouseFeature(HouseFeature housefeature)
        {
            context.Housefeatures.Remove(mapper.ParseHouseFeature(housefeature));
            context.SaveChanges();
        }

        public List<House> GetAllHouses()
        {
            return mapper.ParseHouse(
                context.Houses
                .ToList()
            );
        }

        public Feature GetFeatureById(int id)
        {
            return mapper.ParseFeature(
                context.Features
                .First(x => x.Id == id));
        }

        public House GetHouseById(int id)
        {
            return mapper.ParseHouse(
                context.Houses
                .First(x => x.Id == id));
        }

        public House GetHouseFeatureById(int id)
        {
            return mapper.ParseHouseFeature(
                context.Housefeatures
                .First(x => x.Id == id));
        }

        public void UpdateFeature(Feature feature)
        {
            context.Features.Update(mapper.ParseFeature(feature));
            context.SaveChanges();
        }

        public void UpdateHouse(House house)
        {
            context.Houses.Update(mapper.ParseHouse(house));
            context.SaveChanges();
        }

        public void UpdateHouseFeature(HouseFeature housefeature)
        {
            context.Housefeatures.Update(mapper.ParseHouseFeature(housefeature));
            context.SaveChanges();
        }
    }
}