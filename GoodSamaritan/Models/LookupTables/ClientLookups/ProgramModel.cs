using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class ProgramModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ProgramId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Program")]
        public string Program { get; set; }

        public List<ClientModel> Client { get; set; }

    }
}