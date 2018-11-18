using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Niit.Controllers
{
    public class LiteratureController : Controller
    {
        // GET: Literature
        public ActionResult Index()
        {
            return View();
        }
    }
}