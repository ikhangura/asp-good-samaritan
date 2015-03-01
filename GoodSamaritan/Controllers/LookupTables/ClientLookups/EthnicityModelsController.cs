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
    public class EthnicityModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: EthnicityModels
        public async Task<ActionResult> Index()
        {
            return View(await db.EthnicityModel.ToListAsync());
        }

        // GET: EthnicityModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EthnicityModel ethnicityModel = await db.EthnicityModel.FindAsync(id);
            if (ethnicityModel == null)
            {
                return HttpNotFound();
            }
            return View(ethnicityModel);
        }

        // GET: EthnicityModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EthnicityModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EthnicityId,Ethnicity")] EthnicityModel ethnicityModel)
        {
            if (ModelState.IsValid)
            {
                db.EthnicityModel.Add(ethnicityModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ethnicityModel);
        }

        // GET: EthnicityModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EthnicityModel ethnicityModel = await db.EthnicityModel.FindAsync(id);
            if (ethnicityModel == null)
            {
                return HttpNotFound();
            }
            return View(ethnicityModel);
        }

        // POST: EthnicityModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EthnicityId,Ethnicity")] EthnicityModel ethnicityModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ethnicityModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ethnicityModel);
        }

        // GET: EthnicityModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EthnicityModel ethnicityModel = await db.EthnicityModel.FindAsync(id);
            if (ethnicityModel == null)
            {
                return HttpNotFound();
            }
            return View(ethnicityModel);
        }

        // POST: EthnicityModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            EthnicityModel ethnicityModel = await db.EthnicityModel.FindAsync(id);
            db.EthnicityModel.Remove(ethnicityModel);
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
