using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models;



namespace GoodSamaritan.Controllers
{
    [Authorize(Roles="Administrator, Worker")]
    public class MVCReportsViewController : Controller
    {

        private GoodSamaritanModel db = new GoodSamaritanModel();


        // GET: MVCReportsView
        public ActionResult Index()
        {
            return View();
        }



        // POST: MVCReportsView/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            var month = collection["Month"];
            var year = collection["Year"];

            Debug.WriteLine(year);
            Debug.WriteLine(month);

            //generate report logic


            var numOpen = (from openStatus in db.ClientModel
                           where openStatus.StatusOfFile.StatusOfFile == "Open"
                           select openStatus).Count();
            var numClosed = (from openStatus in db.ClientModel
                             where openStatus.StatusOfFile.StatusOfFile == "Closed"
                             select openStatus).Count();
            var numReOpened = (from openStatus in db.ClientModel
                               where openStatus.StatusOfFile.StatusOfFile == "Reopened"
                               select openStatus).Count();

            var programCrisis = (from crisis in db.ClientModel
                                 where crisis.Program.Program == "Crisis"
                                 select crisis).Count();
            var programCourt = (from crisis in db.ClientModel
                                where crisis.Program.Program == "Court"
                                select crisis).Count();
            var programSmart = (from crisis in db.ClientModel
                                where crisis.Program.Program == "SMART"
                                select crisis).Count();
            var programDVU = (from crisis in db.ClientModel
                              where crisis.Program.Program == "DVU"
                              select crisis).Count();
            var programMCFD = (from crisis in db.ClientModel
                               where crisis.Program.Program == "MCFD"
                               select crisis).Count();

            var genderMale = (from gender in db.ClientModel
                              where gender.Gender == "M"
                              select gender).Count();
            var genderFemale = (from gender in db.ClientModel
                                where gender.Gender == "F"
                                select gender).Count();
            var genderTrans = (from gender in db.ClientModel
                               where gender.Gender == "Trans"
                               select gender).Count();

            var ageAdult = (from age in db.ClientModel
                            where age.Age.Age == "Adult(>24<65)"
                            select age).Count();
            var ageTween = (from age in db.ClientModel
                            where age.Age.Age == "Youth(>12<19)"
                            select age).Count();
            var ageYouth = (from age in db.ClientModel
                            where age.Age.Age == "Youth(>18<25)"
                            select age).Count();
            var ageChild = (from age in db.ClientModel
                            where age.Age.Age == "Child(<13)"
                            select age).Count();
            var ageSenior = (from age in db.ClientModel
                             where age.Age.Age == "Senior(>64)"
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
