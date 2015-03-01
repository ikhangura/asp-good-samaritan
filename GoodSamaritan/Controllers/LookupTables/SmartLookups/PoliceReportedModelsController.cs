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
    public class PoliceReportedModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: PoliceReportedModels
        public async Task<ActionResult> Index()
        {
            return View(await db.PoliceReportedModel.ToListAsync());
        }

        // GET: PoliceReportedModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReportedModel policeReportedModel = await db.PoliceReportedModel.FindAsync(id);
            if (policeReportedModel == null)
            {
                return HttpNotFound();
            }
            return View(policeReportedModel);
        }

        // GET: PoliceReportedModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceReportedModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PoliceReportedId,PolicReported")] PoliceReportedModel policeReportedModel)
        {
            if (ModelState.IsValid)
            {
                db.PoliceReportedModel.Add(policeReportedModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(policeReportedModel);
        }

        // GET: PoliceReportedModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReportedModel policeReportedModel = await db.PoliceReportedModel.FindAsync(id);
            if (policeReportedModel == null)
            {
                return HttpNotFound();
            }
            return View(policeReportedModel);
        }

        // POST: PoliceReportedModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PoliceReportedId,PolicReported")] PoliceReportedModel policeReportedModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeReportedModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(policeReportedModel);
        }

        // GET: PoliceReportedModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceReportedModel policeReportedModel = await db.PoliceReportedModel.FindAsync(id);
            if (policeReportedModel == null)
            {
                return HttpNotFound();
            }
            return View(policeReportedModel);
        }

        // POST: PoliceReportedModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PoliceReportedModel policeReportedModel = await db.PoliceReportedModel.FindAsync(id);
            db.PoliceReportedModel.Remove(policeReportedModel);
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
