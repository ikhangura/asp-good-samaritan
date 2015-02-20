using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.LookupTables
{
    public class StatusOfFileModel
    {
        [Key]
        public int StatusOfFileId { get; set; }
        public string StatusOfFile { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}