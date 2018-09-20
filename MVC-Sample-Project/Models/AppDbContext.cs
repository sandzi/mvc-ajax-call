using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Sample_Project.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() 
            : base("DefaultConnection")
        {

        }

        public DbSet<Products> Products { get; set; }


    }
}