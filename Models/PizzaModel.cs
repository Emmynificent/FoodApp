using NuGet.Versioning;

namespace FoodApp.Models
{
    public enum SizeOption
    {
        Small,
        Medium,
        Large,
        ExtraLarge,
    }
    public class PizzaModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public SizeOption Size { get; set; } 
        public float BasePrice { get; set; } = 6;

    }


}

