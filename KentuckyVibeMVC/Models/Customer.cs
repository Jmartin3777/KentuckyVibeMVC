using System.ComponentModel.DataAnnotations.Schema;

namespace KentuckyVibeMVC.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int FavoriteDrinkId { get; set; }
        [ForeignKey("FavoriteDrinkId")]
        public virtual Drink FavoriteDrink { get; set; }
    }
}
