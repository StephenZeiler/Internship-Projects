namespace PracticeAPI;

public class Chef
{
    public int Id { get; set; }
    public int YearsExp { get; set; }
    public string BestDishes { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Chef(int id, int yearsExp, string bestDishes, string firstName, string lastName)
    {
        this.Id = id;
        this.YearsExp = yearsExp;
        this.BestDishes = bestDishes;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}