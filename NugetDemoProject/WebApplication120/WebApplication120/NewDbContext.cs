using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication120.Models;

namespace WebApplication120
{
    public class NewDbContext:DbContext
    { 
        public NewDbContext():base("Default")
        {

        }

        public DbSet<Us> User { get; set; }
    }
}