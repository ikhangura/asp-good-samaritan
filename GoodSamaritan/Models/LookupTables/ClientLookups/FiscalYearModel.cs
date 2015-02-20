using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class FiscalYearModel
    {
        [Key]
        public int FicalYearId { get; set; }
        public string FiscalYear { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}