using FoodApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        public DbSet<OrderModel> Order { get; set; }
        public DbSet<PizzaModel> Pizza
        { get; set; }
        //public DbSet<OrderItem> orderItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<PizzaModel>().HasData(
            //   new PizzaModel
            //   {
            //       Name = "Pepperoni",
            //       Description = "Pizza for the peppered swaggs",
            //       Size = SizeOption.Large,
            //       BasePrice = 8f
            //   },
            //new
            //{
            //    Name = "Hawaiin",
            //    Description = "This is from Hawaii",
            //    Size = SizeOption.Large,
            //    BasePrice = 8f
            //},
            //new
            //{
            //    Name = "Deariazza",
            //    Description = "This is made with dear love",
            //    Size = SizeOption.Large,
            //    BasePrice = 8f
            //},
            //new
            //{
            //    Name = "BeefedUp",
            //    Description = "This is a beeffed up Pizza made with love",
            //    Size = SizeOption.Medium,
            //    BasePrice = 6f
            //}
            //);
            //modelBuilder.Entity<OrderModel>().HasData(new OrderModel
            //{

            //    Pizza = PizzaModel
            //    OrderDate = DateTime.Now,
            //    Status = OrderStatus.Pending,
            //    Quantity = 2,

        }
    }
}



