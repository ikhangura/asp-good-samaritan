using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class ServiceModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ServiceId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Service")]
        public string Service { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}