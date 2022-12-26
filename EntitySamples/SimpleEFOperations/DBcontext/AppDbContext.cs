using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimpleEFOperations.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFOperations.DBcontext
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var Config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
            string ConnString = Config.GetSection("ConStr").Value;
            optionsBuilder.UseSqlServer(ConnString);
        }
        
        public DbSet<Animal> Animals { get; set; } = null!;
        public DbSet<Staff> Staff { get; set; } = null!;
    }
}

