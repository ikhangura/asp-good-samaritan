using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class CrisisModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int CrisisId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Crisis")]
        public string Crisis { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}