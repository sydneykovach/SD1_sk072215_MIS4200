using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SD1_sk072215_MIS4200.DAL;
using SD1_sk072215_MIS4200.Models;

namespace SD1_sk072215_MIS4200.Controllers
{
    public class AppointmentDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: AppointmentDetails
        public ActionResult Index()
        {
            var appointmentDetails = db.AppointmentDetails.Include(a => a.Appointment).Include(a => a.Procedure);
            return View(appointmentDetails.ToList());
        }

        // GET: AppointmentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // GET: AppointmentDetails/Create
        public ActionResult Create()
        {
            ViewBag.AppointmentID = new SelectList(db.Appointments, "appointmentID", "description");
            ViewBag.procedureId = new SelectList(db.Procedures, "procedureID", "description");
            return View();
        }

        // POST: AppointmentDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointmentDetailID,qtyProcedure,price,AppointmentID,procedureId")] AppointmentDetail appointmentDetail)
        {
            if (ModelState.IsValid)
            {
                db.AppointmentDetails.Add(appointmentDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AppointmentID = new SelectList(db.Appointments, "appointmentID", "description", appointmentDetail.AppointmentID);
            ViewBag.procedureId = new SelectList(db.Procedures, "procedureID", "description", appointmentDetail.procedureId);
            return View(appointmentDetail);
        }

        // GET: AppointmentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.AppointmentID = new SelectList(db.Appointments, "appointmentID", "description", appointmentDetail.AppointmentID);
            ViewBag.procedureId = new SelectList(db.Procedures, "procedureID", "description", appointmentDetail.procedureId);
            return View(appointmentDetail);
        }

        // POST: AppointmentDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointmentDetailID,qtyProcedure,price,AppointmentID,procedureId")] AppointmentDetail appointmentDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointmentDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AppointmentID = new SelectList(db.Appointments, "appointmentID", "description", appointmentDetail.AppointmentID);
            ViewBag.procedureId = new SelectList(db.Procedures, "procedureID", "description", appointmentDetail.procedureId);
            return View(appointmentDetail);
        }

        // GET: AppointmentDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // POST: AppointmentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            db.AppointmentDetails.Remove(appointmentDetail);
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
