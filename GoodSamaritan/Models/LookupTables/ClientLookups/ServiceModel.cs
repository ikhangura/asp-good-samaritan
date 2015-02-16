using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ServiceModel
    {
        [Key]
        public string Service { get; set; }

        public ClientModel Client { get; set; }
    }
}