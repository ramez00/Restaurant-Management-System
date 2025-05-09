using RestaurantManagementSystem.Core.Interfaces;
using static RestaurantManagementSystem.Core.Appetizers;
using static RestaurantManagementSystem.Core.Dessert;
using static RestaurantManagementSystem.Core.MainCourse;

namespace RestaurantManagementSystem.Core.SimpleFactory;
public class DishFactory
{
    public static IAppetizer CreateAppetizer(string dishType)
    {
        return dishType switch
        {
            "Salad" => new Salad("small", "100-150", 5, new() { "cucumber", "Tomato", "Carrot" }),
            "ChikenWings" => new ChikenWings("large", "400-500", 5, new() { "Chicken", "Spices", "Tomato Sauce" }),
            "MozarellaSticks" => new MozarellaSticks("small", "500-650", 5, new() { "Mozarella", "Flour", "Eggs" }),
            "Nachos" => new Nachos("small", "100-150", 5, new() { "Beans", "Meat" }),
            "SpringRolls" => new SpringRolls("small", "100-150", 5, new() { "Egg", "Shrimp", "Carrot" }),
            _ => throw new ArgumentException("Invalid appetizer type")
        };
    }
    public static IMainCourse CreateMainCourse(string dishType)
    {
        return dishType switch
        {
            "Pasta" => new Pasta("large", "500-650", 5, new() { "Pasta", "Tomato Sauce", "Cheese" }),
            "Steak" => new Steak("large", "500-650", 5, new() { "Beef", "Spices" }),
            "Pizza" => new Pizza("large", "500-650", 5, new() { "Dough", "Tomato Sauce", "Cheese" }),
            "Burger" => new Burger("large", "500-650", 5, new() { "Bread", "Meat", "Lettuce" }),
            "Sushi" => new Sushi("large", "500-650", 5, new() { "Rice", "Fish", "Seaweed" }),
            "Risotto" => new Risotto("large", "500-650", 5, new() { "Rice", "Broth", "Mushrooms" }),
            "Cury" => new Curry("large", "500-650", 5, new() { "Rice", "Spices", "Vegetables" }),
            "Tacos" => new Tacos("large", "500-650", 5, new() { "Tortilla", "Meat", "Vegetables" }),
            _ => throw new ArgumentException("Invalid main course type")
        };
    }
    public static IDessert CreateDessert(string dishType)
    {
        return dishType switch
        {
            "Cake" => new Cake("Large", "300-450", 5, new() { "Flour", "Sugar", "Egg" }),
            "Pudding" => new Pudding("small", "200-350", 5, new() { "Milk", "Sugar" }),
            "Sorbet" => new Sorbet("small", "100-150", 5, new() { "Fruit", "Sugar" }),
            "Cheesecake" => new Cheesecake("Meduim", "300-350", 5, new() { "Cheese", "Sugar", "Flour" }),
            "Mousse" => new Mousse("small", "100-150", 5, new() { "Chocolate", "Cream", "Egg" }),
            _ => throw new ArgumentException("Invalid Dessert")
        };
    }
}