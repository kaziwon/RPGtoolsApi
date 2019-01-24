using Microsoft.EntityFrameworkCore;
using RpgTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgTools.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public virtual DbSet<MonsterModel> Monsters { get; set; }
        public virtual DbSet<ActionModel> Actions { get; set; }
        public DbSet<StatusModel> Status { get; set; }

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
       if (!optionsBuilder.IsConfigured)
       {
          
           optionsBuilder.UseMySql(@"Server=localhost;Database=RPG_TOOLS;Uid=root;Pwd=root;SslMode=none;");
       }
   }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}