using RestaurantManagementSystem.Core.AbstractFactory.Interface;
using RestaurantManagementSystem.Core.Interfaces;
using static RestaurantManagementSystem.Core.Appetizers;
using static RestaurantManagementSystem.Core.Dessert;
using static RestaurantManagementSystem.Core.MainCourse;

namespace RestaurantManagementSystem.Core.AbstractFactory;
public class CheaseLoverMeal : IMeal
{
    public IAppetizer PrepareAppetizer()
        => new MozarellaSticks("small", "500-650", 5, new () { "Mozarella", "Flour", "Eggs" });

    public IMainCourse PrepareMainCourse()
        => new Pasta("large", "500-650", 5, new() { "Pasta", "Cheese", "White Sauce" });

    public IDessert PrepareDessert()
        => new Cheesecake("small", "500-650", 5, new() { "Cheese", "Flour", "Eggs" });
}

