using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrate;
using ProgrammersBlog.Data.Concrate.EntityFramework.Contexts;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Concrete;

namespace ProgrammersBlog.Services.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddDbContext<ProgrammersBlogContext>();
      serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
      serviceCollection.AddScoped<ICategoryService, CategoryManager>();
      serviceCollection.AddScoped<IArticleService, ArticleManager>();
      return serviceCollection;
    }
  }
}