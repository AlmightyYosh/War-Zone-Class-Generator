using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WarZone.Models
{
    public class ConnectionString:DbContext
    {
        public ConnectionString(DbContextOptions<ConnectionString> options):base(options)
        {

        }
        public DbSet<PrimaryModel> Primary { get; set; }
        public DbSet<SecondaryModel > Secondary { get; set; }
        public DbSet<LethalModel> Lethal { get; set; }
        public DbSet<PerksModel> Perks { get; set; }
        public DbSet<TacticalModel> Tactical { get; set; }

    }
}
