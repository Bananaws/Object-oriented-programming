using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RuSteam_DIAGRAMS
{
    public class RuSteamContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=RuSteam.db");
        }
        public DbSet<GameEntity> Games => Set<GameEntity>();
        public DbSet<AccountEntity> Accounts => Set<AccountEntity>();
        public RuSteamContext() => Database.EnsureCreated();
    }

}
