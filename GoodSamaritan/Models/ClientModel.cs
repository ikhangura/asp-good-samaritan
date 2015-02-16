using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodSamaritan.Models.LookupTables;
using System.ComponentModel.DataAnnotations;

namespace GoodSamaritan.Models
{
    public class ClientModel
    {
        [Key]
        public int ClientReferenceNumber { get; set; }

        public List<FiscalYearModel> FiscalYear { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public string PoliceFileNumber { get; set; }

        public int CourtFileNumber { get; set; }

        public int SWCFileNumber { get; set; }

        public List<RiskLevelModel> RiskLevel { get; set; }

        public List<CrisisModel> Crisis { get; set; }

        public List<ServiceModel> Service { get; set; }

        public List<ProgramModel> Program { get; set; }

        public string RiskAssessmentAssignedTo { get; set; }

        public List<RiskStatusModel> RiskStatus { get; set; }

        public List<AssignedWorkerModel> AssignedWorker { get; set; }

        public List<ReferralSourceModel> ReferralSource { get; set; }

        public List<ReferralContactModel> ReferralContact { get; set; }

        public List<IncidentModel> Incident { get; set; }

        public string AbuserName { get; set; }

        public List<AbuserRelationshipModel> AbuserRelationship { get; set; }

        public List<VictimOfIncidentModel> VictimOfIncident { get; set; }

        public List<FamilyViolenceModel> FamilyViolenceFile { get; set; }

        public char Gender { get; set; }

        public List<EthnicityModel> Ethnicity { get; set; }

        public List<AgeModel> Age { get; set; }

        public List<RepeatClientModel> RepeatClient { get; set; }

        public List<DuplicateFileModel> DuplicateFile { get; set; }

        public int NumChildren0_6 { get; set; }

        public int NumChildren7_12 { get; set; }

        public int NumChildren13_18 { get; set; }

        public List<StatusOfFileModel> StatusOfFile { get; set; }

        public DateTime DateLastTransferred { get; set; }

        public DateTime DateClosed { get; set; }

        public DateTime DateReOpened { get; set; }
    }
}