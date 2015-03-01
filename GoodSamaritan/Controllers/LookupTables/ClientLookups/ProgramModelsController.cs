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
    public class ProgramModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ProgramModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ProgramModel.ToListAsync());
        }

        // GET: ProgramModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramModel programModel = await db.ProgramModel.FindAsync(id);
            if (programModel == null)
            {
                return HttpNotFound();
            }
            return View(programModel);
        }

        // GET: ProgramModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProgramModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProgramId,Program")] ProgramModel programModel)
        {
            if (ModelState.IsValid)
            {
                db.ProgramModel.Add(programModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(programModel);
        }

        // GET: ProgramModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramModel programModel = await db.ProgramModel.FindAsync(id);
            if (programModel == null)
            {
                return HttpNotFound();
            }
            return View(programModel);
        }

        // POST: ProgramModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProgramId,Program")] ProgramModel programModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(programModel);
        }

        // GET: ProgramModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramModel programModel = await db.ProgramModel.FindAsync(id);
            if (programModel == null)
            {
                return HttpNotFound();
            }
            return View(programModel);
        }

        // POST: ProgramModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ProgramModel programModel = await db.ProgramModel.FindAsync(id);
            db.ProgramModel.Remove(programModel);
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
