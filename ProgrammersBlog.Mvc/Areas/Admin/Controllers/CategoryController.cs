using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilites.Results.ComplexTypes;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class CategoryController : Controller
  {
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
      _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
      var result = await _categoryService.GetAll();
      if (result.ResultStatus == ResultStatus.Success)
      {
        return View(result.Data);
      }
      return View();
    }
  }
}