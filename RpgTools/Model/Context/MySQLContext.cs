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

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}

       // public DbSet<MonsterModel> Monsters { get; set; }
        public DbSet<ActionModel> Actions { get; set; }
        public DbSet<StatusModel> Status { get;set; }

    }
}