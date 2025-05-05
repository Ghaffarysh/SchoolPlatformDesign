using Microsoft.AspNetCore.Mvc;

namespace Al_Rowad_University_Website.Controllers
{
    public class DeanshipsController : Controller
    {
        public IActionResult AcademicAffairs()
        {
            return View();
        }
        public IActionResult StudentAffairs()
        {
            return View();
        }
        public IActionResult QualityAssurance()
        {
            return View();
        }
        public IActionResult GeneralSecretariat()
        {
            return View();
        }
    }
}
