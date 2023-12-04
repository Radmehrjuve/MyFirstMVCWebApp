using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstwebApp.WebAppUI
{
    public class NewsContext : DbContext
    {
        public NewsContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //warning You can move this code to protect potentially senstive information
                //in connection string.

                optionsBuilder.UseSqlServer(@"data source=.\MSSQLSERVER2;initial catalog=MyNewsAgency;integrated security=True;TrustServerCertificate=True;");

            }
        }
         DbSet<TopNews>topnews { get; set; }
         DbSet<NewsType>newstype { get; set; }
      
    }
}
