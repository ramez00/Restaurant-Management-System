using RestaurantManagementSystem.Core.FactoryMethod;
using RestaurantManagementSystem.Core.Interfaces;
using RestaurantManagementSystem.Core.SimpleFactory;
using static RestaurantManagementSystem.Core.Appetizers;
using static RestaurantManagementSystem.Core.Dessert;
using static RestaurantManagementSystem.Core.MainCourse;
using static RestaurantManagementSystem.Core.SimpleFactory.DishFactory;

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
            meal.Appetizer = new AppetizerFactory.SaladFactory().CreateDish();
            break;
        case 2:
            meal.Appetizer = new AppetizerFactory.ChikenWingsFactory().CreateDish();
            break;
        case 3:
            meal.Appetizer = new AppetizerFactory.MozarellaSticksFactory().CreateDish();
            break;
        case 4:
            meal.Appetizer = new AppetizerFactory.NachosFactory().CreateDish();
            break;
        case 5:
            meal.Appetizer = new AppetizerFactory.SpringRollsFactory().CreateDish();
            break;
        case 6:
            meal.Appetizer = new AppetizerFactory.StuffedMushroomsFactory().CreateDish();
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
            meal.mainCourse = new MainCourseFactory.PastaFactory().CreateDish();
            break;
        case 2:
            meal.mainCourse = new MainCourseFactory.SteakFactory().CreateDish();
            break;
        case 3:
            meal.mainCourse = new MainCourseFactory.PizzaFactory().CreateDish();
            break;
        case 4:
            meal.mainCourse = new MainCourseFactory.BurgerFactory().CreateDish();
            break;
        case 5:
            meal.mainCourse = new MainCourseFactory.SushiFactory().CreateDish();
            break;
        case 6:
            meal.mainCourse = new MainCourseFactory.RisottoFactory().CreateDish();
            break;
        case 7:
            meal.mainCourse = new MainCourseFactory.CurryFactory().CreateDish();
            break;
        case 8:
            meal.mainCourse = new MainCourseFactory.TacosFactory().CreateDish();
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
            meal.dessert = new DessertFactory.CakeFactory().CreateDish();
            break;
        case 2:
            meal.dessert = new DessertFactory.PuddingFactory().CreateDish();
            break;
        case 3:
            meal.dessert = new DessertFactory.SorbetFactory().CreateDish();
            break;
        case 4:
            meal.dessert = new DessertFactory.CheesecakeFactory().CreateDish();
            break;
        case 5:
            meal.dessert = new DessertFactory.MousseFactory().CreateDish();
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
