using Microsoft.AspNetCore.Mvc;
namespace tutorial_dotnet_core_mvc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello!!");
        }
    }
}
