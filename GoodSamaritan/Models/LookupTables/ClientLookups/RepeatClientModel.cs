using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class RepeatClientModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int RepeatClientId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Repeat Client")]
        public string RepeatClient { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}