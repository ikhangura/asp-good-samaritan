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
    public class IncidentModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: IncidentModels
        public async Task<ActionResult> Index()
        {
            return View(await db.IncidentModel.ToListAsync());
        }

        // GET: IncidentModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentModel incidentModel = await db.IncidentModel.FindAsync(id);
            if (incidentModel == null)
            {
                return HttpNotFound();
            }
            return View(incidentModel);
        }

        // GET: IncidentModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IncidentModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IncidentId,Incident")] IncidentModel incidentModel)
        {
            if (ModelState.IsValid)
            {
                db.IncidentModel.Add(incidentModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(incidentModel);
        }

        // GET: IncidentModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentModel incidentModel = await db.IncidentModel.FindAsync(id);
            if (incidentModel == null)
            {
                return HttpNotFound();
            }
            return View(incidentModel);
        }

        // POST: IncidentModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IncidentId,Incident")] IncidentModel incidentModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incidentModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(incidentModel);
        }

        // GET: IncidentModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentModel incidentModel = await db.IncidentModel.FindAsync(id);
            if (incidentModel == null)
            {
                return HttpNotFound();
            }
            return View(incidentModel);
        }

        // POST: IncidentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            IncidentModel incidentModel = await db.IncidentModel.FindAsync(id);
            db.IncidentModel.Remove(incidentModel);
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
