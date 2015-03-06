using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class HospitalAttendedModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int HospitalAttendedId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Hospital Attended")]
        public string HospitalAttended { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}