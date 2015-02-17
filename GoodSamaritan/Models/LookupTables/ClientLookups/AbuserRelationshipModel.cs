using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class AbuserRelationshipModel
    {
        [Key]
        public string AbuserRelationship { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}