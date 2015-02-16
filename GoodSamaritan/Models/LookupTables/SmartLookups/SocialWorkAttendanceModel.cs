using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class SocialWorkAttendanceModel
    {
        [Key]
        public string SocialWorkAttendance { get; set; }

        public SmartModel Smart { get; set; }
    }
}