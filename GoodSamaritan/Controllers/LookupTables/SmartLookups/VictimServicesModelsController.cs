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
    public class VictimServicesModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: VictimServicesModels
        public async Task<ActionResult> Index()
        {
            return View(await db.VictimServicesModel.ToListAsync());
        }

        // GET: VictimServicesModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesModel victimServicesModel = await db.VictimServicesModel.FindAsync(id);
            if (victimServicesModel == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesModel);
        }

        // GET: VictimServicesModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VictimServicesModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "VictimServicesID,VictimServices")] VictimServicesModel victimServicesModel)
        {
            if (ModelState.IsValid)
            {
                db.VictimServicesModel.Add(victimServicesModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(victimServicesModel);
        }

        // GET: VictimServicesModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesModel victimServicesModel = await db.VictimServicesModel.FindAsync(id);
            if (victimServicesModel == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesModel);
        }

        // POST: VictimServicesModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "VictimServicesID,VictimServices")] VictimServicesModel victimServicesModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victimServicesModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(victimServicesModel);
        }

        // GET: VictimServicesModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesModel victimServicesModel = await db.VictimServicesModel.FindAsync(id);
            if (victimServicesModel == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesModel);
        }

        // POST: VictimServicesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            VictimServicesModel victimServicesModel = await db.VictimServicesModel.FindAsync(id);
            db.VictimServicesModel.Remove(victimServicesModel);
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
