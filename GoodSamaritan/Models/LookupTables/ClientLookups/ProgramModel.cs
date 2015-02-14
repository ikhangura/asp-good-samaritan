using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class ProgramModel
    {
        public string Program { get; set; }

        public ClientModel Client { get; set; }
    }
}