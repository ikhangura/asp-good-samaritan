using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ReferredCBVSModel
    {
        [Key]
        public int ReferralCBVSID { get; set; }
        public string ReferredCBVS { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}