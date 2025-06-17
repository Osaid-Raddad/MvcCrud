using Microsoft.AspNetCore.Mvc;
using introToMvc.Data;
namespace introToMvc.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var products = context.Products.ToList();
            return View("index", products);
        }

        public ViewResult Details(int id)
        {
            Console.WriteLine($"Product id: {id} ");
            var product = context.Products.Find(id);
            return View("Details", product);
        }

        public ViewResult Create()
        {
            return View("Create");
        }

    }
}
