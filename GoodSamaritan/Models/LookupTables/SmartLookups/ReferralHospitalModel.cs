using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ReferralHospitalModel
    {
        [Key]
        public int ReferralHospitalID { get; set; }
        public string ReferralHospital { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}