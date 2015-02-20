using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class VictimServicesModel
    {
        [Key]
        public int VictimServicesID { get; set; }
        public string VictimServices { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}