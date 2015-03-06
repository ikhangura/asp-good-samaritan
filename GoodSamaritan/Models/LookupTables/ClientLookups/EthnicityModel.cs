using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class EthnicityModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int EthnicityId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Ethnicity")]
        public string Ethnicity { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}