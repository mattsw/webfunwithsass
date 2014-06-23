namespace SassProject.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View("~/Views/TestPage.cshtml");
        }
    }
}
