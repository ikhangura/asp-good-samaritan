using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ThirdPartyReportModel
    {
        [Key]
        public string ThirdPartyReport { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}