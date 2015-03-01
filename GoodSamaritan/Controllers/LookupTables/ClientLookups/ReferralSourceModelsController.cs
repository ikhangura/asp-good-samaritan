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
    public class ReferralSourceModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ReferralSourceModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferralSourceModel.ToListAsync());
        }

        // GET: ReferralSourceModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSourceModel referralSourceModel = await db.ReferralSourceModel.FindAsync(id);
            if (referralSourceModel == null)
            {
                return HttpNotFound();
            }
            return View(referralSourceModel);
        }

        // GET: ReferralSourceModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralSourceModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferralSourceId,ReferralSource")] ReferralSourceModel referralSourceModel)
        {
            if (ModelState.IsValid)
            {
                db.ReferralSourceModel.Add(referralSourceModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referralSourceModel);
        }

        // GET: ReferralSourceModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSourceModel referralSourceModel = await db.ReferralSourceModel.FindAsync(id);
            if (referralSourceModel == null)
            {
                return HttpNotFound();
            }
            return View(referralSourceModel);
        }

        // POST: ReferralSourceModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferralSourceId,ReferralSource")] ReferralSourceModel referralSourceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralSourceModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referralSourceModel);
        }

        // GET: ReferralSourceModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralSourceModel referralSourceModel = await db.ReferralSourceModel.FindAsync(id);
            if (referralSourceModel == null)
            {
                return HttpNotFound();
            }
            return View(referralSourceModel);
        }

        // POST: ReferralSourceModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferralSourceModel referralSourceModel = await db.ReferralSourceModel.FindAsync(id);
            db.ReferralSourceModel.Remove(referralSourceModel);
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
