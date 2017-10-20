using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchMovieInformation.Models
{
    public class WatchListDbContext:DbContext
    {
        public DbSet<WatchList> WatchLists { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Generic> Generics { get; set; }
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ActorDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=WatchList;Trusted_Connection=True;");
        }
    }
}
