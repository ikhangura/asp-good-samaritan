using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using GoodSamaritan.Models.LookupTables;
using System.ComponentModel.DataAnnotations;

namespace GoodSamaritan.Models
{
    public class SmartModel
    {
        [Key]
        public int ClientReferenceNumber { get; set; }

        public Work_ExploitationModel WorkExploitation { get; set; }

        public MultiplePerpetratorsModel MultiplePerpetrators { get; set; }

        public DrugFacilitatedAssaultModel DrugFaciliatedAssault { get; set; }

        public CityOfAssaultModel CityOfAssault { get; set; }

        public CityOfResidenceModel CityOfResidence { get; set; }

        public int AccompanimentMinutes { get; set; }

        public ReferralHospitalModel ReferralHospital { get; set; }

        public HospitalAttendedModel HospitalAttended { get; set; }

        public SocialWorkAttendanceModel SocialWorkAttendance { get; set; }

        public PoliceAttendanceModel PoliceAttendance { get; set; }

        public VictimServicesModel VictimServices { get; set; }

        public MedicalOnlyModel MedicalOnly { get; set; }

        public EvidenceStoredModel EvidenceStored { get; set; }

        public HIVMedsModel HIVMeds { get; set; }

        public ReferredCBVSModel ReferredToCBVS { get; set; }

        public PoliceReportedModel PoliceReported { get; set; }

        public ThirdPartyReportModel ThirdPartyReport { get; set; }

        public BadDateReportModel BadDateReport { get; set; }

        public int NumberTransportsProvided { get; set; }

        public bool ReferredToNursePractitioner { get; set; }
    }
}