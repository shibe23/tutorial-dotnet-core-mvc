using Microsoft.AspNetCore.Mvc;
namespace tutorial_dotnet_core_mvc.Controllers
{
    public class HelloController : Controller
    {
        //IActionResultオブジェクトはContollerクラスで用意されたメソッドで制定できる
        public IActionResult Index()
        {
            return Content("Hello!!");
        }
    }
}
