using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class MedicalOnlyModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int MedicalOnlyId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Medical Only")]
        public string MedicalOnly { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}