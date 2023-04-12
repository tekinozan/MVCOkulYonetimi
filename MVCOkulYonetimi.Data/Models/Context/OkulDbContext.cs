using MVCOkulYonetimi.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCOkulYonetimi.Data.Models.Context
{
    public class OkulDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public OkulDbContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-IKMJDLK\MSSQLSERVER01;Database=OkulYonetimDb;User Id=sa;Password=1234";
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
    }
}
