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
    public class ServiceModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ServiceModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ServiceModel.ToListAsync());
        }

        // GET: ServiceModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceModel serviceModel = await db.ServiceModel.FindAsync(id);
            if (serviceModel == null)
            {
                return HttpNotFound();
            }
            return View(serviceModel);
        }

        // GET: ServiceModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ServiceId,Service")] ServiceModel serviceModel)
        {
            if (ModelState.IsValid)
            {
                db.ServiceModel.Add(serviceModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(serviceModel);
        }

        // GET: ServiceModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceModel serviceModel = await db.ServiceModel.FindAsync(id);
            if (serviceModel == null)
            {
                return HttpNotFound();
            }
            return View(serviceModel);
        }

        // POST: ServiceModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ServiceId,Service")] ServiceModel serviceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(serviceModel);
        }

        // GET: ServiceModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceModel serviceModel = await db.ServiceModel.FindAsync(id);
            if (serviceModel == null)
            {
                return HttpNotFound();
            }
            return View(serviceModel);
        }

        // POST: ServiceModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ServiceModel serviceModel = await db.ServiceModel.FindAsync(id);
            db.ServiceModel.Remove(serviceModel);
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
