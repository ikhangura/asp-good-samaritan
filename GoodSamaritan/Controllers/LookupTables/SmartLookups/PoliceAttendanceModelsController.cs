using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;
using GoodSamaritan.Models.LookupTables;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class PoliceAttendanceModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: PoliceAttendanceModels
        public async Task<ActionResult> Index()
        {
            return View(await db.PoliceAttendanceModel.ToListAsync());
        }

        // GET: PoliceAttendanceModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendanceModel policeAttendanceModel = await db.PoliceAttendanceModel.FindAsync(id);
            if (policeAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendanceModel);
        }

        // GET: PoliceAttendanceModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceAttendanceModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PoliceAttendanceId,PolicAttendance")] PoliceAttendanceModel policeAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.PoliceAttendanceModel.Add(policeAttendanceModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(policeAttendanceModel);
        }

        // GET: PoliceAttendanceModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendanceModel policeAttendanceModel = await db.PoliceAttendanceModel.FindAsync(id);
            if (policeAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendanceModel);
        }

        // POST: PoliceAttendanceModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PoliceAttendanceId,PolicAttendance")] PoliceAttendanceModel policeAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeAttendanceModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(policeAttendanceModel);
        }

        // GET: PoliceAttendanceModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendanceModel policeAttendanceModel = await db.PoliceAttendanceModel.FindAsync(id);
            if (policeAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendanceModel);
        }

        // POST: PoliceAttendanceModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PoliceAttendanceModel policeAttendanceModel = await db.PoliceAttendanceModel.FindAsync(id);
            db.PoliceAttendanceModel.Remove(policeAttendanceModel);
            await db.SaveChangesAsync();
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
