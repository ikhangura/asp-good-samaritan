using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class RiskLevelModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int RiskLevelId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Risk Level")]
        public string RiskLevel { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}