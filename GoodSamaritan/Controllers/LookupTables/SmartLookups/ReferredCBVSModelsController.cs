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
    public class ReferredCBVSModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ReferredCBVSModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferredCBVSModel.ToListAsync());
        }

        // GET: ReferredCBVSModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredCBVSModel referredCBVSModel = await db.ReferredCBVSModel.FindAsync(id);
            if (referredCBVSModel == null)
            {
                return HttpNotFound();
            }
            return View(referredCBVSModel);
        }

        // GET: ReferredCBVSModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferredCBVSModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferralCBVSID,ReferredCBVS")] ReferredCBVSModel referredCBVSModel)
        {
            if (ModelState.IsValid)
            {
                db.ReferredCBVSModel.Add(referredCBVSModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referredCBVSModel);
        }

        // GET: ReferredCBVSModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredCBVSModel referredCBVSModel = await db.ReferredCBVSModel.FindAsync(id);
            if (referredCBVSModel == null)
            {
                return HttpNotFound();
            }
            return View(referredCBVSModel);
        }

        // POST: ReferredCBVSModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferralCBVSID,ReferredCBVS")] ReferredCBVSModel referredCBVSModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referredCBVSModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referredCBVSModel);
        }

        // GET: ReferredCBVSModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredCBVSModel referredCBVSModel = await db.ReferredCBVSModel.FindAsync(id);
            if (referredCBVSModel == null)
            {
                return HttpNotFound();
            }
            return View(referredCBVSModel);
        }

        // POST: ReferredCBVSModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferredCBVSModel referredCBVSModel = await db.ReferredCBVSModel.FindAsync(id);
            db.ReferredCBVSModel.Remove(referredCBVSModel);
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
