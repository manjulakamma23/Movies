using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace WebApplication3.Model
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }
        public DbSet<Movies> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Update connection string as per your database
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ManjuDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}

