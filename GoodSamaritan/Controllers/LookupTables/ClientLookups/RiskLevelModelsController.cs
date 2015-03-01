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
    public class RiskLevelModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: RiskLevelModels
        public async Task<ActionResult> Index()
        {
            return View(await db.RiskLevelModel.ToListAsync());
        }

        // GET: RiskLevelModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevelModel riskLevelModel = await db.RiskLevelModel.FindAsync(id);
            if (riskLevelModel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevelModel);
        }

        // GET: RiskLevelModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskLevelModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RiskLevelId,RiskLevel")] RiskLevelModel riskLevelModel)
        {
            if (ModelState.IsValid)
            {
                db.RiskLevelModel.Add(riskLevelModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(riskLevelModel);
        }

        // GET: RiskLevelModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevelModel riskLevelModel = await db.RiskLevelModel.FindAsync(id);
            if (riskLevelModel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevelModel);
        }

        // POST: RiskLevelModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RiskLevelId,RiskLevel")] RiskLevelModel riskLevelModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskLevelModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(riskLevelModel);
        }

        // GET: RiskLevelModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskLevelModel riskLevelModel = await db.RiskLevelModel.FindAsync(id);
            if (riskLevelModel == null)
            {
                return HttpNotFound();
            }
            return View(riskLevelModel);
        }

        // POST: RiskLevelModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RiskLevelModel riskLevelModel = await db.RiskLevelModel.FindAsync(id);
            db.RiskLevelModel.Remove(riskLevelModel);
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
