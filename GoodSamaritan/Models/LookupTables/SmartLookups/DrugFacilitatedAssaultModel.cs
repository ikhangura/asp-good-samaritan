using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class DrugFacilitatedAssaultModel
    {
        [Key]
        public int DrugFacilitatedAssaultId { get; set; }
        public string DrugFacilitatedAssault { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}