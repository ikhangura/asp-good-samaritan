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
    public class AssignedWorkerModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: AssignedWorkerModels
        public async Task<ActionResult> Index()
        {
            return View(await db.AssignedWorkerModel.ToListAsync());
        }

        // GET: AssignedWorkerModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorkerModel assignedWorkerModel = await db.AssignedWorkerModel.FindAsync(id);
            if (assignedWorkerModel == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorkerModel);
        }

        // GET: AssignedWorkerModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssignedWorkerModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AssignedWorkerId,AssignedWorker")] AssignedWorkerModel assignedWorkerModel)
        {
            if (ModelState.IsValid)
            {
                db.AssignedWorkerModel.Add(assignedWorkerModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(assignedWorkerModel);
        }

        // GET: AssignedWorkerModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorkerModel assignedWorkerModel = await db.AssignedWorkerModel.FindAsync(id);
            if (assignedWorkerModel == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorkerModel);
        }

        // POST: AssignedWorkerModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AssignedWorkerId,AssignedWorker")] AssignedWorkerModel assignedWorkerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignedWorkerModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(assignedWorkerModel);
        }

        // GET: AssignedWorkerModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignedWorkerModel assignedWorkerModel = await db.AssignedWorkerModel.FindAsync(id);
            if (assignedWorkerModel == null)
            {
                return HttpNotFound();
            }
            return View(assignedWorkerModel);
        }

        // POST: AssignedWorkerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AssignedWorkerModel assignedWorkerModel = await db.AssignedWorkerModel.FindAsync(id);
            db.AssignedWorkerModel.Remove(assignedWorkerModel);
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
