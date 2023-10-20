using Microsoft.AspNetCore.Mvc;

namespace ProgrammersBlog.Mvc.HomeController
{
  public class HomeController : Controller
  {
    // GET
    public IActionResult Index()
    {
      return View();
    }
  }
}