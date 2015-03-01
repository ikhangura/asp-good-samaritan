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
    public class AgeModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: AgeModels
        public async Task<ActionResult> Index()
        {
            return View(await db.AgeModel.ToListAsync());
        }

        // GET: AgeModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgeModel ageModel = await db.AgeModel.FindAsync(id);
            if (ageModel == null)
            {
                return HttpNotFound();
            }
            return View(ageModel);
        }

        // GET: AgeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AgeId,Age")] AgeModel ageModel)
        {
            if (ModelState.IsValid)
            {
                db.AgeModel.Add(ageModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ageModel);
        }

        // GET: AgeModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgeModel ageModel = await db.AgeModel.FindAsync(id);
            if (ageModel == null)
            {
                return HttpNotFound();
            }
            return View(ageModel);
        }

        // POST: AgeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AgeId,Age")] AgeModel ageModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ageModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ageModel);
        }

        // GET: AgeModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgeModel ageModel = await db.AgeModel.FindAsync(id);
            if (ageModel == null)
            {
                return HttpNotFound();
            }
            return View(ageModel);
        }

        // POST: AgeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AgeModel ageModel = await db.AgeModel.FindAsync(id);
            db.AgeModel.Remove(ageModel);
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
