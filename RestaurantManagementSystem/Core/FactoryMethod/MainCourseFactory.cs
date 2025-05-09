using RestaurantManagementSystem.Core.FactoryMethod.Abstract;
using RestaurantManagementSystem.Core.Interfaces;
using static RestaurantManagementSystem.Core.MainCourse;

namespace RestaurantManagementSystem.Core.FactoryMethod;
public class MainCourseFactory
{
    public class PastaFactory : DishFactory
    {
        public override IMainCourse CreateDish()
            => new Pasta("large", "400-500", 5, new() { "Pasta", "Tomato Sauce", "Cheese" });
    }
    public class SteakFactory : DishFactory
    {
        public override IMainCourse CreateDish()
            => new Steak("large", "600-700", 5, new() { "Beef", "Spices" });
    }
    public class PizzaFactory : DishFactory
    {
        public override IMainCourse CreateDish()
            => new Pizza("large", "800-900", 5, new() { "Dough", "Tomato Sauce", "Cheese" });
    }
    public class BurgerFactory : DishFactory
    {
        public override IMainCourse CreateDish()
            => new Burger("large", "500-600", 5, new() { "Bread", "Meat" });
    }
    public class SushiFactory : DishFactory
    {
        public override IMainCourse CreateDish()
            => new Sushi("small", "200-300", 5, new() { "Rice", "Fish" });
    }
    public class RisottoFactory : DishFactory
    {
        public override IMainCourse CreateDish()
            => new Risotto("large", "500-600", 5, new() { "Rice", "Broth" });
    }
    public class CurryFactory : DishFactory
    {
        public override IMainCourse CreateDish()
            => new Curry("large", "500-600", 5, new() { "Rice", "Spices" });
    }
    public class TacosFactory : DishFactory
    {
        public override IMainCourse CreateDish()
            => new Tacos("large", "500-600", 5, new() { "Tortilla", "Meat" });
    }
}
