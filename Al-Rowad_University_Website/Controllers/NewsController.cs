using Microsoft.AspNetCore.Mvc;

namespace Al_Rowad_University_Website.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
