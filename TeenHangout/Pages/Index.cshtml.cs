using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

public class IndexModel : PageModel
{
    public User[] Users { get; set; }
    public Post[] Posts {get; set; }
    public void OnGet()
    {
        Users = new User[]
        {
            new User(username: "ectoBiologist", age: 15, favoriteColor: "Blue"),
            new User(username: "turntechGodhead", age: 16, favoriteColor: "Red"),
            new User(username: "gardenGnostic", age: 15, favoriteColor: "Green"),
            new User(username: "tentacleTherapist", age:15, favoriteColor: "Purple")
        };

        Posts = new Post[]
        {
            new Post(username: "gardenGnostic", content: "Anyone want to play online later", likes: 30),
            new Post(username:"turntechGodhead", content:"Concert next week! so excited!", likes: 22),
            new Post(username:"ectoBiologist", content:"Watching my favorite movie again", likes: 15),
            new Post(username:"tentacleTherapist", content:"Reading the best book ever", likes: 14)
        };
    }
}
