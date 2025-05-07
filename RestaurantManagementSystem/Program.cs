using RestaurantManagementSystem.Core;
using RestaurantManagementSystem.Core.Interfaces;
using static RestaurantManagementSystem.Core.Appetizers;
using static RestaurantManagementSystem.Core.Dessert;
using static RestaurantManagementSystem.Core.MainCourse;

namespace RestaurantManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Restaurant Management System!");

        (IAppetizer Appetizer, IMainCourse mainCourse, IDessert dessert) meal = new();

        int choice;

        Console.WriteLine("Please select an appetizer:");
        Console.WriteLine("1. Salad");
        Console.WriteLine("2. Chiken Wings");
        Console.WriteLine("3. Mozarella Sticks");
        Console.WriteLine("4. Nachos");
        Console.WriteLine("5. Spring Rolls");
        Console.WriteLine("6. Stuffed Mushrooms");
        Console.WriteLine("Any other Key to Skip .....");

        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    meal.Appetizer = new Salad("small", "100-150", 5, new() { "cucumber", "Tomato", "Carrot" });
                    break;
                case 2:
                    meal.Appetizer = new ChikenWings("large", "400-500", 5, new() { "Chicken", "Spices", "Tomato Sauce" });
                    break;
                case 3:
                    meal.Appetizer = new MozarellaSticks("small", "500-650", 5, new() { "Mozarella", "Flour", "Eggs" });
                    break;
                case 4:
                    meal.Appetizer = new Nachos("small", "100-150", 5, new() { "Beans", "Meat" });
                    break;
                case 5:
                    meal.Appetizer = new SpringRolls("small", "100-150", 5, new() { "Egg", "Shrimp", "Carrot" });
                    break;
                case 6:
                    meal.Appetizer = new StuffedMushrooms("small", "100-150", 5, new() { "Mushroom", "Cheese", "Onion" });
                    break;
                default:
                    break;
            }
        }

        Console.Clear();


        Console.WriteLine("Please select a Main Course:");
        Console.WriteLine("1. Pasta");
        Console.WriteLine("2. Steak");
        Console.WriteLine("3. Pizza");
        Console.WriteLine("4. Burger");
        Console.WriteLine("5. Sushi");
        Console.WriteLine("6. Risotto");
        Console.WriteLine("7. Cury");
        Console.WriteLine("8. Tacos");
        Console.WriteLine("Any other Key to Skip .....");

        int MainCourse;

        if (int.TryParse(Console.ReadLine(), out MainCourse))
        {
            switch (MainCourse)
            {
                case 1:
                    meal.mainCourse = new Pasta("small", "100-150", 5, new() { "Pasta", "Tomato Sauce" });
                    break;
                case 2:
                    meal.mainCourse = new Steak("large", "400-500", 5, new() { "Steak", "Spices" });
                    break;
                case 3:
                    meal.mainCourse = new Pizza("small", "500-650", 5, new() { "Pizza Dough", "Tomato Sauce" });
                    break;
                case 4:
                    meal.mainCourse = new Burger("small", "100-150", 5, new() { "Bread", "Meat" });
                    break;
                case 5:
                    meal.mainCourse = new Sushi("small", "100-150", 5, new() { "Rice", "Fish" });
                    break;
                case 6:
                    meal.mainCourse = new Risotto("small", "100-150", 5, new() { "Rice", "Cheese" });
                    break;
                case 7:
                    meal.mainCourse = new Curry("small", "100-150", 5, new() { "Rice", "Chicken" });
                    break;
                case 8:
                    meal.mainCourse = new Tacos("small", "100-150", 5, new() { "Tortilla", "Meat" });
                    break;
                default:
                    break;
            }
            Console.Clear();
        }

        Console.Clear();

        Console.WriteLine("Please select a Dessert:");
        Console.WriteLine("1. Cake");
        Console.WriteLine("2. Pudding");
        Console.WriteLine("3. Sorbet");
        Console.WriteLine("4. Cheesecake");
        Console.WriteLine("5. Mousse");
        Console.WriteLine("Any other Key to Skip .....");

        int Dessert;
        if (int.TryParse(Console.ReadLine(), out Dessert))
        {
            switch (Dessert)
            {
                case 1:
                    meal.dessert = new Cake("Large", "300-450", 5, new() { "Flour", "Sugar" , "Egg" });
                    break;
                case 2:
                    meal.dessert = new Pudding("small", "200-350", 5, new() { "Milk", "Sugar" });
                    break;
                case 3:
                    meal.dessert = new Sorbet("small", "100-150", 5, new() { "Fruit", "Sugar" });
                    break;
                case 4:
                    meal.dessert = new Cheesecake("Meduim", "300-350", 5, new() { "Cheese", "Sugar" ,"Flour" });
                    break;
                case 5:
                    meal.dessert = new Mousse("small", "100-150", 5, new() { "Chocolate", "Cream" ,"Egg" });
                    break;
                default:
                    break;
            }
        }
        Console.Clear();


        meal.Appetizer?.Serve();
        meal.mainCourse?.Serve();
        meal.dessert?.Serve();
        Console.WriteLine("Thank you for dining with us!");
    }
}
