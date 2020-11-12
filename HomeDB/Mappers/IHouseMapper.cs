using HomeDB.Entities;
using HomeDB.Models;
using System.Collections.Generic;

namespace HomeDB.Mappers
{
    public interface IHouseMapper
    {
        Houses ParseHouse(House houses);
        
    }
}