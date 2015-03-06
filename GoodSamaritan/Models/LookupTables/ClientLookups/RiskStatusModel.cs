using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class RiskStatusModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int RiskStatusId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Risk Status")]
        public string RiskStatus { get; set; }


        public List<ClientModel> Client { get; set; }
    }
}