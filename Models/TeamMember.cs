public class TeamMember
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public string CollegeProgram { get; set; }
    public string YearInProgram { get; set; }
}

public class Hobby
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public int Expenses { get; set; }
}

public class FavoriteFood
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public int Calories { get; set; }
}
public class FavoriteTeam
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sport { get; set; }
    public string Reason { get; set; }
    public string FavAthlete { get; set; }
}