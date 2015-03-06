using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class ReferralHospitalModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ReferralHospitalID { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Referral Hospital")]
        public string ReferralHospital { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}