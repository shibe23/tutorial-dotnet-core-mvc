using Microsoft.AspNetCore.Mvc;
using tutorial_dotnet_core_mvc.Models;

namespace tutorial_dotnet_core_mvc.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _context;

        public HelloController(MyContext context){
            this._context = context;
        }

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
        public IActionResult List()
        {
            return View(this._context.Book);
        }
    }
}
