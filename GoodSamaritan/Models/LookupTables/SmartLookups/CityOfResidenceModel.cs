using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class CityOfResidenceModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int CityOfResidenceId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "City Of Residence")]
        public string CityOfResidence { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}