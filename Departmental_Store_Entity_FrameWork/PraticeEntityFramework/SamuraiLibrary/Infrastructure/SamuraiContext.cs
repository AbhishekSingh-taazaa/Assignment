using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiLibrary.Infrastructure
{
   public class SamuraiContext : DbContext
    {
       public DbSet<Samurai> Samurais { get; set; }

        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }
    }
}
