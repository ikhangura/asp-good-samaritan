using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class ReferralContactModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ReferralContactId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Referral Contact")]
        public string ReferralContact { get; set; }

        public List<ClientModel> Client { get; set; }

    }
}