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
    public class BadDateReportModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: BadDateReportModels
        public async Task<ActionResult> Index()
        {
            return View(await db.BadDateReportModel.ToListAsync());
        }

        // GET: BadDateReportModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReportModel badDateReportModel = await db.BadDateReportModel.FindAsync(id);
            if (badDateReportModel == null)
            {
                return HttpNotFound();
            }
            return View(badDateReportModel);
        }

        // GET: BadDateReportModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BadDateReportModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BadDateReportId,BadDateReport")] BadDateReportModel badDateReportModel)
        {
            if (ModelState.IsValid)
            {
                db.BadDateReportModel.Add(badDateReportModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(badDateReportModel);
        }

        // GET: BadDateReportModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReportModel badDateReportModel = await db.BadDateReportModel.FindAsync(id);
            if (badDateReportModel == null)
            {
                return HttpNotFound();
            }
            return View(badDateReportModel);
        }

        // POST: BadDateReportModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BadDateReportId,BadDateReport")] BadDateReportModel badDateReportModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(badDateReportModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(badDateReportModel);
        }

        // GET: BadDateReportModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReportModel badDateReportModel = await db.BadDateReportModel.FindAsync(id);
            if (badDateReportModel == null)
            {
                return HttpNotFound();
            }
            return View(badDateReportModel);
        }

        // POST: BadDateReportModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            BadDateReportModel badDateReportModel = await db.BadDateReportModel.FindAsync(id);
            db.BadDateReportModel.Remove(badDateReportModel);
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
