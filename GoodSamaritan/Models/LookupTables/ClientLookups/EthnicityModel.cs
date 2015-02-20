using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class EthnicityModel
    {
        [Key]
        public int EthnicityId { get; set; }
        public string Ethnicity { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}