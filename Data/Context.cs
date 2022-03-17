using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using thi_wcd.Models;

namespace thi_wcd.Data
{
    public class Context : DbContext
    {
        public Context() : base("thi-wcd")
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
