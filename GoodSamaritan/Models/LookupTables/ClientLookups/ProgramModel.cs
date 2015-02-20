using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ProgramModel
    {
        [Key]
        public int ProgramId { get; set; }
        public string Program { get; set; }

        public List<ClientModel> Client { get; set; }

    }
}