using Niit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Niit.Controllers
    
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        [HttpGet]
        // GET: Account
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(Reg u)
        {
            kolkataEntities db = new kolkataEntities();
            var count = db.Regs.Where(x => x.UserName == u.UserName && x.Password == u.Password).Count();
            if (count == 0)
            {
                ViewBag.msg = "invalide user";
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                return RedirectToAction("Index", "Home");
            }

        }






        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}