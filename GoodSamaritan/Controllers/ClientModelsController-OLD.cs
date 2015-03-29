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
using System.Diagnostics;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Worker")]
    public class ClientModelsController2 : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ClientModels
        public async Task<ActionResult> Index()
        {
            

            var clientModel = db.ClientModel.Include(c => c.AbuserRelationship).Include(c => c.Age).Include(c => c.AssignedWorker).Include(c => c.Crisis).Include(c => c.DuplicateFile).Include(c => c.Ethnicity).Include(c => c.FamilyViolenceFile).Include(c => c.FiscalYear).Include(c => c.Incident).Include(c => c.Program).Include(c => c.ReferralContact).Include(c => c.ReferralSource).Include(c => c.RepeatClient).Include(c => c.RiskLevel).Include(c => c.RiskStatus).Include(c => c.Service).Include(c => c.SmartModel).Include(c => c.StatusOfFile).Include(c => c.VictimOfIncident);
            return View(await clientModel.ToListAsync());
        }

        // GET: ClientModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            return View(clientModel);
        }

        // GET: ClientModels/Create
        public ActionResult Create()
        {
            //generate random SWC File Number and pass to view
            Random generator = new Random();
            int swc = generator.Next(int.MaxValue);
            ViewBag.SWC = swc;


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



            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationShipId", "AbuserRelationship");
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age");
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker");
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis");
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile");
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity");
            ViewBag.FamilyViolenceId = new SelectList(db.FamilyViolenceModel, "FamilyVolenceId", "FamilyViolenceFile");
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FicalYearId", "FiscalYear");
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident");
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program");
            ViewBag.ReferralContactId = new SelectList(db.ReferralContactModel, "ReferralContactId", "ReferralContact");
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceModel, "ReferralSourceId", "ReferralSource");
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient");
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevel", "RiskLevel");
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus");
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service");
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber");
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile");
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOFIncidentId", "VictimOfIncident");

            var client = new ClientModel
            {
                SWCFileNumber = swc
            };



            return View(new Tuple<ClientModel, SmartModel>(client, new SmartModel()));
        }

        // POST: ClientModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FiscalYearId")] ClientModel clientModel)
        {
            if (ModelState.IsValid)
            {
                //db.ClientModel.Add(clientModel);
                //await db.SaveChangesAsync();
                Debug.WriteLine("Made It Here");
                return RedirectToAction("Index");
            }

            var query = from state in ModelState.Values
                        from error in state.Errors
                        select error.ErrorMessage;

            var errorList = query.ToList();
            foreach (var error in errorList)
            {
                Debug.WriteLine(error);
            }

            Debug.WriteLine("Failed Model State Validation");

            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationShipId", "AbuserRelationship", clientModel.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age", clientModel.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker", clientModel.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis", clientModel.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile", clientModel.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity", clientModel.EthnicityId);
            ViewBag.FamilyViolenceId = new SelectList(db.FamilyViolenceModel, "FamilyVolenceId", "FamilyViolenceFile", clientModel.FamilyViolenceId);
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FicalYearId", "FiscalYear", clientModel.FiscalYearId);
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident", clientModel.IncidentId);
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program", clientModel.ProgramId);
            ViewBag.ReferralContactId = new SelectList(db.ReferralContactModel, "ReferralContactId", "ReferralContact", clientModel.ReferralContactId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceModel, "ReferralSourceId", "ReferralSource", clientModel.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient", clientModel.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevelId", "RiskLevel", clientModel.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus", clientModel.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service", clientModel.ServiceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber", clientModel.ClientReferenceNumber);
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile", clientModel.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOFIncidentId", "VictimOfIncident", clientModel.VictimOfIncidentId);

            /* Smart */

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


            return View(new Tuple<ClientModel, SmartModel>(clientModel, new SmartModel()));
        }

        // GET: ClientModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationShipId", "AbuserRelationship", clientModel.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age", clientModel.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker", clientModel.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis", clientModel.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile", clientModel.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity", clientModel.EthnicityId);
            ViewBag.FamilyViolenceId = new SelectList(db.FamilyViolenceModel, "FamilyVolenceId", "FamilyViolenceFile", clientModel.FamilyViolenceId);
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FicalYearId", "FiscalYear", clientModel.FiscalYearId);
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident", clientModel.IncidentId);
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program", clientModel.ProgramId);
            ViewBag.ReferralContactId = new SelectList(db.ReferralContactModel, "ReferralContactId", "ReferralContact", clientModel.ReferralContactId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceModel, "ReferralSourceId", "ReferralSource", clientModel.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient", clientModel.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevelId", "RiskLevel", clientModel.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus", clientModel.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service", clientModel.ServiceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber", clientModel.ClientReferenceNumber);
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile", clientModel.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOFIncidentId", "VictimOfIncident", clientModel.VictimOfIncidentId);
            return View(clientModel);
        }

        // POST: ClientModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ClientReferenceNumber,FiscalYearId,Month,Day,Surname,FirstName,PoliceFileNumber,CourtFileNumber,SWCFileNumber,RiskLevelId,CrisisId,ServiceId,ProgramId,RiskAssessmentAssignedTo,RiskStatusId,AssignedWorkerId,ReferralSourceId,ReferralContactId,IncidentId,AbuserName,AbuserRelationshipId,VictimOfIncidentId,FamilyViolenceId,EthnicityId,AgeId,RepeatClientId,DuplicateFileId,NumChildren0_6,NumChildren7_12,NumChildren13_18,StatusOfFileId,DateLastTransferred,DateClosed,DateReOpened")] ClientModel clientModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationShipId", "AbuserRelationship", clientModel.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age", clientModel.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker", clientModel.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis", clientModel.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile", clientModel.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity", clientModel.EthnicityId);
            ViewBag.FamilyViolenceId = new SelectList(db.FamilyViolenceModel, "FamilyVolenceId", "FamilyViolenceFile", clientModel.FamilyViolenceId);
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FicalYearId", "FiscalYear", clientModel.FiscalYearId);
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident", clientModel.IncidentId);
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program", clientModel.ProgramId);
            ViewBag.ReferralContactId = new SelectList(db.ReferralContactModel, "ReferralContactId", "ReferralContact", clientModel.ReferralContactId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceModel, "ReferralSourceId", "ReferralSource", clientModel.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient", clientModel.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevelId", "RiskLevel", clientModel.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus", clientModel.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service", clientModel.ServiceId);
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber", clientModel.ClientReferenceNumber);
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile", clientModel.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOFIncidentId", "VictimOfIncident", clientModel.VictimOfIncidentId);
            return View(clientModel);
        }

        // GET: ClientModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            return View(clientModel);
        }

        // POST: ClientModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ClientModel clientModel = await db.ClientModel.FindAsync(id);
            db.ClientModel.Remove(clientModel);
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
