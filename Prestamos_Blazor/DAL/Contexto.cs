using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prestamos_Blazor.Models;
namespace Prestamos_Blazor.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> personas { get; set; }
        public DbSet<Prestamos> prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\PANDA\source\repos\Prestamos_Blazor\DataBase\Prestamos_DB.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
