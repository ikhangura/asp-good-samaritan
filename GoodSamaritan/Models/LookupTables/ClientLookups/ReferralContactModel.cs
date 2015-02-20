using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ReferralContactModel
    {
        [Key]
        public int ReferralContactId { get; set; }
        public string ReferralContact { get; set; }

        public List<ClientModel> Client { get; set; }

    }
}