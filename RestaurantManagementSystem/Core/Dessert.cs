
using RestaurantManagementSystem.Core.Interfaces;

namespace RestaurantManagementSystem.Core;
public class Dessert
{
    public class Cake : Dish, IDessert
    {
        public Cake(string size, string calories, decimal price, List<string> ingredients) 
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Cake   =>   {ShowDetials()}.");
        }
    }
    public class Pudding : Dish, IDessert
    {
        public Pudding(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Pudding   =>   {ShowDetials()}.");
        }
    }
    public class Sorbet : Dish, IDessert
    {
        public Sorbet(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Sorbet   =>   {ShowDetials()}.");
        }
    }
    public class Cheesecake : Dish, IDessert
    {
        public Cheesecake(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Cheesecake   =>   {ShowDetials()}.");
        }
    }
    public class Mousse : Dish, IDessert
    {
        public Mousse(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Mousse   =>   {ShowDetials()}.");
        }
    }
}
