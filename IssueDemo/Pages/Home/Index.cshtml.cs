using Furion.DatabaseAccessor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IssueDemo.Pages.Home
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            Db.GetRepository<User2>();
        }
    }
}
