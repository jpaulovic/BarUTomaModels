using BarUTomaServer.Models;

namespace BarUTomaModels.Models
{
    public class IngredientDrink
    {
        public Ingredient Ingredient { get; set; }
        public Drink Drink { get; set; }
        public Quantity Quantity { get; set; }
    }
}