    using RestaurantManagementSystem.Core.Interfaces;

namespace RestaurantManagementSystem.Core;
public class MainCourse
{
    public class Pasta : Dish, IMainCourse
    {
        public Pasta(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Pasta   =>   {ShowDetials()}.");
        }
    }
    public class Steak : Dish, IMainCourse
    {
        public Steak(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Steak   =>   {ShowDetials()}.");
        }
    }
    public class Pizza : Dish, IMainCourse
    {
        public Pizza(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Pizza   =>   {ShowDetials()}.");
        }
    }
    public class Burger : Dish, IMainCourse
    {
        public Burger(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Burger   =>   {ShowDetials()}.");
        }
    }
    public class Sushi : Dish, IMainCourse
    {
        public Sushi(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Sushi   =>   {ShowDetials()}.");
        }
    }
    public class Risotto : Dish, IMainCourse
    {
        public Risotto(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Risotto   =>   {ShowDetials()}.");
        }
    }
    public class Curry : Dish, IMainCourse
    {
        public Curry(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Curry   =>   {ShowDetials()}.");
        }
    }
    public class Tacos : Dish, IMainCourse
    {
        public Tacos(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Serving Tacos   =>   {ShowDetials()}.");
        }
    }
}
