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
        [Display(Name = "Client Reference Number")]
        [Key]
        public int ClientReferenceNumber { get; set; }

        [Display(Name = "Work Exploitation")]
        [ForeignKey("WorkExploitation")]
        public int WorkExploitationId { get; set; }
        public Work_ExploitationModel WorkExploitation { get; set; }

        [Display(Name = "Multiple Perpetrators")]
        [ForeignKey("MultiplePerpetrators")]
        public int MultiplePErpetratorsId { get; set; }
        public MultiplePerpetratorsModel MultiplePerpetrators { get; set; }

        [Display(Name = "Drug Facilitated Assault")]
        [ForeignKey("DrugFaciliatedAssault")]
        public int DrugFaciliatedAssaultID { get; set; }
        public DrugFacilitatedAssaultModel DrugFaciliatedAssault { get; set; }

        [Display(Name = "City Of Assault")]
        [ForeignKey("CityOfAssault")]
        public int CityOfAssaultId { get; set; }
        public CityOfAssaultModel CityOfAssault { get; set; }

        [Display(Name = "City Of Residence")]
        [ForeignKey("CityOfResidence")]
        public int CityOfResidenceId { get; set; }
        public CityOfResidenceModel CityOfResidence { get; set; }

        [Display(Name = "Accompaniment Minutes")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int AccompanimentMinutes { get; set; }

        [Display(Name = "Referral Hospital")]
        [ForeignKey("ReferralHospital")]
        public int ReferralHospitalId { get; set; }
        public ReferralHospitalModel ReferralHospital { get; set; }

        [Display(Name = "Hospital Attended")]
        [ForeignKey("HospitalAttended")]
        public int HospitalAttendedId { get; set; }
        public HospitalAttendedModel HospitalAttended { get; set; }

        [Display(Name = "Social Worker Attendance")]
        [ForeignKey("SocialWorkAttendance")]
        public int SocialWorkAttendanceId { get; set; }
        public SocialWorkAttendanceModel SocialWorkAttendance { get; set; }

        [Display(Name = "Police Attendance")]
        [ForeignKey("PoliceAttendance")]
        public int PoliceAttendanceID { get; set; }
        public PoliceAttendanceModel PoliceAttendance { get; set; }

        [Display(Name = "Victim Services")]
        [ForeignKey("VictimServices")]
        public int VictimServicesId { get; set; }
        public VictimServicesModel VictimServices { get; set; }

        [Display(Name = "Mdeical Only")]
        [ForeignKey("MedicalOnly")]
        public int MedicalOnlyId { get; set; }
        public MedicalOnlyModel MedicalOnly { get; set; }

        [Display(Name = "Evidence Stored")]
        [ForeignKey("EvidenceStored")]
        public int EvidenceStoredId { get; set; }
        public EvidenceStoredModel EvidenceStored { get; set; }

        [Display(Name = "HIV Meds")]
        [ForeignKey("HIVMeds")]
        public int HIVMedsId { get; set; }
        public HIVMedsModel HIVMeds { get; set; }

        [Display(Name = "Referred To CBVS")]
        [ForeignKey("ReferredToCBVS")]
        public int ReferredToCBVSId { get; set; }
        public ReferredCBVSModel ReferredToCBVS { get; set; }

        [Display(Name = "Police Reported")]
        [ForeignKey("PoliceReported")]
        public int PoliceReportedId { get; set; }
        public PoliceReportedModel PoliceReported { get; set; }

        [Display(Name = "Third Party Report")]
        [ForeignKey("ThirdPartyReport")]
        public int ThirsPartyReportId { get; set; }
        public ThirdPartyReportModel ThirdPartyReport { get; set; }

        [Display(Name = "Bad Date Report")]
        [ForeignKey("BadDateReport")]
        public int BadDateReportId { get; set; }
        public BadDateReportModel BadDateReport { get; set; }

        [Display(Name = "Number Of Transports Provided")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int NumberTransportsProvided { get; set; }

        [Display(Name = "Referred To Nurse Practitioner")]
        public bool ReferredToNursePractitioner { get; set; }
    }
}