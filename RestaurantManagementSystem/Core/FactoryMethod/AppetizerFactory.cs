using RestaurantManagementSystem.Core.FactoryMethod.Abstract;
using RestaurantManagementSystem.Core.Interfaces;
using static RestaurantManagementSystem.Core.Appetizers;

namespace RestaurantManagementSystem.Core.FactoryMethod;
public class AppetizerFactory
{
    public class SaladFactory : DishFactory
    {
        public override IAppetizer CreateDish()
            => new Salad("small", "100-150", 5, new() { "cucumber", "Tomato", "Carrot" });
    }
    public class ChikenWingsFactory : DishFactory
    {
        public override IAppetizer CreateDish()
            => new ChikenWings("large", "400-500", 5, new() { "Chicken", "Spices", "Tomato Sauce" });
    }
    public class MozarellaSticksFactory : DishFactory
    {
        public override IAppetizer CreateDish()
            => new MozarellaSticks("small", "500-650", 5, new() { "Mozarella", "Flour", "Eggs" });
    }
    public class NachosFactory : DishFactory
    {
        public override IAppetizer CreateDish()
            => new Nachos("small", "100-150", 5, new() { "Beans", "Meat" });
    }
    public class SpringRollsFactory : DishFactory
    {
        public override IAppetizer CreateDish()
            => new SpringRolls("small", "100-150", 5, new() { "Egg", "Shrimp", "Carrot" });
    }
    public class StuffedMushroomsFactory : DishFactory
    {
        public override IAppetizer CreateDish()
            => new StuffedMushrooms("small", "100-150", 5, new() { "Mushrooms", "Cheese", "Spices" });
    }
}
