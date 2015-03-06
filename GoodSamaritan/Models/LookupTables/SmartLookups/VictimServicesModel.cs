using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class VictimServicesModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int VictimServicesID { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Victim Services")]
        public string VictimServices { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}