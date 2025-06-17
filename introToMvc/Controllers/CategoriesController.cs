using introToMvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace introToMvc.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public ViewResult Index()
        {
            var Categories = context.Categories.ToList();
            return View("index", Categories);
        }

        public ViewResult Details(int id)
        {
            Console.WriteLine($"Category id: {id}");
            var category = context.Categories.Find(id);
            return View(category);
        }
    }
}
