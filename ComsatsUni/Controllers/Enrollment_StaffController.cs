using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ComsatsUni.DAL;
using ComsatsUni.Models;

namespace ComsatsUni.Controllers
{
    public class Enrollment_StaffController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Enrollment_Staff
        public ActionResult Index()
        {
            var enrollment_Staffs = db.Enrollment_Staffs.Include(e => e.Department).Include(e => e.Instructor);
            return View(enrollment_Staffs.ToList());
        }

        // GET: Enrollment_Staff/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment_Staff enrollment_Staff = db.Enrollment_Staffs.Find(id);
            if (enrollment_Staff == null)
            {
                return HttpNotFound();
            }
            return View(enrollment_Staff);
        }

        // GET: Enrollment_Staff/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Title");
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "LastName");
            return View();
        }

        // POST: Enrollment_Staff/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Enrollment_StaffID,DepartmentID,InstructorID,Staff_Title")] Enrollment_Staff enrollment_Staff)
        {
            if (ModelState.IsValid)
            {
                db.Enrollment_Staffs.Add(enrollment_Staff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Title", enrollment_Staff.DepartmentID);
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "LastName", enrollment_Staff.InstructorID);
            return View(enrollment_Staff);
        }

        // GET: Enrollment_Staff/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment_Staff enrollment_Staff = db.Enrollment_Staffs.Find(id);
            if (enrollment_Staff == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Title", enrollment_Staff.DepartmentID);
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "LastName", enrollment_Staff.InstructorID);
            return View(enrollment_Staff);
        }

        // POST: Enrollment_Staff/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Enrollment_StaffID,DepartmentID,InstructorID,Staff_Title")] Enrollment_Staff enrollment_Staff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollment_Staff).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "Title", enrollment_Staff.DepartmentID);
            ViewBag.InstructorID = new SelectList(db.Instructors, "InstructorID", "LastName", enrollment_Staff.InstructorID);
            return View(enrollment_Staff);
        }

        // GET: Enrollment_Staff/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment_Staff enrollment_Staff = db.Enrollment_Staffs.Find(id);
            if (enrollment_Staff == null)
            {
                return HttpNotFound();
            }
            return View(enrollment_Staff);
        }

        // POST: Enrollment_Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enrollment_Staff enrollment_Staff = db.Enrollment_Staffs.Find(id);
            db.Enrollment_Staffs.Remove(enrollment_Staff);
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
