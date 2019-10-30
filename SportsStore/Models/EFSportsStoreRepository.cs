using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFSportsStoreRepository : ISportsStoreRepository
    {
        private SportsStoreDbContext db;
        public EFSportsStoreRepository(SportsStoreDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Product> Products => db.Products;
    }
}
