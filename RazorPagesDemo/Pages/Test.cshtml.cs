using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class TestModel : PageModel
    {
        public string Name { get; set; } = "Bob Ross";

        public void OnGet()
        {
        }
    }
}
