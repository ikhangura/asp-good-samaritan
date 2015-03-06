using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class EvidenceStoredModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int EvidenceStoredId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Evidence Stored")]
        public string EvidenceStored { get; set; }

        public List<SmartModel> Smart { get; set; }

    }
}