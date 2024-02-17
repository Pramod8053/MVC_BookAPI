using BookWeb.Models;
using System.Web.Mvc;

namespace BookWeb.Controllers
{
    public class HomeController : Controller
    {
        IBookRepo _repo = new BookRepo();
        public ActionResult Index()
        {
            var BookList = _repo.GetList();
            return View(BookList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}