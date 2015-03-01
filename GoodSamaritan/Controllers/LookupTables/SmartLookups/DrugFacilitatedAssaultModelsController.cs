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
    public class DrugFacilitatedAssaultModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: DrugFacilitatedAssaultModels
        public async Task<ActionResult> Index()
        {
            return View(await db.DrugFacilitatedAssaultModel.ToListAsync());
        }

        // GET: DrugFacilitatedAssaultModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssaultModel drugFacilitatedAssaultModel = await db.DrugFacilitatedAssaultModel.FindAsync(id);
            if (drugFacilitatedAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssaultModel);
        }

        // GET: DrugFacilitatedAssaultModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrugFacilitatedAssaultModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DrugFacilitatedAssaultId,DrugFacilitatedAssault")] DrugFacilitatedAssaultModel drugFacilitatedAssaultModel)
        {
            if (ModelState.IsValid)
            {
                db.DrugFacilitatedAssaultModel.Add(drugFacilitatedAssaultModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(drugFacilitatedAssaultModel);
        }

        // GET: DrugFacilitatedAssaultModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssaultModel drugFacilitatedAssaultModel = await db.DrugFacilitatedAssaultModel.FindAsync(id);
            if (drugFacilitatedAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssaultModel);
        }

        // POST: DrugFacilitatedAssaultModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DrugFacilitatedAssaultId,DrugFacilitatedAssault")] DrugFacilitatedAssaultModel drugFacilitatedAssaultModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drugFacilitatedAssaultModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(drugFacilitatedAssaultModel);
        }

        // GET: DrugFacilitatedAssaultModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitatedAssaultModel drugFacilitatedAssaultModel = await db.DrugFacilitatedAssaultModel.FindAsync(id);
            if (drugFacilitatedAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitatedAssaultModel);
        }

        // POST: DrugFacilitatedAssaultModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DrugFacilitatedAssaultModel drugFacilitatedAssaultModel = await db.DrugFacilitatedAssaultModel.FindAsync(id);
            db.DrugFacilitatedAssaultModel.Remove(drugFacilitatedAssaultModel);
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
