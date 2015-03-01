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
    public class CityOfResidenceModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: CityOfResidenceModels
        public async Task<ActionResult> Index()
        {
            return View(await db.CityOfResidenceModel.ToListAsync());
        }

        // GET: CityOfResidenceModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidenceModel cityOfResidenceModel = await db.CityOfResidenceModel.FindAsync(id);
            if (cityOfResidenceModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidenceModel);
        }

        // GET: CityOfResidenceModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfResidenceModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CityOfResidenceId,CityOfResidence")] CityOfResidenceModel cityOfResidenceModel)
        {
            if (ModelState.IsValid)
            {
                db.CityOfResidenceModel.Add(cityOfResidenceModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cityOfResidenceModel);
        }

        // GET: CityOfResidenceModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidenceModel cityOfResidenceModel = await db.CityOfResidenceModel.FindAsync(id);
            if (cityOfResidenceModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidenceModel);
        }

        // POST: CityOfResidenceModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CityOfResidenceId,CityOfResidence")] CityOfResidenceModel cityOfResidenceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfResidenceModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cityOfResidenceModel);
        }

        // GET: CityOfResidenceModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidenceModel cityOfResidenceModel = await db.CityOfResidenceModel.FindAsync(id);
            if (cityOfResidenceModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidenceModel);
        }

        // POST: CityOfResidenceModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CityOfResidenceModel cityOfResidenceModel = await db.CityOfResidenceModel.FindAsync(id);
            db.CityOfResidenceModel.Remove(cityOfResidenceModel);
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
