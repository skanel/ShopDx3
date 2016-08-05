using System.Web.Mvc;

namespace ShopDx3.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Product!";

            return View();
        }
    }
}
