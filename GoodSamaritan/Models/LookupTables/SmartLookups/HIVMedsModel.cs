using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class HIVMedsModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int HIVMedsId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "HIV Meds")]
        public string HIVMeds { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}