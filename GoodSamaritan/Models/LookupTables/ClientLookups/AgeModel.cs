using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class AgeModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int AgeId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Age")]
        public string Age { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}