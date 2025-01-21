using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportInventoryDatabase.Models;

namespace SportInventoryDatabase
{




    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Stocks> Stocks { get; set; }

        public ApplicationContext()
        {
            // Создаем базу данных при первом запуске, если она еще не существует
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Указываем строку подключения к SQLite базе данных
            optionsBuilder.UseSqlite("Data Source=sportDB.db");
        }
    }


}
