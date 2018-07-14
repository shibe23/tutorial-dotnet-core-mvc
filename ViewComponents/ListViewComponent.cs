using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tutorial_dotnet_core_mvc.Models;
using System.Linq;
using System.Threading.Tasks;
namespace tutorial_dotnet_core_mvc.ViewComponents
{
  // ビューコンポーネントを定義
  public class ListViewComponent : ViewComponent
  {
    private readonly MyContext _context;
    // コンテキストクラスを有効化
    public ListViewComponent(MyContext context)
    {
      this._context = context;
    }

    // ビューコンポーネントの実処理
    public async Task<IViewComponentResult> InvokeAsync(int price)
    {
      // price円以上の書籍を取得
      return View(await _context.Book.Where(b => b.Price >= price).ToListAsync());
    }
  }
}