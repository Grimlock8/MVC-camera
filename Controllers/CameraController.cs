using Microsoft.AspNetCore.Mvc;

namespace CameraTest.Controllers
{
    public class CameraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
