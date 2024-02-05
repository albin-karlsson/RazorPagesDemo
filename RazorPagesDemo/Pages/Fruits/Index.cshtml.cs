using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Database;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages.Fruits
{
    public class IndexModel : PageModel
    {
        public List<Fruit> Fruits { get; set; }

        public void OnGet()
        {
            // Hämta alla frukter i "databasen"
            Fruits = FruitsRepo.Fruits;
        }
    }
}
