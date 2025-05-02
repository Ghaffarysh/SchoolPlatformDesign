using Microsoft.AspNetCore.Mvc;

namespace Al_Rowad_University_Website.Controllers
{
    public class UniversityLifeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
