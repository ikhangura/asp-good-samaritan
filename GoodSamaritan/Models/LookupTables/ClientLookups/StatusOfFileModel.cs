using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class StatusOfFileModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int StatusOfFileId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Status Of File")]
        public string StatusOfFile { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}