using GoodSamaritan.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;


namespace GoodSamaritan.Controllers
{
    [Authorize]
    public class ReportsController : ApiController
    {

        private GoodSamaritanModel db = new GoodSamaritanModel();


        private int convertYearToId(String fiscalYear)
        {
            return (from fiscalYears in db.FiscalYearModel
                    where fiscalYears.FiscalYear == fiscalYear
                    select fiscalYears.FicalYearId).FirstOrDefault();
        }

        [HttpPost]
        // POST: api/Reports
        public IHttpActionResult PostSearch([FromBody] FormDataCollection form)
        {

            Debug.WriteLine(form.Get("year"));
            Debug.WriteLine(form.Get("month"));

            ReportSearch search = new ReportSearch()
            {
                year = Convert.ToInt32(form["year"]),
                month = Convert.ToInt32(form["month"])
            };

            if (search == null)
            {
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest));
            }

            //int fiscalYearId = convertYearToId(search.year.ToString());
            int fiscalYearId = search.year;

            var numOpen = (from openStatus in db.ClientModel
                           where openStatus.StatusOfFile.StatusOfFile == "Open"
                           && openStatus.Month == search.month
                           && openStatus.FiscalYearId == fiscalYearId
                           select openStatus).Count();
            var numClosed = (from openStatus in db.ClientModel
                             where openStatus.StatusOfFile.StatusOfFile == "Closed"
                             && openStatus.Month == search.month
                           && openStatus.FiscalYearId == fiscalYearId
                             select openStatus).Count();
            var numReOpened = (from openStatus in db.ClientModel
                               where openStatus.StatusOfFile.StatusOfFile == "Reopened"
                               && openStatus.Month == search.month
                           && openStatus.FiscalYearId == fiscalYearId
                               select openStatus).Count();

            var programCrisis = (from crisis in db.ClientModel
                                 where crisis.Program.Program == "Crisis"
                                 && crisis.Month == search.month
                           && crisis.FiscalYearId == fiscalYearId
                                 select crisis).Count();
            var programCourt = (from crisis in db.ClientModel
                                where crisis.Program.Program == "Court"
                                && crisis.Month == search.month
                           && crisis.FiscalYearId == fiscalYearId
                                select crisis).Count();
            var programSmart = (from crisis in db.ClientModel
                                where crisis.Program.Program == "SMART"
                                && crisis.Month == search.month
                           && crisis.FiscalYearId == fiscalYearId
                                select crisis).Count();
            var programDVU = (from crisis in db.ClientModel
                              where crisis.Program.Program == "DVU"
                              && crisis.Month == search.month
                           && crisis.FiscalYearId == fiscalYearId
                              select crisis).Count();
            var programMCFD = (from crisis in db.ClientModel
                               where crisis.Program.Program == "MCFD"
                               && crisis.Month == search.month
                           && crisis.FiscalYearId == fiscalYearId
                               select crisis).Count();

            var genderMale = (from gender in db.ClientModel
                              where gender.Gender == "M"
                              && gender.Month == search.month
                           && gender.FiscalYearId == fiscalYearId
                              select gender).Count();
            var genderFemale = (from gender in db.ClientModel
                                where gender.Gender == "F"
                                && gender.Month == search.month
                           && gender.FiscalYearId == fiscalYearId
                                select gender).Count();
            var genderTrans = (from gender in db.ClientModel
                               where gender.Gender == "Trans"
                               && gender.Month == search.month
                           && gender.FiscalYearId == fiscalYearId
                               select gender).Count();

            var ageAdult = (from age in db.ClientModel
                            where age.Age.Age == "Adult(>24<65)"
                            && age.Month == search.month
                           && age.FiscalYearId == fiscalYearId
                            select age).Count();
            var ageTween = (from age in db.ClientModel
                            where age.Age.Age == "Youth(>12<19)"
                            && age.Month == search.month
                           && age.FiscalYearId == fiscalYearId
                            select age).Count();
            var ageYouth = (from age in db.ClientModel
                            where age.Age.Age == "Youth(>18<25)"
                            && age.Month == search.month
                           && age.FiscalYearId == fiscalYearId
                            select age).Count();
            var ageChild = (from age in db.ClientModel
                            where age.Age.Age == "Child(<13)"
                            && age.Month == search.month
                           && age.FiscalYearId == fiscalYearId
                            select age).Count();
            var ageSenior = (from age in db.ClientModel
                             where age.Age.Age == "Senior(>64)"
                             && age.Month == search.month
                           && age.FiscalYearId == fiscalYearId
                             select age).Count();



            // put results into object

            ReportSearchReply success = new ReportSearchReply()
            {
                status = JObject.Parse("{ 'open' : '" + numOpen + "', 'closed': '" + numClosed + "', 'reopened': '" + numReOpened + "' }"),
                program = JObject.Parse("{ 'crisis' : '" + programCrisis + "', 'court': '" + programCourt + "', 'smart': '" + programSmart + "', 'dvu': '" + programDVU + "', 'mcfd': '" + programMCFD + "' }"),
                gender = JObject.Parse("{ 'female': '" + genderFemale + "', 'male' : '" + genderMale + "', 'trans': '" + genderTrans + "' }"),
                age = JObject.Parse("{ 'adult': '" + ageAdult + "', 'youth1825': '" + ageTween + "', 'youth1219': '" + ageYouth + "', 'child': '" + ageChild + "', 'senior': '" + ageSenior + "' }")
            };


            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, success));


        }
    }
}
