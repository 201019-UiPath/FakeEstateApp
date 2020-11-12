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
        
    }
}