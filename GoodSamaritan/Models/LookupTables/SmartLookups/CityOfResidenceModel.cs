using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class CityOfResidenceModel
    {
        [Key]
        public string CityOfResidence { get; set; }

        public List<SmartModel> Smart { get; set; }
    }
}