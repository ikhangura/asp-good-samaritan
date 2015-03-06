using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class BadDateReportModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int BadDateReportId { get; set; }
        // kind of status
        [Required]
        [MaxLength(500)]
        [Display(Name = "Bad Date Report")]
        public string BadDateReport { get; set; } 

        public List<SmartModel> Smart { get; set; }
    }
}