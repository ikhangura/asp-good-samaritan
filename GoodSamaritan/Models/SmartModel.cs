using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models
{
    public class SmartModel
    {
        [ForeignKey('ClientModel')]
        public int ClientReferenceNumber { get; set; }

        public List<Work_EploitationModel> WorkExploitation { get; set; }

        public List<MultiplePerpetratorsModel> MultiplePerpetrators { get; set; }

        public List<DrugFaciliatedAssaultModel> DrugFaciliatedAssault { get; set; }

        public List<CityOfAssaultModel> CityOfAssault { get; set; }

        public List<CityOFResidenceModel> CityOfResidence { get; set; }

        public int AccompanimentMinutes { get; set; }

        public List<ReferralHospitalModel> ReferralHospital { get; set; }

        public List<HospitalAttendedModel> HospitalAttended { get; set; }

        public List<SocialWorkAttendanceModel> SocialWorkAttendance { get; set; }

        public List<PoliceAttendanceModel> PoliceAttendance { get; set; }

        public List<VictimServicesModel> VictimServices { get; set; }

        public List<MdeicalOnlyModel> MedicalOnly { get; set; }

        public List<EvidenceStoredModel> EvidenceStored { get; set; }

        public List<HIVMedsModel> HIVMeds { get; set; }

        public List<ReferredCBVSModel> ReferredToCBVS { get; set; }

        public List<PoliceReportedModel> PoliceReported { get; set; }

        public List<ThirdPartyReportModel> ThirdPartyReport { get; set; }

        public List<BadDateReportModel> BadDateReport { get; set; }

        public int NumberTransportsProvided { get; set; }

        public bool ReferredToNursePractitioner { get; set; }
    }
}