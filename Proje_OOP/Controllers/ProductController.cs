using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Proje_OOP.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        public IActionResult Index()
        {
            var values = productManager.GetList();
            return View(values);
        }
    }
}
