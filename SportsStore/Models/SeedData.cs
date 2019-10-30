using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void Populate(SportsStoreDbContext db)
        {
            PopulateProducts(db);
        }
        private static void PopulateProducts(SportsStoreDbContext db)
            {
                if (db.Products.Any()) return;

            db.Products.AddRange(
                new Product { Name = "Kayak", Description = "A boat", Category = "WaterSports", Price = 55 },
                new Product { Name = "Ola", Description = "Adeus", Category = "Categs", Price = 69 },
                new Product { Name = "Adeus", Description = "A booty", Category = "WaterSports", Price = 455 },
                new Product { Name = "Olas", Description = "sdfsdf", Category = "Categs", Price = 649 },
                new Product { Name = "Olas1", Description = "sdfsdfssss", Category = "Categs1", Price = 649 },
                new Product { Name = "Olas2", Description = "sdfsdfddd", Category = "Categs2", Price = 6419 },
                new Product { Name = "Olas3", Description = "sdfsdfee", Category = "Categs3", Price = 6492 },
                new Product { Name = "Olas4", Description = "sdfsdfaaa", Category = "Categs4", Price = 6493 },
                new Product { Name = "Olas5", Description = "sdfsdfdfs", Category = "Categs5", Price = 6494 },
                new Product { Name = "Olas6", Description = "sdfsdfssdd", Category = "Categs6", Price = 6495 },
                new Product { Name = "Olas7", Description = "sdfsdfaadd", Category = "Categs7", Price = 6496 }
                );

            db.SaveChanges();
            }
        }
    }
