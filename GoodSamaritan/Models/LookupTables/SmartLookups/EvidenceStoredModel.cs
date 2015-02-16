using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class EvidenceStoredModel
    {
        [Key]
        public string EvidenceStored { get; set; }

        public SmartModel Smart { get; set; }

    }
}