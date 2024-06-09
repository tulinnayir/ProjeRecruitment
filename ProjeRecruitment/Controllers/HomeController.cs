using Microsoft.AspNetCore.Mvc;

namespace ProjeRecruitment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


