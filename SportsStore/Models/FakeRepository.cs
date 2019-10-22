﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeRepository : ISportsStoreRepository
    {
        public IEnumerable<Product> Products => new List<Product> 
        {
            new Product { Name = "Football ball", Price = 25},
            new Product { Name = "Surf board", Price = 179},
            new Product { Name = "Running shoes", Price = 95}
        };
    }
}