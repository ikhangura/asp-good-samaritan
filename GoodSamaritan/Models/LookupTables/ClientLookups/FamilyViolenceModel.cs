using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class FamilyViolenceModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int FamilyVolenceId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Family Violence File")]
        public string FamilyViolenceFile { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}