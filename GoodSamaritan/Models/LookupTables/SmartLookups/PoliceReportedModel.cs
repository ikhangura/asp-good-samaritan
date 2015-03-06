using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class PoliceReportedModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int PoliceReportedId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Police Reported")]
        public string PolicReported { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}