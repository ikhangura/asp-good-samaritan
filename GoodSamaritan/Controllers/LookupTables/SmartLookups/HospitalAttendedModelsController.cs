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
    public class HospitalAttendedModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: HospitalAttendedModels
        public async Task<ActionResult> Index()
        {
            return View(await db.HospitalAttendedModel.ToListAsync());
        }

        // GET: HospitalAttendedModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttendedModel hospitalAttendedModel = await db.HospitalAttendedModel.FindAsync(id);
            if (hospitalAttendedModel == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttendedModel);
        }

        // GET: HospitalAttendedModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalAttendedModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "HospitalAttendedId,HospitalAttended")] HospitalAttendedModel hospitalAttendedModel)
        {
            if (ModelState.IsValid)
            {
                db.HospitalAttendedModel.Add(hospitalAttendedModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(hospitalAttendedModel);
        }

        // GET: HospitalAttendedModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttendedModel hospitalAttendedModel = await db.HospitalAttendedModel.FindAsync(id);
            if (hospitalAttendedModel == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttendedModel);
        }

        // POST: HospitalAttendedModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "HospitalAttendedId,HospitalAttended")] HospitalAttendedModel hospitalAttendedModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalAttendedModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hospitalAttendedModel);
        }

        // GET: HospitalAttendedModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttendedModel hospitalAttendedModel = await db.HospitalAttendedModel.FindAsync(id);
            if (hospitalAttendedModel == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttendedModel);
        }

        // POST: HospitalAttendedModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            HospitalAttendedModel hospitalAttendedModel = await db.HospitalAttendedModel.FindAsync(id);
            db.HospitalAttendedModel.Remove(hospitalAttendedModel);
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
