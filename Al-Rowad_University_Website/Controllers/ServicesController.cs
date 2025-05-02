using Microsoft.AspNetCore.Mvc;

namespace Al_Rowad_University_Website.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Administrative()
        {
            return View();
        }
        public IActionResult Digital()
        {
            return View();
        }
    }
}
