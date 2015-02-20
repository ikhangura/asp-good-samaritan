using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class PoliceReportedModel
    {
        [Key]
        public int PoliceReportedId { get; set; }
        public string PolicReported { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}