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
    public class RiskStatusModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: RiskStatusModels
        public async Task<ActionResult> Index()
        {
            return View(await db.RiskStatusModel.ToListAsync());
        }

        // GET: RiskStatusModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatusModel riskStatusModel = await db.RiskStatusModel.FindAsync(id);
            if (riskStatusModel == null)
            {
                return HttpNotFound();
            }
            return View(riskStatusModel);
        }

        // GET: RiskStatusModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiskStatusModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RiskStatusId,RiskStatus")] RiskStatusModel riskStatusModel)
        {
            if (ModelState.IsValid)
            {
                db.RiskStatusModel.Add(riskStatusModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(riskStatusModel);
        }

        // GET: RiskStatusModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatusModel riskStatusModel = await db.RiskStatusModel.FindAsync(id);
            if (riskStatusModel == null)
            {
                return HttpNotFound();
            }
            return View(riskStatusModel);
        }

        // POST: RiskStatusModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RiskStatusId,RiskStatus")] RiskStatusModel riskStatusModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riskStatusModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(riskStatusModel);
        }

        // GET: RiskStatusModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiskStatusModel riskStatusModel = await db.RiskStatusModel.FindAsync(id);
            if (riskStatusModel == null)
            {
                return HttpNotFound();
            }
            return View(riskStatusModel);
        }

        // POST: RiskStatusModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RiskStatusModel riskStatusModel = await db.RiskStatusModel.FindAsync(id);
            db.RiskStatusModel.Remove(riskStatusModel);
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
