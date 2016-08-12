using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Schooldatabase.Models;

namespace Schooldatabase.Controllers
{
    public class ClassdetailsController : Controller
    {
        private MySchooldbEntities db = new MySchooldbEntities();

        // GET: /Classdetails/
        public ActionResult Index()
        {
            return View(db.ClassDetails.ToList());
        }

        // GET: /Classdetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassDetail classdetail = db.ClassDetails.Find(id);
            if (classdetail == null)
            {
                return HttpNotFound();
            }
            return View(classdetail);
        }

        // GET: /Classdetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Classdetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ClassName,Section,Total_Students")] ClassDetail classdetail)
        {
            if (ModelState.IsValid)
            {
                db.ClassDetails.Add(classdetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classdetail);
        }

        // GET: /Classdetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassDetail classdetail = db.ClassDetails.Find(id);
            if (classdetail == null)
            {
                return HttpNotFound();
            }
            return View(classdetail);
        }

        // POST: /Classdetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ClassName,Section,Total_Students")] ClassDetail classdetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classdetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classdetail);
        }

        // GET: /Classdetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassDetail classdetail = db.ClassDetails.Find(id);
            if (classdetail == null)
            {
                return HttpNotFound();
            }
            return View(classdetail);
        }

        // POST: /Classdetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClassDetail classdetail = db.ClassDetails.Find(id);
            db.ClassDetails.Remove(classdetail);
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
