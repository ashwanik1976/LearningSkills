using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstAspNetCoreWebApp.Models
{
    public class MyFirstAspNetCoreWebAppContext : DbContext
    {
        public MyFirstAspNetCoreWebAppContext (DbContextOptions<MyFirstAspNetCoreWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstAspNetCoreWebApp.Models.Movie> Movie { get; set; }
    }
}
