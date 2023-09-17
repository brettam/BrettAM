using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    public class MyContactInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
