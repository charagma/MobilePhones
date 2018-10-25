using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MobilePhones.Data
{
    public class MobilePhonesContext : DbContext
    {
        public MobilePhonesContext() : base("MobilePhonesContext")
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}