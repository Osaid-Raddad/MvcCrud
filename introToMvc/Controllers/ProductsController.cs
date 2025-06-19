using Microsoft.AspNetCore.Mvc;
using introToMvc.Data;
using introToMvc.Models;
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
            return View("Create",new Product());
        }

        public IActionResult Add(Product request)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create",request);
            }

        }

        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);

            if (product is null)
            {
                return View("NotFound");
            }
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ViewResult NotFound()
        {
            return View("NotFound");
        }
    }
}
