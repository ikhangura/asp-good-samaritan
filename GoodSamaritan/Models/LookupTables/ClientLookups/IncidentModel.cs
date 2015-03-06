using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class IncidentModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int IncidentId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Incident")]
        public string Incident { get; set; }

        public List<ClientModel> Client { get; set; }

    }
}