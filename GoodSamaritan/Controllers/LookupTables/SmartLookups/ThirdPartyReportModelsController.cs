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
    public class ThirdPartyReportModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ThirdPartyReportModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ThirdPartyReportModel.ToListAsync());
        }

        // GET: ThirdPartyReportModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReportModel thirdPartyReportModel = await db.ThirdPartyReportModel.FindAsync(id);
            if (thirdPartyReportModel == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReportModel);
        }

        // GET: ThirdPartyReportModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThirdPartyReportModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ThirdPartyReportID,ThirdPartyReport")] ThirdPartyReportModel thirdPartyReportModel)
        {
            if (ModelState.IsValid)
            {
                db.ThirdPartyReportModel.Add(thirdPartyReportModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(thirdPartyReportModel);
        }

        // GET: ThirdPartyReportModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReportModel thirdPartyReportModel = await db.ThirdPartyReportModel.FindAsync(id);
            if (thirdPartyReportModel == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReportModel);
        }

        // POST: ThirdPartyReportModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ThirdPartyReportID,ThirdPartyReport")] ThirdPartyReportModel thirdPartyReportModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thirdPartyReportModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(thirdPartyReportModel);
        }

        // GET: ThirdPartyReportModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReportModel thirdPartyReportModel = await db.ThirdPartyReportModel.FindAsync(id);
            if (thirdPartyReportModel == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReportModel);
        }

        // POST: ThirdPartyReportModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ThirdPartyReportModel thirdPartyReportModel = await db.ThirdPartyReportModel.FindAsync(id);
            db.ThirdPartyReportModel.Remove(thirdPartyReportModel);
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
