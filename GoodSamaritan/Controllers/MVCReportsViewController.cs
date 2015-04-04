using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;
using GoodSamaritan.Models.LookupTables;



namespace GoodSamaritan.Controllers
{
    [Authorize(Roles="Administrator, Worker, Reporter")]
    public class MVCReportsViewController : Controller
    {

        private GoodSamaritanModel db = new GoodSamaritanModel();

        private int convertYearToId(String fiscalYear)
        {
            return (from fiscalYears in db.FiscalYearModel
                    where fiscalYears.FiscalYear == fiscalYear
                    select fiscalYears.FicalYearId).FirstOrDefault();
        }

        // GET: MVCReportsView
        public ActionResult Index()
        {
            
            ViewBag.FiscalYearId = new SelectList(db.FiscalYearModel, "FicalYearId", "FiscalYear");
            return View();
        }



        // POST: MVCReportsView/Create
        [HttpPost]
        public ActionResult Create(ReportSearch search)
        {

            //var month = collection["Month"];
            //var year = collection["Year"];

            //Debug.WriteLine(year);
            //Debug.WriteLine(month);

            

            Debug.WriteLine(search.year);

            //generate report logic


            var numOpen = (from openStatus in db.ClientModel
                           where openStatus.StatusOfFile.StatusOfFile == "Open"
                           && openStatus.Month == search.month
                           && openStatus.FiscalYearId == search.year
                           select openStatus).Count();
            var numClosed = (from openStatus in db.ClientModel
                             where openStatus.StatusOfFile.StatusOfFile == "Closed"
                             && openStatus.Month == search.month
                           && openStatus.FiscalYearId == search.year
                             select openStatus).Count();
            var numReOpened = (from openStatus in db.ClientModel
                               where openStatus.StatusOfFile.StatusOfFile == "Reopened"
                               && openStatus.Month == search.month
                           && openStatus.FiscalYearId == search.year
                               select openStatus).Count();

            var programCrisis = (from crisis in db.ClientModel
                                 where crisis.Program.Program == "Crisis"
                                 && crisis.Month == search.month
                           && crisis.FiscalYearId == search.year
                                 select crisis).Count();
            var programCourt = (from crisis in db.ClientModel
                                where crisis.Program.Program == "Court"
                                && crisis.Month == search.month
                           && crisis.FiscalYearId == search.year
                                select crisis).Count();
            var programSmart = (from crisis in db.ClientModel
                                where crisis.Program.Program == "SMART"
                                && crisis.Month == search.month
                           && crisis.FiscalYearId == search.year
                                select crisis).Count();
            var programDVU = (from crisis in db.ClientModel
                              where crisis.Program.Program == "DVU"
                              && crisis.Month == search.month
                           && crisis.FiscalYearId == search.year
                              select crisis).Count();
            var programMCFD = (from crisis in db.ClientModel
                               where crisis.Program.Program == "MCFD"
                               && crisis.Month == search.month
                           && crisis.FiscalYearId == search.year
                               select crisis).Count();

            var genderMale = (from gender in db.ClientModel
                              where gender.Gender == "M"
                              && gender.Month == search.month
                           && gender.FiscalYearId == search.year
                              select gender).Count();
            var genderFemale = (from gender in db.ClientModel
                                where gender.Gender == "F"
                                && gender.Month == search.month
                           && gender.FiscalYearId == search.year
                                select gender).Count();
            var genderTrans = (from gender in db.ClientModel
                               where gender.Gender == "Trans"
                               && gender.Month == search.month
                           && gender.FiscalYearId == search.year
                               select gender).Count();

            var ageAdult = (from age in db.ClientModel
                            where age.Age.Age == "Adult(>24<65)"
                            && age.Month == search.month
                           && age.FiscalYearId == search.year
                            select age).Count();
            var ageTween = (from age in db.ClientModel
                            where age.Age.Age == "Youth(>12<19)"
                            && age.Month == search.month
                           && age.FiscalYearId == search.year
                            select age).Count();
            var ageYouth = (from age in db.ClientModel
                            where age.Age.Age == "Youth(>18<25)"
                            && age.Month == search.month
                           && age.FiscalYearId == search.year
                            select age).Count();
            var ageChild = (from age in db.ClientModel
                            where age.Age.Age == "Child(<13)"
                            && age.Month == search.month
                           && age.FiscalYearId == search.year
                            select age).Count();
            var ageSenior = (from age in db.ClientModel
                             where age.Age.Age == "Senior(>64)"
                             && age.Month == search.month
                           && age.FiscalYearId == search.year
                             select age).Count();


            //parse results back for the screen

            ViewBag.statusOpen = numOpen;
            ViewBag.statusClosed = numClosed;
            ViewBag.statusReOpened = numReOpened;

            ViewBag.programCrisis = programCrisis;
            ViewBag.programCourt = programCourt;
            ViewBag.programSmart = programSmart;
            ViewBag.programDVU = programDVU;
            ViewBag.programMCFD = programMCFD;

            ViewBag.genderMale = genderMale;
            ViewBag.genderFemale = genderFemale;
            ViewBag.genderTrans = genderTrans;

            ViewBag.ageAdult = ageAdult;
            ViewBag.ageTween = ageTween;
            ViewBag.ageYouth = ageYouth;
            ViewBag.ageChild = ageChild;
            ViewBag.ageSenior = ageSenior;

            return View("~/Views/MVCReportsView/Report.cshtml");
        }


    }
}
