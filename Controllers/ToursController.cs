using Microsoft.AspNetCore.Mvc;

namespace Tr.Controllers
{
    public class ToursController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
