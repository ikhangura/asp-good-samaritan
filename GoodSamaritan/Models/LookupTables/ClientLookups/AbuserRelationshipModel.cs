using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class AbuserRelationshipModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int AbuserRelationShipId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Abuser Relationship")]
        public string AbuserRelationship { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}