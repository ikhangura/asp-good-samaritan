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
    public class HIVMedsModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: HIVMedsModels
        public async Task<ActionResult> Index()
        {
            return View(await db.HIVMedsModel.ToListAsync());
        }

        // GET: HIVMedsModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HIVMedsModel hIVMedsModel = await db.HIVMedsModel.FindAsync(id);
            if (hIVMedsModel == null)
            {
                return HttpNotFound();
            }
            return View(hIVMedsModel);
        }

        // GET: HIVMedsModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HIVMedsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "HIVMedsId,HIVMeds")] HIVMedsModel hIVMedsModel)
        {
            if (ModelState.IsValid)
            {
                db.HIVMedsModel.Add(hIVMedsModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(hIVMedsModel);
        }

        // GET: HIVMedsModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HIVMedsModel hIVMedsModel = await db.HIVMedsModel.FindAsync(id);
            if (hIVMedsModel == null)
            {
                return HttpNotFound();
            }
            return View(hIVMedsModel);
        }

        // POST: HIVMedsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "HIVMedsId,HIVMeds")] HIVMedsModel hIVMedsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hIVMedsModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hIVMedsModel);
        }

        // GET: HIVMedsModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HIVMedsModel hIVMedsModel = await db.HIVMedsModel.FindAsync(id);
            if (hIVMedsModel == null)
            {
                return HttpNotFound();
            }
            return View(hIVMedsModel);
        }

        // POST: HIVMedsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            HIVMedsModel hIVMedsModel = await db.HIVMedsModel.FindAsync(id);
            db.HIVMedsModel.Remove(hIVMedsModel);
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
