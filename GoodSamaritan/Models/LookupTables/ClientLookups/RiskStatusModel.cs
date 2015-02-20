using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class RiskStatusModel
    {
        [Key]
        public int RiskStatusId { get; set; }
        public string RiskStatus { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}