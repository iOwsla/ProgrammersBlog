using System.Collections.Generic;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.Dtos
{
  public class CategoryListDto : DtoGetBase
  {
    public IList<Category> Categories { get; set; }
  }
}