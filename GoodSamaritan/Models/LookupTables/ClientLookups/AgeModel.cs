using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class AgeModel
    {
        [Key]
        public int AgeId { get; set; }
        public string Age { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}