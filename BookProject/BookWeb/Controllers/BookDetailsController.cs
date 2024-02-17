using BookWeb.BookAPIRepo;
using EntityLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookWeb.Controllers
{
    public class BookDetailsController : Controller
    {
        IBookAPIRepo _Apirepo = new BookAPIRepos();
        List<Book> _GetListBook = new List<Book>();
        // GET: BookDetails
        public ActionResult Index()
        {
            _GetListBook = _Apirepo.GetBookList();
            return View(_GetListBook);
        }
        public ActionResult Add(Book _obj)
        {
            int x = _Apirepo.SaveModify(_obj);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Book _getBook = _Apirepo.GetByID(id);
            return View(_getBook);
        }
        public ActionResult Edit(int id)
        {
            Book _getBook = _Apirepo.GetByID(id);
            return View(_getBook);
        }
        [HttpPost]
        public ActionResult Edit(Book _obj)
        {
            int x = _Apirepo.SaveModify(_obj);
            return RedirectToAction("Index");

        }
    }
}