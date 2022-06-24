namespace PracticeAPI;

public class Dish
{
    public int Id { get; set; }
    public int CookTime { get; set; }
    public string[] Ingredients { get; set; }
    public string Instructions { get; set; }
    public string DishName { get; set; }

    public Dish(int id, int cookTime, string[] ingredients, string instructions, string dishName)
    {
        this.Id = id;
        this.CookTime = cookTime;
        this.Ingredients = ingredients;
        this.Instructions = instructions;
        this.DishName = dishName;
    }
}