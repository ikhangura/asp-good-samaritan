using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class DrugFacilitatedAssaultModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int DrugFacilitatedAssaultId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Drug Facilitated Assault")]
        public string DrugFacilitatedAssault { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}