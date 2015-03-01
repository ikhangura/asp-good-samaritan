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
    public class AbuserRelationshipModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: AbuserRelationshipModels
        public async Task<ActionResult> Index()
        {
            return View(await db.AbuserRelationshipModel.ToListAsync());
        }

        // GET: AbuserRelationshipModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationshipModel abuserRelationshipModel = await db.AbuserRelationshipModel.FindAsync(id);
            if (abuserRelationshipModel == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationshipModel);
        }

        // GET: AbuserRelationshipModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbuserRelationshipModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AbuserRelationShipId,AbuserRelationship")] AbuserRelationshipModel abuserRelationshipModel)
        {
            if (ModelState.IsValid)
            {
                db.AbuserRelationshipModel.Add(abuserRelationshipModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(abuserRelationshipModel);
        }

        // GET: AbuserRelationshipModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationshipModel abuserRelationshipModel = await db.AbuserRelationshipModel.FindAsync(id);
            if (abuserRelationshipModel == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationshipModel);
        }

        // POST: AbuserRelationshipModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AbuserRelationShipId,AbuserRelationship")] AbuserRelationshipModel abuserRelationshipModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abuserRelationshipModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(abuserRelationshipModel);
        }

        // GET: AbuserRelationshipModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AbuserRelationshipModel abuserRelationshipModel = await db.AbuserRelationshipModel.FindAsync(id);
            if (abuserRelationshipModel == null)
            {
                return HttpNotFound();
            }
            return View(abuserRelationshipModel);
        }

        // POST: AbuserRelationshipModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AbuserRelationshipModel abuserRelationshipModel = await db.AbuserRelationshipModel.FindAsync(id);
            db.AbuserRelationshipModel.Remove(abuserRelationshipModel);
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
