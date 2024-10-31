using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class NorthwindContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
