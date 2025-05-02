using Microsoft.AspNetCore.Mvc;

namespace Al_Rowad_University_Website.Controllers
{
    public class CommunicationController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
