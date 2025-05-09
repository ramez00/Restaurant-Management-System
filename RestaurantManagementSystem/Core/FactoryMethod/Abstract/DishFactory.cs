using RestaurantManagementSystem.Core.Interfaces;

namespace RestaurantManagementSystem.Core.FactoryMethod.Abstract;
public abstract class DishFactory
{
    public abstract IDish CreateDish();
}