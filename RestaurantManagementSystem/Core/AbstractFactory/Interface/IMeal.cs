using RestaurantManagementSystem.Core.Interfaces;

namespace RestaurantManagementSystem.Core.AbstractFactory.Interface;
public interface IMeal
{
    // Abstract Factory => to Create Objects Related to Meal
    public IAppetizer PrepareAppetizer();
    public IMainCourse PrepareMainCourse();
    public IDessert PrepareDessert();
}