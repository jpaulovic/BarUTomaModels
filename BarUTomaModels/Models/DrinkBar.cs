
namespace BarUTomaModels.Models
{
    public class DrinkBar
    {
        public string Info { get; set; }

        public virtual Drink Drink { get; set; }
        public virtual Bar Bar { get; set; }
        public virtual Quantity Price { get; set; }
    }
}