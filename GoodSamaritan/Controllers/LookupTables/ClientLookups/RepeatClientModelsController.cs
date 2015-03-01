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
    public class RepeatClientModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: RepeatClientModels
        public async Task<ActionResult> Index()
        {
            return View(await db.RepeatClientModel.ToListAsync());
        }

        // GET: RepeatClientModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClientModel repeatClientModel = await db.RepeatClientModel.FindAsync(id);
            if (repeatClientModel == null)
            {
                return HttpNotFound();
            }
            return View(repeatClientModel);
        }

        // GET: RepeatClientModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RepeatClientModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RepeatClientId,RepeatClient")] RepeatClientModel repeatClientModel)
        {
            if (ModelState.IsValid)
            {
                db.RepeatClientModel.Add(repeatClientModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(repeatClientModel);
        }

        // GET: RepeatClientModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClientModel repeatClientModel = await db.RepeatClientModel.FindAsync(id);
            if (repeatClientModel == null)
            {
                return HttpNotFound();
            }
            return View(repeatClientModel);
        }

        // POST: RepeatClientModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RepeatClientId,RepeatClient")] RepeatClientModel repeatClientModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repeatClientModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(repeatClientModel);
        }

        // GET: RepeatClientModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepeatClientModel repeatClientModel = await db.RepeatClientModel.FindAsync(id);
            if (repeatClientModel == null)
            {
                return HttpNotFound();
            }
            return View(repeatClientModel);
        }

        // POST: RepeatClientModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RepeatClientModel repeatClientModel = await db.RepeatClientModel.FindAsync(id);
            db.RepeatClientModel.Remove(repeatClientModel);
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
