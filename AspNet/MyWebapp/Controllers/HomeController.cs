using System.Web.Mvc;
using MyWebapp.Models;

namespace MyWebapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewmodel = new HomeViewModel()
            {
                DivideBy = 1
            };

            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel model)
        {
            model.Result = 100 / model.DivideBy;
            return View(model);
        }
    }
}