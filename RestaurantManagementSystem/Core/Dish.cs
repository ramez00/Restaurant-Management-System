
namespace RestaurantManagementSystem.Core;
public abstract class Dish
{
    public string Size { get; set; }
    public string Calories { get; set; }
    public decimal Price { get; set; }
    public List<string> Ingredients { get; set; }

    public Dish(string size, string calories, decimal price, List<string> ingredients)
    {
        Size = size;
        Calories = calories;
        Price = price;
        Ingredients = ingredients;
    }

    protected string ShowDetials()
        => $"Size: {Size}, Calories: {Calories}, Price: {Price}, Ingredients: {string.Join(", ", Ingredients)}";
}
