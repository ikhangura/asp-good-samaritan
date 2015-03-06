using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class DuplicateFileModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int DuplicateFileId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Duplicate File")]
        public string DuplicateFile { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}