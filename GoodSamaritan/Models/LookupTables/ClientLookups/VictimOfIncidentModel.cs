using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class VictimOfIncidentModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int VictimOFIncidentId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Victim Of Incident")]
        public string VictimOfIncident { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}