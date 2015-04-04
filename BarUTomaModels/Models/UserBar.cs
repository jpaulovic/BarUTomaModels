
namespace BarUTomaModels.Models
{
    public class UserBar
    {
        public virtual User User { get; set; }
        public virtual Bar Bar { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}