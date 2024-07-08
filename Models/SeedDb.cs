using FoodApp.Data;

namespace FoodApp.Models;
public class SeedDb
{
    public  void Seed(OrderDbContext orderdbContext)
    {
        var pizza1 = new PizzaModel
        {
            Name = "Peperonii",
            Description = "peper for the demons",
            Size = SizeOption.Small,
            BasePrice = 10

        };
        var pizza2 = new PizzaModel
        {
            Name = "Honey Pie",
            Description = "this is a pie pizza",
            Size = SizeOption.Small,
            BasePrice = 10
        };
        var pizza3 = new PizzaModel
        {
            Name = "Deboniare",
            Description = "This name is after a friend",
            Size = SizeOption.Small,
            BasePrice = 10
        };
     
        
        var order1 = new OrderModel
        {
            Pizza = pizza1,
            OrderDate = DateTime.Now,
            Status = OrderStatus.Pending,
            Quantity = 2
        };
        var order2 = new OrderModel
        {
            Pizza = pizza2,
            OrderDate = DateTime.Now,
            Status = OrderStatus.Pending,
            Quantity = 2
        };

        orderdbContext.Pizza.AddRange(pizza1, pizza2,pizza3 );
        orderdbContext.Order.AddRange(order1, order2 );
        orderdbContext.SaveChanges();
    }
}
