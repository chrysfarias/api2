using api2.Models;
using Microsoft.EntityFrameworkCore;


namespace api2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {}

        public DbSet<Pessoa> pessoa { get; set; }

    }
}