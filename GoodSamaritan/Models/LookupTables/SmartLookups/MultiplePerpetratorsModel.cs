using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class MultiplePerpetratorsModel
    {
        [Key]
        public string MultiplePerpetrators { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}