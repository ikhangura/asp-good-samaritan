using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class ReferralSourceModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ReferralSourceId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Referral Source")]
        public string ReferralSource { get; set; }

        public List<ClientModel> Client { get; set; }

    }
}