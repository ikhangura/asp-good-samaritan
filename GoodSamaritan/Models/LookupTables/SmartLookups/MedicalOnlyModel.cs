using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class MedicalOnlyModel
    {
        [Key]
        public int MedicalOnlyId { get; set; }
        public string MedicalOnly { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}