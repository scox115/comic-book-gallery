using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBookds
        public ActionResult Index()
        {
            return View();
        }
    }
}