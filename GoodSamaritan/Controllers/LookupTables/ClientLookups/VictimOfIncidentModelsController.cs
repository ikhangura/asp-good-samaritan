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
    public class VictimOfIncidentModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: VictimOfIncidentModels
        public async Task<ActionResult> Index()
        {
            return View(await db.VictimOfIncidentModel.ToListAsync());
        }

        // GET: VictimOfIncidentModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncidentModel victimOfIncidentModel = await db.VictimOfIncidentModel.FindAsync(id);
            if (victimOfIncidentModel == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncidentModel);
        }

        // GET: VictimOfIncidentModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VictimOfIncidentModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "VictimOFIncidentId,VictimOfIncident")] VictimOfIncidentModel victimOfIncidentModel)
        {
            if (ModelState.IsValid)
            {
                db.VictimOfIncidentModel.Add(victimOfIncidentModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(victimOfIncidentModel);
        }

        // GET: VictimOfIncidentModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncidentModel victimOfIncidentModel = await db.VictimOfIncidentModel.FindAsync(id);
            if (victimOfIncidentModel == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncidentModel);
        }

        // POST: VictimOfIncidentModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "VictimOFIncidentId,VictimOfIncident")] VictimOfIncidentModel victimOfIncidentModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victimOfIncidentModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(victimOfIncidentModel);
        }

        // GET: VictimOfIncidentModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncidentModel victimOfIncidentModel = await db.VictimOfIncidentModel.FindAsync(id);
            if (victimOfIncidentModel == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncidentModel);
        }

        // POST: VictimOfIncidentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            VictimOfIncidentModel victimOfIncidentModel = await db.VictimOfIncidentModel.FindAsync(id);
            db.VictimOfIncidentModel.Remove(victimOfIncidentModel);
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
