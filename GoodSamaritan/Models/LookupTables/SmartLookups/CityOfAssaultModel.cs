using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class CityOfAssaultModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int CityOfAssaultId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "City OF Assault")]
        public string CityOfAssault { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}