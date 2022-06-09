using Microsoft.EntityFrameworkCore;
using nuova_pizza_ef_mvc.Models;

namespace nuova_pizza_ef_mvc.Context
{
    public class PizzaContext : DbContext
    {

        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
        }
        public DbSet<Pizza>? Pizze { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = NuovaPizzeria; Integrated Security = True; Pooling = False");


        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().ToTable("Pizze");
        }

    }
}
