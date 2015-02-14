using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class AssignedWorkerModel
    {
        public string AssignedWorker { get; set; }

        public ClientModel Client { get; set; }
    }
}