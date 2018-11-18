using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Niit.Models;

namespace Niit.Controllers
{
    [AllowAnonymous]
    public class RegsController : Controller
    {
        private kolkataEntities db = new kolkataEntities();

        // GET: Regs
        [Authorize(Roles ="a")]
        public ActionResult Index()
        {
            return View(db.Regs.ToList());
        }

        // GET: Regs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reg reg = db.Regs.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }

        // GET: Regs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegID,FullName,UserName,Password,ConfirmPassword,DateOFBirth,Gender,MobileNo,EmailID,Role")] Reg reg)
        {
            if (ModelState.IsValid)
            {
                db.Regs.Add(reg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reg);
        }

        // GET: Regs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reg reg = db.Regs.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }

        // POST: Regs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RegID,FullName,UserName,Password,ConfirmPassword,DateOFBirth,Gender,MobileNo,EmailID,Role")] Reg reg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reg);
        }

        // GET: Regs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reg reg = db.Regs.Find(id);
            if (reg == null)
            {
                return HttpNotFound();
            }
            return View(reg);
        }

        // POST: Regs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reg reg = db.Regs.Find(id);
            db.Regs.Remove(reg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
