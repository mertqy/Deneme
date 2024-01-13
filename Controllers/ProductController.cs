using Deneme.ProjeContext;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers {
    public class ProductController : Controller {
        Context context = new Context ();
        public IActionResult Index () {
            var values = context.Products.ToList ();
            return View (values);
            }
        }
    }
