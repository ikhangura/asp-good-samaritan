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
    public class StatusOfFileModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: StatusOfFileModels
        public async Task<ActionResult> Index()
        {
            return View(await db.StatusOfFileModel.ToListAsync());
        }

        // GET: StatusOfFileModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFileModel statusOfFileModel = await db.StatusOfFileModel.FindAsync(id);
            if (statusOfFileModel == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFileModel);
        }

        // GET: StatusOfFileModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusOfFileModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StatusOfFileId,StatusOfFile")] StatusOfFileModel statusOfFileModel)
        {
            if (ModelState.IsValid)
            {
                db.StatusOfFileModel.Add(statusOfFileModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(statusOfFileModel);
        }

        // GET: StatusOfFileModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFileModel statusOfFileModel = await db.StatusOfFileModel.FindAsync(id);
            if (statusOfFileModel == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFileModel);
        }

        // POST: StatusOfFileModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StatusOfFileId,StatusOfFile")] StatusOfFileModel statusOfFileModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusOfFileModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(statusOfFileModel);
        }

        // GET: StatusOfFileModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFileModel statusOfFileModel = await db.StatusOfFileModel.FindAsync(id);
            if (statusOfFileModel == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFileModel);
        }

        // POST: StatusOfFileModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StatusOfFileModel statusOfFileModel = await db.StatusOfFileModel.FindAsync(id);
            db.StatusOfFileModel.Remove(statusOfFileModel);
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
