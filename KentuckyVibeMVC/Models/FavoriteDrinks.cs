namespace KentuckyVibeMVC.Models
{
    public class FavoriteDrinks
    {
        // Drink List
        public int FavoriteId { get; set; } 
        public string FavoriteName { get; set; }
        public int Drinks { get; set; }
        public int Number { get => number; set => number = value; }

        private int number;


    }
}
