using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ReferralContactModel
    {
        public string ReferralContact { get; set; }

        public ClientModel Client { get; set; }
    }
}