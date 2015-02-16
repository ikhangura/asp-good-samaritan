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
        public string FamilyViolenceFile { get; set; }

        public ClientModel Client { get; set; }
    }
}