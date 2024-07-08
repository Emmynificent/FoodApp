using System.ComponentModel.DataAnnotations;

namespace FoodApp.Models
{
    public class OrderItem
    {
        [Key]
        public int PizzaInt { get; set; }   
        public SizeOption Size { get; set; }
        //public List<Topping> Topping { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public PizzaModel Pizza { get; set; }
    }
}
