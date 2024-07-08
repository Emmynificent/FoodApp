using System.Security.Policy;

namespace FoodApp.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public PizzaModel Pizza  { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public int Quantity {  get; set; } = 0;

        
   
    }

    public enum OrderStatus
    {
        Pending,
        Completed,
    }
}