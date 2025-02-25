using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refuge.DAL.Entities;

namespace Refuge.DAL
{
    public class RefugeContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Cat> Cats { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=DESKTOP-E563U3H;database=cat.db;integrated security=true;trustServerCertificate=true");
        //}
    }
}