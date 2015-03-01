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
    public class CrisisModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: CrisisModels
        public async Task<ActionResult> Index()
        {
            return View(await db.CrisisModel.ToListAsync());
        }

        // GET: CrisisModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrisisModel crisisModel = await db.CrisisModel.FindAsync(id);
            if (crisisModel == null)
            {
                return HttpNotFound();
            }
            return View(crisisModel);
        }

        // GET: CrisisModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CrisisModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CrisisId,Crisis")] CrisisModel crisisModel)
        {
            if (ModelState.IsValid)
            {
                db.CrisisModel.Add(crisisModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(crisisModel);
        }

        // GET: CrisisModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrisisModel crisisModel = await db.CrisisModel.FindAsync(id);
            if (crisisModel == null)
            {
                return HttpNotFound();
            }
            return View(crisisModel);
        }

        // POST: CrisisModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CrisisId,Crisis")] CrisisModel crisisModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crisisModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(crisisModel);
        }

        // GET: CrisisModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrisisModel crisisModel = await db.CrisisModel.FindAsync(id);
            if (crisisModel == null)
            {
                return HttpNotFound();
            }
            return View(crisisModel);
        }

        // POST: CrisisModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CrisisModel crisisModel = await db.CrisisModel.FindAsync(id);
            db.CrisisModel.Remove(crisisModel);
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
