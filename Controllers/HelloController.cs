using Microsoft.AspNetCore.Mvc;
namespace tutorial_dotnet_core_mvc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello!!");
        }
        public IActionResult Greet()
        {
            // ビュー変数を準備
            ViewBag.Message = "Hello Hello!";
            // ViewData["Message"] = "Hello Hello!";
            // テンプレートを呼び出す
            return View();
        }
    }
}
