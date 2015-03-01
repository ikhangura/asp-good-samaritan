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
    public class ReferralContactModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ReferralContactModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferralContactModel.ToListAsync());
        }

        // GET: ReferralContactModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContactModel referralContactModel = await db.ReferralContactModel.FindAsync(id);
            if (referralContactModel == null)
            {
                return HttpNotFound();
            }
            return View(referralContactModel);
        }

        // GET: ReferralContactModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralContactModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferralContactId,ReferralContact")] ReferralContactModel referralContactModel)
        {
            if (ModelState.IsValid)
            {
                db.ReferralContactModel.Add(referralContactModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referralContactModel);
        }

        // GET: ReferralContactModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContactModel referralContactModel = await db.ReferralContactModel.FindAsync(id);
            if (referralContactModel == null)
            {
                return HttpNotFound();
            }
            return View(referralContactModel);
        }

        // POST: ReferralContactModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferralContactId,ReferralContact")] ReferralContactModel referralContactModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralContactModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referralContactModel);
        }

        // GET: ReferralContactModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralContactModel referralContactModel = await db.ReferralContactModel.FindAsync(id);
            if (referralContactModel == null)
            {
                return HttpNotFound();
            }
            return View(referralContactModel);
        }

        // POST: ReferralContactModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferralContactModel referralContactModel = await db.ReferralContactModel.FindAsync(id);
            db.ReferralContactModel.Remove(referralContactModel);
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
