using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Infrastructure
{
    public class DepertmentalStoreContextFoactory : IDesignTimeDbContextFactory<DepartmentalStoreContext>
    {
        public DepartmentalStoreContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

            return new DepartmentalStoreContext(new DbContextOptionsBuilder<DepartmentalStoreContext>().Options, config);

        }
    }
}
