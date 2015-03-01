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
    public class MultiplePerpetratorsModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: MultiplePerpetratorsModels
        public async Task<ActionResult> Index()
        {
            return View(await db.MultiplePerpetratorsModel.ToListAsync());
        }

        // GET: MultiplePerpetratorsModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetratorsModel multiplePerpetratorsModel = await db.MultiplePerpetratorsModel.FindAsync(id);
            if (multiplePerpetratorsModel == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetratorsModel);
        }

        // GET: MultiplePerpetratorsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultiplePerpetratorsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MultiplePerpetratorsID,MultiplePerpetrators")] MultiplePerpetratorsModel multiplePerpetratorsModel)
        {
            if (ModelState.IsValid)
            {
                db.MultiplePerpetratorsModel.Add(multiplePerpetratorsModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(multiplePerpetratorsModel);
        }

        // GET: MultiplePerpetratorsModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetratorsModel multiplePerpetratorsModel = await db.MultiplePerpetratorsModel.FindAsync(id);
            if (multiplePerpetratorsModel == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetratorsModel);
        }

        // POST: MultiplePerpetratorsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MultiplePerpetratorsID,MultiplePerpetrators")] MultiplePerpetratorsModel multiplePerpetratorsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(multiplePerpetratorsModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(multiplePerpetratorsModel);
        }

        // GET: MultiplePerpetratorsModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerpetratorsModel multiplePerpetratorsModel = await db.MultiplePerpetratorsModel.FindAsync(id);
            if (multiplePerpetratorsModel == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerpetratorsModel);
        }

        // POST: MultiplePerpetratorsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MultiplePerpetratorsModel multiplePerpetratorsModel = await db.MultiplePerpetratorsModel.FindAsync(id);
            db.MultiplePerpetratorsModel.Remove(multiplePerpetratorsModel);
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
