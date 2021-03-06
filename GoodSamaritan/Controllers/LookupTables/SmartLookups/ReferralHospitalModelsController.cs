﻿using System;
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
    public class ReferralHospitalModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ReferralHospitalModels
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferralHospitalModel.ToListAsync());
        }

        // GET: ReferralHospitalModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralHospitalModel referralHospitalModel = await db.ReferralHospitalModel.FindAsync(id);
            if (referralHospitalModel == null)
            {
                return HttpNotFound();
            }
            return View(referralHospitalModel);
        }

        // GET: ReferralHospitalModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferralHospitalModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferralHospitalID,ReferralHospital")] ReferralHospitalModel referralHospitalModel)
        {
            if (ModelState.IsValid)
            {
                db.ReferralHospitalModel.Add(referralHospitalModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referralHospitalModel);
        }

        // GET: ReferralHospitalModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralHospitalModel referralHospitalModel = await db.ReferralHospitalModel.FindAsync(id);
            if (referralHospitalModel == null)
            {
                return HttpNotFound();
            }
            return View(referralHospitalModel);
        }

        // POST: ReferralHospitalModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferralHospitalID,ReferralHospital")] ReferralHospitalModel referralHospitalModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referralHospitalModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referralHospitalModel);
        }

        // GET: ReferralHospitalModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferralHospitalModel referralHospitalModel = await db.ReferralHospitalModel.FindAsync(id);
            if (referralHospitalModel == null)
            {
                return HttpNotFound();
            }
            return View(referralHospitalModel);
        }

        // POST: ReferralHospitalModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferralHospitalModel referralHospitalModel = await db.ReferralHospitalModel.FindAsync(id);
            db.ReferralHospitalModel.Remove(referralHospitalModel);
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
