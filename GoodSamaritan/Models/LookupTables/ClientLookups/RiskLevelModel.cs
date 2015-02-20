using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class RiskLevelModel
    {
        [Key]
        public int RiskLevelId { get; set; }
        public string RiskLevel { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}