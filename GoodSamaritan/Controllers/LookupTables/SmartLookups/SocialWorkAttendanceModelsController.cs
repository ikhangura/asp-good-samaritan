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
    public class SocialWorkAttendanceModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: SocialWorkAttendanceModels
        public async Task<ActionResult> Index()
        {
            return View(await db.SocialWorkAttendanceModel.ToListAsync());
        }

        // GET: SocialWorkAttendanceModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendanceModel socialWorkAttendanceModel = await db.SocialWorkAttendanceModel.FindAsync(id);
            if (socialWorkAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendanceModel);
        }

        // GET: SocialWorkAttendanceModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialWorkAttendanceModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SocalWorkAttendanceId,SocialWorkAttendance")] SocialWorkAttendanceModel socialWorkAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.SocialWorkAttendanceModel.Add(socialWorkAttendanceModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(socialWorkAttendanceModel);
        }

        // GET: SocialWorkAttendanceModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendanceModel socialWorkAttendanceModel = await db.SocialWorkAttendanceModel.FindAsync(id);
            if (socialWorkAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendanceModel);
        }

        // POST: SocialWorkAttendanceModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SocalWorkAttendanceId,SocialWorkAttendance")] SocialWorkAttendanceModel socialWorkAttendanceModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socialWorkAttendanceModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(socialWorkAttendanceModel);
        }

        // GET: SocialWorkAttendanceModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendanceModel socialWorkAttendanceModel = await db.SocialWorkAttendanceModel.FindAsync(id);
            if (socialWorkAttendanceModel == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendanceModel);
        }

        // POST: SocialWorkAttendanceModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SocialWorkAttendanceModel socialWorkAttendanceModel = await db.SocialWorkAttendanceModel.FindAsync(id);
            db.SocialWorkAttendanceModel.Remove(socialWorkAttendanceModel);
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
