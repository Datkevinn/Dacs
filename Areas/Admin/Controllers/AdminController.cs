using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult TrangChuAdmin()
        {
            return View();
        }
    }
}
