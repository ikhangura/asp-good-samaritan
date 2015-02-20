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

        [ForeignKey("WorkExploitation")]
        public int WorkExploitationId { get; set; }
        public Work_ExploitationModel WorkExploitation { get; set; }

        [ForeignKey("MultiplePerpetrators")]
        public int MultiplePErpetratorsId { get; set; }
        public MultiplePerpetratorsModel MultiplePerpetrators { get; set; }

        [ForeignKey("DrugFaciliatedAssault")]
        public int DrugFaciliatedAssaultID { get; set; }
        public DrugFacilitatedAssaultModel DrugFaciliatedAssault { get; set; }

        [ForeignKey("CityOfAssault")]
        public int CityOfAssaultId { get; set; }
        public CityOfAssaultModel CityOfAssault { get; set; }

        [ForeignKey("CityOfResidence")]
        public int CityOfResidenceId { get; set; }
        public CityOfResidenceModel CityOfResidence { get; set; }

        public int AccompanimentMinutes { get; set; }

        [ForeignKey("ReferralHospital")]
        public int ReferralHospitalId { get; set; }
        public ReferralHospitalModel ReferralHospital { get; set; }

        [ForeignKey("HospitalAttended")]
        public int HospitalAttendedId { get; set; }
        public HospitalAttendedModel HospitalAttended { get; set; }

        [ForeignKey("SocialWorkAttendance")]
        public int SocialWorkAttendanceId { get; set; }
        public SocialWorkAttendanceModel SocialWorkAttendance { get; set; }

        [ForeignKey("PoliceAttendance")]
        public int PoliceAttendanceID { get; set; }
        public PoliceAttendanceModel PoliceAttendance { get; set; }

        [ForeignKey("VictimServices")]
        public int VictimServicesId { get; set; }
        public VictimServicesModel VictimServices { get; set; }

        [ForeignKey("MedicalOnly")]
        public int MedicalOnlyId { get; set; }
        public MedicalOnlyModel MedicalOnly { get; set; }

        [ForeignKey("EvidenceStored")]
        public int EvidenceStoredId { get; set; }
        public EvidenceStoredModel EvidenceStored { get; set; }

        [ForeignKey("HIVMeds")]
        public int HIVMedsId { get; set; }
        public HIVMedsModel HIVMeds { get; set; }

        [ForeignKey("ReferredToCBVS")]
        public int ReferredToCBVSId { get; set; }
        public ReferredCBVSModel ReferredToCBVS { get; set; }

        [ForeignKey("PoliceReported")]
        public int PoliceReportedId { get; set; }
        public PoliceReportedModel PoliceReported { get; set; }

        [ForeignKey("ThirdPartyReport")]
        public int ThirsPartyReportId { get; set; }
        public ThirdPartyReportModel ThirdPartyReport { get; set; }

        [ForeignKey("BadDateReport")]
        public int BadDateReportId { get; set; }
        public BadDateReportModel BadDateReport { get; set; }

        public int NumberTransportsProvided { get; set; }

        public bool ReferredToNursePractitioner { get; set; }
    }
}