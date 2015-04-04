using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;
using System.Diagnostics;
using Newtonsoft.Json;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Worker")]
    public class ClientModelsController : Controller
    {
        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: ClientModels
        public ActionResult Index()
        {
            var clientModel = db.ClientModel.Include(c => c.AbuserRelationship).Include(c => c.Age).Include(c => c.AssignedWorker).Include(c => c.Crisis).Include(c => c.DuplicateFile).Include(c => c.Ethnicity).Include(c => c.FamilyViolenceFile).Include(c => c.FiscalYear).Include(c => c.Incident).Include(c => c.Program).Include(c => c.ReferralContact).Include(c => c.ReferralSource).Include(c => c.RepeatClient).Include(c => c.RiskLevel).Include(c => c.RiskStatus).Include(c => c.Service).Include(c => c.SmartModel).Include(c => c.StatusOfFile).Include(c => c.VictimOfIncident);
            return View(clientModel.ToList());
        }

        // GET: ClientModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var clientsModel = db.ClientModel.Include(c => c.AbuserRelationship).Include(c => c.Age).Include(c => c.AssignedWorker).Include(c => c.Crisis).Include(c => c.DuplicateFile).Include(c => c.Ethnicity).Include(c => c.FamilyViolenceFile).Include(c => c.FiscalYear).Include(c => c.Incident).Include(c => c.Program).Include(c => c.ReferralContact).Include(c => c.ReferralSource).Include(c => c.RepeatClient).Include(c => c.RiskLevel).Include(c => c.RiskStatus).Include(c => c.Service).Include(c => c.SmartModel).Include(c => c.StatusOfFile).Include(c => c.VictimOfIncident);
            
           ClientModel clientModel = (from aClient in clientsModel
                                     where aClient.ClientReferenceNumber == id
                                     select aClient).FirstOrDefault();
            
            if (clientModel == null)
            {
                return HttpNotFound();
            }

            SmartModel smartModel = null;
            if (clientModel.ProgramId == 3)
            {
                var smartModels = db.SmartModel.Include(s => s.BadDateReport).Include(s => s.CityOfAssault).Include(s => s.CityOfResidence).Include(s => s.DrugFaciliatedAssault).Include(s => s.EvidenceStored).Include(s => s.HIVMeds).Include(s => s.HospitalAttended).Include(s => s.MedicalOnly).Include(s => s.MultiplePerpetrators).Include(s => s.PoliceAttendance).Include(s => s.PoliceReported).Include(s => s.ReferralHospital).Include(s => s.ReferredToCBVS).Include(s => s.SocialWorkAttendance).Include(s => s.ThirdPartyReport).Include(s => s.VictimServices).Include(s => s.WorkExploitation);
                smartModel = (from aSmart in smartModels
                             where aSmart.ClientReferenceNumber == id
                             select aSmart).FirstOrDefault();

                if (smartModel != null)
                {
                    ViewBag.ShowSmart = true;
                }
                else
                {
                    ViewBag.ShowSmart = false;
                }
            }
            else
            {
                ViewBag.ShowSmart = false;
                smartModel = new SmartModel();
            }
            

            

            return View(new Tuple<ClientModel,SmartModel>(clientModel, smartModel));
        }

        // GET: ClientModels/Create
        public ActionResult Create()
        {

            ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport");
            ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault");
            ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence");
            ViewBag.DrugFaciliatedAssaultID = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault");
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored");
            ViewBag.HIVMedsId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds");
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended");
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly");
            ViewBag.MultiplePErpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsID", "MultiplePerpetrators");
            ViewBag.PoliceAttendanceID = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PolicAttendance");
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PolicReported");
            ViewBag.ReferralHospitalId = new SelectList(db.ReferralHospitalModel, "ReferralHospitalID", "ReferralHospital");
            ViewBag.ReferredToCBVSId = new SelectList(db.ReferredCBVSModel, "ReferralCBVSID", "ReferredCBVS");
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocalWorkAttendanceId", "SocialWorkAttendance");
            ViewBag.ThirsPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportID", "ThirdPartyReport");
            ViewBag.VictimServicesId = new SelectList(db.VictimServicesModel, "VictimServicesID", "VictimServices");
            ViewBag.WorkExploitationId = new SelectList(db.Work_ExploitationModel, "SexWorkExploitationId", "SexWorkExploitation");



            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationShipId", "AbuserRelationship");
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age");
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker");
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis");
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile");
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity");
            ViewBag.FamilyViolenceId = new SelectList(db.FamilyViolenceModel, "FamilyVolenceId", "FamilyViolenceFile");
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FicalYearId", "FiscalYear");
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident");
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program"); // ProgramId changed to Program
            ViewBag.ReferralContactId = new SelectList(db.ReferralContactModel, "ReferralContactId", "ReferralContact");
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSourceModel, "ReferralSourceId", "ReferralSource");
            ViewBag.RepeatClientId = new SelectList(db.RepeatClientModel, "RepeatClientId", "RepeatClient");
            ViewBag.RiskLevelId = new SelectList(db.RiskLevelModel, "RiskLevelId", "RiskLevel");
            ViewBag.RiskStatusId = new SelectList(db.RiskStatusModel, "RiskStatusId", "RiskStatus");
            ViewBag.ServiceId = new SelectList(db.ServiceModel, "ServiceId", "Service");
            ViewBag.ClientReferenceNumber = new SelectList(db.SmartModel, "ClientReferenceNumber", "ClientReferenceNumber");
            ViewBag.StatusOfFileId = new SelectList(db.StatusOfFileModel, "StatusOfFileId", "StatusOfFile");
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimOfIncidentModel, "VictimOFIncidentId", "VictimOfIncident");



            Random generator = new Random();
            ClientModel client = new ClientModel
            {
                SWCFileNumber = generator.Next(int.MaxValue)
            };

            return View();
        }

        private SmartModel createSmartEntity(FormCollection smartData)
        {
            SmartModel sm = new SmartModel(){
                WorkExploitationId = Convert.ToInt32(smartData["WorkExploitationId"]),
                MultiplePErpetratorsId = Convert.ToInt32(smartData["MultiplePErpetratorsId"]),
                DrugFaciliatedAssaultID = Convert.ToInt32(smartData["DrugFaciliatedAssaultID"]),
                CityOfAssaultId = Convert.ToInt32(smartData["CityOfAssaultId"]),
                CityOfResidenceId = Convert.ToInt32(smartData["CityOfResidenceId"]),
                AccompanimentMinutes = Convert.ToInt32(smartData["SmartModel.AccompanimentMinutes"]),
                ReferralHospitalId = Convert.ToInt32(smartData["ReferralHospitalId"]),
                HospitalAttendedId = Convert.ToInt32(smartData["HospitalAttendedId"]),
                SocialWorkAttendanceId = Convert.ToInt32(smartData["SocialWorkAttendanceId"]),
                PoliceAttendanceID = Convert.ToInt32(smartData["PoliceAttendanceID"]),
                VictimServicesId = Convert.ToInt32(smartData["VictimServicesId"]),
                MedicalOnlyId = Convert.ToInt32(smartData["MedicalOnlyId"]),
                EvidenceStoredId = Convert.ToInt32(smartData["EvidenceStoredId"]),
                HIVMedsId = Convert.ToInt32(smartData["HIVMedsId"]),
                ReferredToCBVSId = Convert.ToInt32(smartData["ReferredToCBVSId"]),
                PoliceReportedId = Convert.ToInt32(smartData["PoliceReportedId"]),
                ThirsPartyReportId = Convert.ToInt32(smartData["ThirsPartyReportId"]),
                BadDateReportId = Convert.ToInt32(smartData["BadDateReportId"]),
                NumberTransportsProvided = Convert.ToInt32(smartData["SmartModel.NumberTransportsProvided"]),
                ReferredToNursePractitioner = smartData["SmartModel.ReferredToNursePractitioner"].Equals("true") ? true : false


            };

            //var dump = JsonConvert.SerializeObject(sm);
            //Debug.WriteLine(dump);

            //db.SmartModel.Add(sm);
            //db.SaveChanges();

            //return sm.ClientReferenceNumber;
            return sm;

        }

        private int createDefaultSmartEntity()
        {
            SmartModel defaultEntity = new SmartModel()
            {
                WorkExploitationId = 1,
                MultiplePErpetratorsId = 1,
                DrugFaciliatedAssaultID = 1,
                CityOfAssaultId = 1,
                CityOfResidenceId = 1,
                AccompanimentMinutes = 1,
                ReferralHospitalId = 1,
                HospitalAttendedId = 1,
                SocialWorkAttendanceId = 1,
                PoliceAttendanceID = 1,
                VictimServicesId = 1,
                MedicalOnlyId = 1,
                EvidenceStoredId = 1,
                HIVMedsId = 1,
                ReferredToCBVSId = 1,
                PoliceReportedId = 1,
                ThirsPartyReportId = 1,
                BadDateReportId = 1,
                NumberTransportsProvided = 1,
                ReferredToNursePractitioner = false
            };

            db.SmartModel.Add(defaultEntity);
            db.SaveChanges();

            return defaultEntity.ClientReferenceNumber;
        }

       

        // POST: ClientModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FiscalYearId,Month,Day,Surname,FirstName,PoliceFileNumber,CourtFileNumber,RiskLevelId,CrisisId,ServiceId,ProgramId,RiskAssessmentAssignedTo,RiskStatusId,AssignedWorkerId,ReferralSourceId,ReferralContactId,IncidentId,AbuserName,AbuserRelationshipId,VictimOfIncidentId,FamilyViolenceId,Gender,EthnicityId,AgeId,RepeatClientId,DuplicateFileId,NumChildren0_6,NumChildren7_12,NumChildren13_18,StatusOfFileId,DateLastTransferred,DateClosed,DateReOpened")] ClientModel clientModel, FormCollection smartFormCollection)
        {

            Debug.WriteLine(smartFormCollection["BadDateReportId"]);
            Debug.WriteLine(smartFormCollection["SmartModel.AccompanimentMinutes"]);
            Debug.WriteLine(smartFormCollection["WorkExploitationId"]);

            

            if (ModelState.IsValid)
            {
                if (clientModel.ProgramId == 3)
                {
                    Debug.WriteLine("SMART Entry Detected");
                    //db.SmartModel.Add(smartModel);
                    //db.SaveChanges();
                    SmartModel smart = createSmartEntity(smartFormCollection);
                    db.SmartModel.Add(smart);
                    db.SaveChanges();
                    clientModel.ClientReferenceNumber = smart.ClientReferenceNumber;

                }
                else
                {
                    //5 is the all other users smart entry - NEEDS TO BE SEEDED IN DB TO WORK
                    /*SmartModel fakeSmartModel = new SmartModel();
                    db.SmartModel.Add(fakeSmartModel);
                    db.SaveChanges();*/

                    clientModel.ClientReferenceNumber = createDefaultSmartEntity();
                }

                Random generator = new Random();
                clientModel.SWCFileNumber = generator.Next(int.MaxValue);
                db.ClientModel.Add(clientModel);
                db.SaveChanges();
                Debug.WriteLine("Valid");
                return RedirectToAction("Index");
            }
            else
            {
                if (clientModel.ProgramId == 3)
                {
                    Debug.WriteLine("Validation Failed But SMART Model Was Used. ReEstablishing Previous Settings");

                    SmartModel smart = createSmartEntity(smartFormCollection);


                    ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport", smart.BadDateReportId);
                    ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault", smart.CityOfAssaultId);
                    ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence", smart.CityOfResidenceId);
                    ViewBag.DrugFaciliatedAssaultID = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault", smart.DrugFaciliatedAssaultID);
                    ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored", smart.EvidenceStoredId);
                    ViewBag.HIVMedsId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds", smart.HIVMedsId);
                    ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended", smart.HospitalAttendedId);
                    ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly", smart.MedicalOnlyId);
                    ViewBag.MultiplePErpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsID", "MultiplePerpetrators", smart.MultiplePErpetratorsId);
                    ViewBag.PoliceAttendanceID = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PolicAttendance", smart.PoliceAttendanceID);
                    ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PolicReported", smart.PoliceReportedId);
                    ViewBag.ReferralHospitalId = new SelectList(db.ReferralHospitalModel, "ReferralHospitalID", "ReferralHospital", smart.ReferralHospitalId);
                    ViewBag.ReferredToCBVSId = new SelectList(db.ReferredCBVSModel, "ReferralCBVSID", "ReferredCBVS", smart.ReferredToCBVSId);
                    ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocalWorkAttendanceId", "SocialWorkAttendance", smart.SocialWorkAttendanceId);
                    ViewBag.ThirsPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportID", "ThirdPartyReport", smart.ThirsPartyReportId);
                    ViewBag.VictimServicesId = new SelectList(db.VictimServicesModel, "VictimServicesID", "VictimServices", smart.VictimServicesId);
                    ViewBag.WorkExploitationId = new SelectList(db.Work_ExploitationModel, "SexWorkExploitationId", "SexWorkExploitation", smart.WorkExploitationId);

                    clientModel.SmartModel = smart;

                }
                else
                {
                    ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReportId", "BadDateReport");
                    ViewBag.CityOfAssaultId = new SelectList(db.CityOfAssaultModel, "CityOfAssaultId", "CityOfAssault");
                    ViewBag.CityOfResidenceId = new SelectList(db.CityOfResidenceModel, "CityOfResidenceId", "CityOfResidence");
                    ViewBag.DrugFaciliatedAssaultID = new SelectList(db.DrugFacilitatedAssaultModel, "DrugFacilitatedAssaultId", "DrugFacilitatedAssault");
                    ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStoredModel, "EvidenceStoredId", "EvidenceStored");
                    ViewBag.HIVMedsId = new SelectList(db.HIVMedsModel, "HIVMedsId", "HIVMeds");
                    ViewBag.HospitalAttendedId = new SelectList(db.HospitalAttendedModel, "HospitalAttendedId", "HospitalAttended");
                    ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnlyModel, "MedicalOnlyId", "MedicalOnly");
                    ViewBag.MultiplePErpetratorsId = new SelectList(db.MultiplePerpetratorsModel, "MultiplePerpetratorsID", "MultiplePerpetrators");
                    ViewBag.PoliceAttendanceID = new SelectList(db.PoliceAttendanceModel, "PoliceAttendanceId", "PolicAttendance");
                    ViewBag.PoliceReportedId = new SelectList(db.PoliceReportedModel, "PoliceReportedId", "PolicReported");
                    ViewBag.ReferralHospitalId = new SelectList(db.ReferralHospitalModel, "ReferralHospitalID", "ReferralHospital");
                    ViewBag.ReferredToCBVSId = new SelectList(db.ReferredCBVSModel, "ReferralCBVSID", "ReferredCBVS");
                    ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendanceModel, "SocalWorkAttendanceId", "SocialWorkAttendance");
                    ViewBag.ThirsPartyReportId = new SelectList(db.ThirdPartyReportModel, "ThirdPartyReportID", "ThirdPartyReport");
                    ViewBag.VictimServicesId = new SelectList(db.VictimServicesModel, "VictimServicesID", "VictimServices");
                    ViewBag.WorkExploitationId = new SelectList(db.Work_ExploitationModel, "SexWorkExploitationId", "SexWorkExploitation");
                }
            }

            /**ViewBag.BadDateReportId = new SelectList(db.BadDateReportModel, "BadDateReport", "BadDateReport");
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
            ViewBag.WorkExploitationId = new SelectList(db.Work_ExploitationModel, "SexWorkExploitationId", "SexWorkExploitation");**/

            

            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationshipModel, "AbuserRelationShipId", "AbuserRelationship", clientModel.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.AgeModel, "AgeId", "Age", clientModel.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkerModel, "AssignedWorkerId", "AssignedWorker", clientModel.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.CrisisModel, "CrisisId", "Crisis", clientModel.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFileModel, "DuplicateFileId", "DuplicateFile", clientModel.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.EthnicityModel, "EthnicityId", "Ethnicity", clientModel.EthnicityId);
            ViewBag.FamilyViolenceId = new SelectList(db.FamilyViolenceModel, "FamilyVolenceId", "FamilyViolenceFile", clientModel.FamilyViolenceId);
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FicalYearId", "FiscalYear", clientModel.FiscalYearId);
            ViewBag.IncidentId = new SelectList(db.IncidentModel, "IncidentId", "Incident", clientModel.IncidentId);
            ViewBag.ProgramId = new SelectList(db.ProgramModel, "ProgramId", "Program", clientModel.ProgramId); // ProgramId changed to Program
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

        // GET: ClientModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientModel = db.ClientModel.Find(id);
            if (clientModel == null)
            {
                return HttpNotFound();
            }

            SmartModel smartModel = db.SmartModel.Find(id);
            if (smartModel != null && clientModel.ProgramId == 3)
            {
                ViewBag.Announce = true;
                ViewBag.ClientId = id;
            }
            else
            {
                ViewBag.Announce = false;
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
        public ActionResult Edit([Bind(Include = "ClientReferenceNumber,FiscalYearId,Month,Day,Surname,FirstName,PoliceFileNumber,CourtFileNumber,SWCFileNumber,RiskLevelId,CrisisId,ServiceId,ProgramId,RiskAssessmentAssignedTo,RiskStatusId,AssignedWorkerId,ReferralSourceId,ReferralContactId,IncidentId,AbuserName,AbuserRelationshipId,VictimOfIncidentId,FamilyViolenceId,Gender,EthnicityId,AgeId,RepeatClientId,DuplicateFileId,NumChildren0_6,NumChildren7_12,NumChildren13_18,StatusOfFileId,DateLastTransferred,DateClosed,DateReOpened")] ClientModel clientModel, FormCollection smartFormCollection)
        {

            if (ModelState.IsValid)
            {

                db.Entry(clientModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            if (clientModel.ProgramId == 3)
            {
                ViewBag.Announce = true;
                ViewBag.ClientId = clientModel.ClientReferenceNumber;
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
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //ClientModel clientModel = db.ClientModel.Find(id);

            var clientsModel = db.ClientModel.Include(c => c.AbuserRelationship).Include(c => c.Age).Include(c => c.AssignedWorker).Include(c => c.Crisis).Include(c => c.DuplicateFile).Include(c => c.Ethnicity).Include(c => c.FamilyViolenceFile).Include(c => c.FiscalYear).Include(c => c.Incident).Include(c => c.Program).Include(c => c.ReferralContact).Include(c => c.ReferralSource).Include(c => c.RepeatClient).Include(c => c.RiskLevel).Include(c => c.RiskStatus).Include(c => c.Service).Include(c => c.SmartModel).Include(c => c.StatusOfFile).Include(c => c.VictimOfIncident);

            ClientModel clientModel = (from aClient in clientsModel
                                       where aClient.ClientReferenceNumber == id
                                       select aClient).FirstOrDefault();

            SmartModel smartModel = null;
            if (clientModel == null)
            {
                return HttpNotFound();
            }
            else
            {
                //if client is in the smart program, add it to the page aswell
                
                if (clientModel.ProgramId == 3)
                {
                    var smartModels = db.SmartModel.Include(s => s.BadDateReport).Include(s => s.CityOfAssault).Include(s => s.CityOfResidence).Include(s => s.DrugFaciliatedAssault).Include(s => s.EvidenceStored).Include(s => s.HIVMeds).Include(s => s.HospitalAttended).Include(s => s.MedicalOnly).Include(s => s.MultiplePerpetrators).Include(s => s.PoliceAttendance).Include(s => s.PoliceReported).Include(s => s.ReferralHospital).Include(s => s.ReferredToCBVS).Include(s => s.SocialWorkAttendance).Include(s => s.ThirdPartyReport).Include(s => s.VictimServices).Include(s => s.WorkExploitation);
                    smartModel = (from aSmart in smartModels
                                  where aSmart.ClientReferenceNumber == id
                                  select aSmart).FirstOrDefault();

                    if (smartModel != null)
                    {
                        ViewBag.ShowSmart = true;
                    }
                    else
                    {
                        ViewBag.ShowSmart = false;
                    }
                }
                else
                {
                    ViewBag.ShowSmart = false;
                    smartModel = new SmartModel();
                }
            }

            return View(new Tuple<ClientModel, SmartModel>(clientModel, smartModel));
        }

        // POST: ClientModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientModel clientModel = db.ClientModel.Find(id);

            if (clientModel != null && clientModel.ProgramId == 3)
            {
                SmartModel smartModel = db.SmartModel.Find(id);
                db.ClientModel.Remove(clientModel);
                db.SaveChanges();
                db.SmartModel.Remove(smartModel);
                db.SaveChanges();
            }
            else
            {
                db.ClientModel.Remove(clientModel);
                db.SaveChanges();
            }
            
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
