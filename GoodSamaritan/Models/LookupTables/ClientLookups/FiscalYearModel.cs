using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class FiscalYearModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int FicalYearId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Fiscal Year")]
        public string FiscalYear { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}