using RestaurantManagementSystem.Core.FactoryMethod.Abstract;
using RestaurantManagementSystem.Core.Interfaces;
using static RestaurantManagementSystem.Core.Dessert;

namespace RestaurantManagementSystem.Core.FactoryMethod;
public class DessertFactory
{
    public class CakeFactory : DishFactory
    {
        public override IDessert CreateDish()
            => new Cake("large", "500-600", 5, new() { "Flour", "Sugar", "Eggs" });
    }
    public class PuddingFactory : DishFactory
    {
        public override IDessert CreateDish()
            => new Pudding("small", "200-350", 5, new() { "Milk", "Sugar" });
    }
    public class SorbetFactory : DishFactory
    {
        public override IDessert CreateDish()
            => new Sorbet("small", "100-150", 5, new() { "Fruit", "Sugar" });
    }
    public class CheesecakeFactory : DishFactory
    {
        public override IDessert CreateDish()
            => new Cheesecake("medium", "300-350", 5, new() { "Cheese", "Sugar", "Flour" });
    }
    public class MousseFactory : DishFactory
    {
        public override IDessert CreateDish()
            => new Mousse("small", "100-150", 5, new() { "Chocolate", "Cream", "Egg" });
    }
}
