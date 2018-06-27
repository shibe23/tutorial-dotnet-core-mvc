using Microsoft.EntityFrameworkCore;

namespace tutorial_dotnet_core_mvc.Models
{
  public class MyContext: DbContext
  {
    public MyContext(DbContextOptions<MyContext> options):base(options) {}
    public DbSet<Book> Book {get; set;}
  }
}