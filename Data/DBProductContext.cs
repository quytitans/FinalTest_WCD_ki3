using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FinalTestWCD.Models;

namespace FinalTestWCD.Data
{
    public class DBProductContext : DbContext
    {
        public DBProductContext() : base("ConnectionString")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}