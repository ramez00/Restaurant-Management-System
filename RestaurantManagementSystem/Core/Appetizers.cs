using RestaurantManagementSystem.Core.Interfaces;

namespace RestaurantManagementSystem.Core;
public class Appetizers 
{
    public class Salad : Dish, IAppetizer
    {
        public Salad(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Salad   =>   {ShowDetials()}.");
        }
    }
    public class ChikenWings : Dish, IAppetizer
    {
        public ChikenWings(string size, string calories, decimal price, List<string> ingredients) 
            : base(size, calories, price, ingredients)
        {
        }

        public void Serve()
        {
            Console.WriteLine($"Serving Chicken Wings   =>   {ShowDetials()}.");
        }
    }
    public class MozarellaSticks : Dish, IAppetizer
    {
        public MozarellaSticks(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Mozarella Sticks   =>   {ShowDetials()}.");
        }
    }
    public class Nachos : Dish, IAppetizer
    {
        public Nachos(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Nachos   =>   {ShowDetials()}.");
        }
    }
    public class SpringRolls : Dish, IAppetizer
    {
        public SpringRolls(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Spring Rolls   =>   {ShowDetials()}.");
        }
    }
    public class StuffedMushrooms : Dish, IAppetizer
    {
        public StuffedMushrooms(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Stuffed Mushrooms   =>   {ShowDetials()}.");
        }
    }
}