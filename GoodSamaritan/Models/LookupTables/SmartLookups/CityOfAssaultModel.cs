using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class CityOfAssaultModel
    {
        [Key]
        public string CityOfAssault { get; set; }

        public SmartModel Smart { get; set; }
    }
}