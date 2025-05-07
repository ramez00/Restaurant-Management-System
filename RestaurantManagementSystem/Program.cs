using RestaurantManagementSystem.Core;
using RestaurantManagementSystem.Core.Interfaces;
using static RestaurantManagementSystem.Core.Appetizers;
using static RestaurantManagementSystem.Core.Dessert;
using static RestaurantManagementSystem.Core.MainCourse;
using static RestaurantManagementSystem.Core.DishFactory;


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
                    meal.Appetizer = DishFactory.CreateAppetizer("Salad");
                    break;
                case 2:
                    meal.Appetizer = DishFactory.CreateAppetizer("ChikenWings");
                    break;
                case 3:
                    meal.Appetizer = DishFactory.CreateAppetizer("MozarellaSticks");
                    break;
                case 4:
                    meal.Appetizer = DishFactory.CreateAppetizer("Nachos");
                    break;
                case 5:
                    meal.Appetizer = DishFactory.CreateAppetizer("SpringRolls");
                    break;
                case 6:
                    meal.Appetizer = DishFactory.CreateAppetizer("StuffedMushrooms");
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
                    meal.mainCourse = DishFactory.CreateMainCourse("Pasta");
                    break;
                case 2:
                    meal.mainCourse = DishFactory.CreateMainCourse("Steak");
                    break;
                case 3:
                    meal.mainCourse = DishFactory.CreateMainCourse("Pizza");
                    break;
                case 4:
                    meal.mainCourse = DishFactory.CreateMainCourse("Burger");
                    break;
                case 5:
                    meal.mainCourse = DishFactory.CreateMainCourse("Sushi");
                    break;
                case 6:
                    meal.mainCourse = DishFactory.CreateMainCourse("Risotto");
                    break;
                case 7:
                    meal.mainCourse = DishFactory.CreateMainCourse("Curry");
                    break;
                case 8:
                    meal.mainCourse = DishFactory.CreateMainCourse("Tacos");
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
                    meal.dessert = DishFactory.CreateDessert("Cake");
                    break;
                case 2:
                    meal.dessert = DishFactory.CreateDessert("Pudding");
                    break;
                case 3:
                    meal.dessert = DishFactory.CreateDessert("Sorbet");
                    break;
                case 4:
                    meal.dessert = DishFactory.CreateDessert("Cheesecake");
                    break;
                case 5:
                    meal.dessert = DishFactory.CreateDessert("Mousse");
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
