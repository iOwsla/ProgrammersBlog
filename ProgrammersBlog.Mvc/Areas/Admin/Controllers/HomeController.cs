using Microsoft.AspNetCore.Mvc;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class HomeController : Controller
  {
    // GET
    public IActionResult Index()
    {
      return View();
    }
  }
}