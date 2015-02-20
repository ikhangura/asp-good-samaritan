using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class AssignedWorkerModel
    {
        [Key]
        public int AssignedWorkerId { get; set; }
        public string AssignedWorker { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}