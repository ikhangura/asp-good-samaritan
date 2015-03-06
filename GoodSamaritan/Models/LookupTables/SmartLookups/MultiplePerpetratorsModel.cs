using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class MultiplePerpetratorsModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int MultiplePerpetratorsID { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Multiple Perpetrators")]
        public string MultiplePerpetrators { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}