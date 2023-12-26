using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace API_Batya
{
    public class DataContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }
    }
}
