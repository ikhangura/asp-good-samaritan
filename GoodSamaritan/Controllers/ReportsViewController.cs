using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Worker, Reporter")]
    public class ReportsViewController : Controller
    {
        // GET: ReportsView -- FOR ANGULAR
        public ActionResult Index()
        {
            return View();
        }
    }
}