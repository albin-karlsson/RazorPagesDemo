using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class MyPageModel : PageModel
    {
        public string Message { get; set; }

        public MyPageModel()
        {

        }

        public void OnGet()
        {
            Message = "This is a message set in the OnGet method";



        }
    }
}
