
using RestaurantManagementSystem.Core.AbstractFactory.Interface;
using RestaurantManagementSystem.Core.Interfaces;
using static RestaurantManagementSystem.Core.Appetizers;
using static RestaurantManagementSystem.Core.Dessert;
using static RestaurantManagementSystem.Core.MainCourse;

namespace RestaurantManagementSystem.Core.AbstractFactory;
public class DietMeal : IMeal
{
    public IAppetizer PrepareAppetizer()
        => new Salad("small", "100-150", 5, new() { "cucumber", "Tomato", "Carrot" });

    public IDessert PrepareDessert()
        => new Sorbet("small", "100-150", 5, new() { "Fruit", "Sugar" });

    public IMainCourse PrepareMainCourse()
        => new Steak("Small", "300-450", 5, new () { "Beef", "Spices","Special Sous" });
}
