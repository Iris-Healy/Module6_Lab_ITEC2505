namespace TeenHangout;

public class User
{
    public string Username{ get; set; }
    public int Age { get; set; }
    public string FavoriteColor { get; set; }

    public User(string username, int age, string favoriteColor)
    {
        Username = username;
        Age = age;
        FavoriteColor = favoriteColor;
    }
}