using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Database;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages.Fruits
{
    public class DetailsModel : PageModel
    {
        public Fruit? Fruit { get; set; }

        public void OnGet(int id, string name)
        {
            Fruit = FruitsRepo.Fruits.FirstOrDefault(f => f.Id == id);
        }
    }
}
