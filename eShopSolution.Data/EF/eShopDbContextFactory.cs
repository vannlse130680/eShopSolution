using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class eShopDbContextFactory : IDesignTimeDbContextFactory<eShopDbContext>
    {
        public eShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder() // tạo đối tượng conf
                .SetBasePath(Directory.GetCurrentDirectory()) //FileExtensions // add thư mục hiện tại .data làm thư mục gốc
                .AddJsonFile("appsettings.json") // Json
                .Build();

            var connectionStrings = configuration.GetConnectionString("eShopSolutionDb");
            var optionsBuilder = new DbContextOptionsBuilder<eShopDbContext>();
            optionsBuilder.UseSqlServer(connectionStrings);

            return new eShopDbContext(optionsBuilder.Options);
        }
    }
}
