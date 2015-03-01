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
    public class MedicalOnlyModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: MedicalOnlyModels
        public async Task<ActionResult> Index()
        {
            return View(await db.MedicalOnlyModel.ToListAsync());
        }

        // GET: MedicalOnlyModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnlyModel medicalOnlyModel = await db.MedicalOnlyModel.FindAsync(id);
            if (medicalOnlyModel == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnlyModel);
        }

        // GET: MedicalOnlyModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalOnlyModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MedicalOnlyId,MedicalOnly")] MedicalOnlyModel medicalOnlyModel)
        {
            if (ModelState.IsValid)
            {
                db.MedicalOnlyModel.Add(medicalOnlyModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(medicalOnlyModel);
        }

        // GET: MedicalOnlyModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnlyModel medicalOnlyModel = await db.MedicalOnlyModel.FindAsync(id);
            if (medicalOnlyModel == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnlyModel);
        }

        // POST: MedicalOnlyModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MedicalOnlyId,MedicalOnly")] MedicalOnlyModel medicalOnlyModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalOnlyModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(medicalOnlyModel);
        }

        // GET: MedicalOnlyModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnlyModel medicalOnlyModel = await db.MedicalOnlyModel.FindAsync(id);
            if (medicalOnlyModel == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnlyModel);
        }

        // POST: MedicalOnlyModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MedicalOnlyModel medicalOnlyModel = await db.MedicalOnlyModel.FindAsync(id);
            db.MedicalOnlyModel.Remove(medicalOnlyModel);
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
