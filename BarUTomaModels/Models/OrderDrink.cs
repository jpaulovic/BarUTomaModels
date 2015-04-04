
namespace BarUTomaModels.Models
{
    public class OrderDrink
    {
        public virtual Order Order { get; set; }
        public virtual Drink Drink { get; set; }
        public virtual Quantity Quantity { get; set; }
    }
}