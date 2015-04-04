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

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles="Administrator, Worker")]
    public class SmartModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: SmartModels
        public async Task<ActionResult> Index()
        {
            var smartModel = db.SmartModel.Include(s => s.BadDateReport).Include(s => s.CityOfAssault).Include(s => s.CityOfResidence).Include(s => s.DrugFaciliatedAssault).Include(s => s.EvidenceStored).Include(s => s.HIVMeds).Include(s => s.HospitalAttended).Include(s => s.MedicalOnly).Include(s => s.MultiplePerpetrators).Include(s => s.PoliceAttendance).Include(s => s.PoliceReported).Include(s => s.ReferralHospital).Include(s => s.ReferredToCBVS).Include(s => s.SocialWorkAttendance).Include(s => s.ThirdPartyReport).Include(s => s.VictimServices).Include(s => s.WorkExploitation);
            return View(await smartModel.ToListAsync());
        }

        // GET: SmartModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmartModel smartModel = await db.SmartModel.FindAsync(id);
            if (smartModel == null)
            {
                return HttpNotFound();
            }
            return View(smartModel);
        }

        // GET: SmartModels/Create
        private ActionResult Create()
        {
            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReport", "BadDateReport");
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssault", "CityOfAssault");
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidence", "CityOfResidence");
            ViewBag.DrugFaciliatedAssaultID = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssault", "DrugFacilitatedAssault");
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStored", "EvidenceStored");
            ViewBag.HIVMedsId = new SelectList(db.HIVMedsModel, "HIVMeds", "HIVMeds");
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttended", "HospitalAttended");
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnly", "MedicalOnly");
            ViewBag.MultiplePErpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetrators", "MultiplePerpetrators");
            ViewBag.PoliceAttendanceID = new SelectList(db.PoliceAttendanceModel, "PolicAttendance", "PolicAttendance");
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PolicReported", "PolicReported");
            ViewBag.ReferralHospitalId = new SelectList(db.ReferralHospitalModel, "ReferralHospital", "ReferralHospital");
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredCBVSModel, "ReferredCBVS", "ReferredCBVS");
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocialWorkAttendance", "SocialWorkAttendance");
            ViewBag.ThirsPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReport", "ThirdPartyReport");
            ViewBag.VictimServicesId = new SelectList(db.VictimServicesModel, "VictimServices", "VictimServices");
            ViewBag.WorkExploitationId = new SelectList(db.Work_ExploitationModel, "SexWorkExploitation", "SexWorkExploitation");
            return View();
        }

        // POST: SmartModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        private async Task<ActionResult> Create([Bind(Include = "ClientReferenceNumber,WorkExploitationId,MultiplePErpetratorsId,DrugFaciliatedAssaultID,CityOfAssaultId,CityOfResidenceId,AccompanimentMinutes,ReferralHospitalId,HospitalAttendedId,SocialWorkAttendanceId,PoliceAttendanceID,VictimServicesId,MedicalOnlyId,EvidenceStoredId,HIVMedsId,ReferredToCBVSId,PoliceReportedId,ThirsPartyReportId,BadDateReportId,NumberTransportsProvided,ReferredToNursePractitioner")] SmartModel smartModel)
        {
            if (ModelState.IsValid)
            {
                db.SmartModel.Add(smartModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport", smartModel.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault", smartModel.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence", smartModel.CityOfResidenceId);
            ViewBag.DrugFaciliatedAssaultID = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault", smartModel.DrugFaciliatedAssaultID);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored", smartModel.EvidenceStoredId);
            ViewBag.HIVMedsId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds", smartModel.HIVMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended", smartModel.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly", smartModel.MedicalOnlyId);
            ViewBag.MultiplePErpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsID", "MultiplePerpetrators", smartModel.MultiplePErpetratorsId);
            ViewBag.PoliceAttendanceID = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PolicAttendance", smartModel.PoliceAttendanceID);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PolicReported", smartModel.PoliceReportedId);
            ViewBag.ReferralHospitalId = new SelectList(db.ReferralHospitalModel, "ReferralHospitalID", "ReferralHospital", smartModel.ReferralHospitalId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredCBVSModel, "ReferralCBVSID", "ReferredCBVS", smartModel.ReferredToCBVSId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocalWorkAttendanceId", "SocialWorkAttendance", smartModel.SocialWorkAttendanceId);
            ViewBag.ThirsPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportID", "ThirdPartyReport", smartModel.ThirsPartyReportId);
            ViewBag.VictimServicesId = new SelectList(db.VictimServicesModel, "VictimServicesID", "VictimServices", smartModel.VictimServicesId);
            ViewBag.WorkExploitationId = new SelectList(db.Work_ExploitationModel, "SexWorkExploitationId", "SexWorkExploitation", smartModel.WorkExploitationId);
            return View(smartModel);
        }

        // GET: SmartModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmartModel smartModel = await db.SmartModel.FindAsync(id);
            if (smartModel == null)
            {
                return HttpNotFound();
            }

            ViewBag.ClientId = id;

            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport", smartModel.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault", smartModel.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence", smartModel.CityOfResidenceId);
            ViewBag.DrugFaciliatedAssaultID = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault", smartModel.DrugFaciliatedAssaultID);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored", smartModel.EvidenceStoredId);
            ViewBag.HIVMedsId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds", smartModel.HIVMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended", smartModel.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly", smartModel.MedicalOnlyId);
            ViewBag.MultiplePErpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsID", "MultiplePerpetrators", smartModel.MultiplePErpetratorsId);
            ViewBag.PoliceAttendanceID = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PolicAttendance", smartModel.PoliceAttendanceID);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PolicReported", smartModel.PoliceReportedId);
            ViewBag.ReferralHospitalId = new SelectList(db.ReferralHospitalModel, "ReferralHospitalID", "ReferralHospital", smartModel.ReferralHospitalId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredCBVSModel, "ReferralCBVSID", "ReferredCBVS", smartModel.ReferredToCBVSId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocalWorkAttendanceId", "SocialWorkAttendance", smartModel.SocialWorkAttendanceId);
            ViewBag.ThirsPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportID", "ThirdPartyReport", smartModel.ThirsPartyReportId);
            ViewBag.VictimServicesId = new SelectList(db.VictimServicesModel, "VictimServicesID", "VictimServices", smartModel.VictimServicesId);
            ViewBag.WorkExploitationId = new SelectList(db.Work_ExploitationModel, "SexWorkExploitationId", "SexWorkExploitation", smartModel.WorkExploitationId);
            return View(smartModel);
        }

        // POST: SmartModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ClientReferenceNumber,WorkExploitationId,MultiplePErpetratorsId,DrugFaciliatedAssaultID,CityOfAssaultId,CityOfResidenceId,AccompanimentMinutes,ReferralHospitalId,HospitalAttendedId,SocialWorkAttendanceId,PoliceAttendanceID,VictimServicesId,MedicalOnlyId,EvidenceStoredId,HIVMedsId,ReferredToCBVSId,PoliceReportedId,ThirsPartyReportId,BadDateReportId,NumberTransportsProvided,ReferredToNursePractitioner")] SmartModel smartModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smartModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ClientId = smartModel.ClientReferenceNumber;


            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport", smartModel.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault", smartModel.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence", smartModel.CityOfResidenceId);
            ViewBag.DrugFaciliatedAssaultID = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault", smartModel.DrugFaciliatedAssaultID);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored", smartModel.EvidenceStoredId);
            ViewBag.HIVMedsId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds", smartModel.HIVMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended", smartModel.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly", smartModel.MedicalOnlyId);
            ViewBag.MultiplePErpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsID", "MultiplePerpetrators", smartModel.MultiplePErpetratorsId);
            ViewBag.PoliceAttendanceID = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PolicAttendance", smartModel.PoliceAttendanceID);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PolicReported", smartModel.PoliceReportedId);
            ViewBag.ReferralHospitalId = new SelectList(db.ReferralHospitalModel, "ReferralHospitalID", "ReferralHospital", smartModel.ReferralHospitalId);
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredCBVSModel, "ReferralCBVSID", "ReferredCBVS", smartModel.ReferredToCBVSId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocalWorkAttendanceId", "SocialWorkAttendance", smartModel.SocialWorkAttendanceId);
            ViewBag.ThirsPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportID", "ThirdPartyReport", smartModel.ThirsPartyReportId);
            ViewBag.VictimServicesId = new SelectList(db.VictimServicesModel, "VictimServicesID", "VictimServices", smartModel.VictimServicesId);
            ViewBag.WorkExploitationId = new SelectList(db.Work_ExploitationModel, "SexWorkExploitationId", "SexWorkExploitation", smartModel.WorkExploitationId);
            return View(smartModel);
        }

        // GET: SmartModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmartModel smartModel = await db.SmartModel.FindAsync(id);
            if (smartModel == null)
            {
                return HttpNotFound();
            }
            return View(smartModel);
        }

        // POST: SmartModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SmartModel smartModel = await db.SmartModel.FindAsync(id);
            db.SmartModel.Remove(smartModel);
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
