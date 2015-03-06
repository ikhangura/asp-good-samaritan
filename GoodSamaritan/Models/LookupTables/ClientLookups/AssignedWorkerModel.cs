using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.LookupTables
{
    public class AssignedWorkerModel
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int AssignedWorkerId { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Assigned Worker")]
        public string AssignedWorker { get; set; }

        public List<ClientModel> Client { get; set; }
    }
}