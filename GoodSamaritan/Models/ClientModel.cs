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

        public SmartModel SmartModel { get; set; }

        public FiscalYearModel FiscalYear { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public string PoliceFileNumber { get; set; }

        public int CourtFileNumber { get; set; }

        public int SWCFileNumber { get; set; }

        public RiskLevelModel RiskLevel { get; set; }

        public CrisisModel Crisis { get; set; }

        public ServiceModel Service { get; set; }

        public ProgramModel Program { get; set; }

        public string RiskAssessmentAssignedTo { get; set; }

        public RiskStatusModel RiskStatus { get; set; }

        public AssignedWorkerModel AssignedWorker { get; set; }

        public ReferralSourceModel ReferralSource { get; set; }

        public ReferralContactModel ReferralContact { get; set; }

        public IncidentModel Incident { get; set; }

        public string AbuserName { get; set; }

        public AbuserRelationshipModel AbuserRelationship { get; set; }

        public VictimOfIncidentModel VictimOfIncident { get; set; }

        public FamilyViolenceModel FamilyViolenceFile { get; set; }

        public char Gender { get; set; }

        public EthnicityModel Ethnicity { get; set; }

        public AgeModel Age { get; set; }

        public RepeatClientModel RepeatClient { get; set; }

        public DuplicateFileModel DuplicateFile { get; set; }

        public int NumChildren0_6 { get; set; }

        public int NumChildren7_12 { get; set; }

        public int NumChildren13_18 { get; set; }

        public StatusOfFileModel StatusOfFile { get; set; }

        public DateTime DateLastTransferred { get; set; }

        public DateTime DateClosed { get; set; }

        public DateTime DateReOpened { get; set; }
    }
}