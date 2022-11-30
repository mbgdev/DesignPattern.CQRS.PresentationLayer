using DesignPattern.CQRS.PresentationLayer.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.PresentationLayer.DAL.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-T9KCH5P; Database=ACQRSDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
