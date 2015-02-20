using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class FamilyViolenceModel
    {
        [Key]
        public int FamilyVolenceId { get; set; }
        public string FamilyViolenceFile { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}