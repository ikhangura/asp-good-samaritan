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
    public class CityOfAssaultModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: CityOfAssaultModels
        public async Task<ActionResult> Index()
        {
            return View(await db.CityOfAssaultModel.ToListAsync());
        }

        // GET: CityOfAssaultModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssaultModel cityOfAssaultModel = await db.CityOfAssaultModel.FindAsync(id);
            if (cityOfAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssaultModel);
        }

        // GET: CityOfAssaultModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfAssaultModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CityOfAssaultId,CityOfAssault")] CityOfAssaultModel cityOfAssaultModel)
        {
            if (ModelState.IsValid)
            {
                db.CityOfAssaultModel.Add(cityOfAssaultModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cityOfAssaultModel);
        }

        // GET: CityOfAssaultModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssaultModel cityOfAssaultModel = await db.CityOfAssaultModel.FindAsync(id);
            if (cityOfAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssaultModel);
        }

        // POST: CityOfAssaultModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CityOfAssaultId,CityOfAssault")] CityOfAssaultModel cityOfAssaultModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfAssaultModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cityOfAssaultModel);
        }

        // GET: CityOfAssaultModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfAssaultModel cityOfAssaultModel = await db.CityOfAssaultModel.FindAsync(id);
            if (cityOfAssaultModel == null)
            {
                return HttpNotFound();
            }
            return View(cityOfAssaultModel);
        }

        // POST: CityOfAssaultModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CityOfAssaultModel cityOfAssaultModel = await db.CityOfAssaultModel.FindAsync(id);
            db.CityOfAssaultModel.Remove(cityOfAssaultModel);
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
