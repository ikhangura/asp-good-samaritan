using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class BadDateReportModel
    {
        [Key]
        public int BadDateReportId { get; set; }
        // kind of status
        public string BadDateReport { get; set; } 

        public List<SmartModel> Smart { get; set; }
    }
}