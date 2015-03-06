using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class PoliceAttendanceModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int PoliceAttendanceId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Police Attendance")]
        public string PolicAttendance { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}