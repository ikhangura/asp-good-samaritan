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
    public class FamilyViolenceModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: FamilyViolenceModels
        public async Task<ActionResult> Index()
        {
            return View(await db.FamilyViolenceModel.ToListAsync());
        }

        // GET: FamilyViolenceModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceModel familyViolenceModel = await db.FamilyViolenceModel.FindAsync(id);
            if (familyViolenceModel == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceModel);
        }

        // GET: FamilyViolenceModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilyViolenceModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FamilyVolenceId,FamilyViolenceFile")] FamilyViolenceModel familyViolenceModel)
        {
            if (ModelState.IsValid)
            {
                db.FamilyViolenceModel.Add(familyViolenceModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(familyViolenceModel);
        }

        // GET: FamilyViolenceModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceModel familyViolenceModel = await db.FamilyViolenceModel.FindAsync(id);
            if (familyViolenceModel == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceModel);
        }

        // POST: FamilyViolenceModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FamilyVolenceId,FamilyViolenceFile")] FamilyViolenceModel familyViolenceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(familyViolenceModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(familyViolenceModel);
        }

        // GET: FamilyViolenceModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyViolenceModel familyViolenceModel = await db.FamilyViolenceModel.FindAsync(id);
            if (familyViolenceModel == null)
            {
                return HttpNotFound();
            }
            return View(familyViolenceModel);
        }

        // POST: FamilyViolenceModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FamilyViolenceModel familyViolenceModel = await db.FamilyViolenceModel.FindAsync(id);
            db.FamilyViolenceModel.Remove(familyViolenceModel);
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
