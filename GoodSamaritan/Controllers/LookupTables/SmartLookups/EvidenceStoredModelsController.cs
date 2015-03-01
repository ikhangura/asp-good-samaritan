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
    public class EvidenceStoredModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: EvidenceStoredModels
        public async Task<ActionResult> Index()
        {
            return View(await db.EvidenceStoredModel.ToListAsync());
        }

        // GET: EvidenceStoredModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStoredModel evidenceStoredModel = await db.EvidenceStoredModel.FindAsync(id);
            if (evidenceStoredModel == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStoredModel);
        }

        // GET: EvidenceStoredModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EvidenceStoredModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EvidenceStoredId,EvidenceStored")] EvidenceStoredModel evidenceStoredModel)
        {
            if (ModelState.IsValid)
            {
                db.EvidenceStoredModel.Add(evidenceStoredModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(evidenceStoredModel);
        }

        // GET: EvidenceStoredModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStoredModel evidenceStoredModel = await db.EvidenceStoredModel.FindAsync(id);
            if (evidenceStoredModel == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStoredModel);
        }

        // POST: EvidenceStoredModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EvidenceStoredId,EvidenceStored")] EvidenceStoredModel evidenceStoredModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evidenceStoredModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(evidenceStoredModel);
        }

        // GET: EvidenceStoredModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvidenceStoredModel evidenceStoredModel = await db.EvidenceStoredModel.FindAsync(id);
            if (evidenceStoredModel == null)
            {
                return HttpNotFound();
            }
            return View(evidenceStoredModel);
        }

        // POST: EvidenceStoredModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            EvidenceStoredModel evidenceStoredModel = await db.EvidenceStoredModel.FindAsync(id);
            db.EvidenceStoredModel.Remove(evidenceStoredModel);
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
