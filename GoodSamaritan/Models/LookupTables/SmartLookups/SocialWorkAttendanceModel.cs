using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class SocialWorkAttendanceModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int SocalWorkAttendanceId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Social Work Attendance")]
        public string SocialWorkAttendance { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}