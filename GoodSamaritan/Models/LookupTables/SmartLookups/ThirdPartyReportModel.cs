using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class ThirdPartyReportModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ThirdPartyReportID { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Third Party Report")]
        public string ThirdPartyReport { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}