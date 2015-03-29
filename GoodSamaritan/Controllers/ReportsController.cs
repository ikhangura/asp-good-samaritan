using GoodSamaritan.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoodSamaritan.Controllers
{
    [Authorize]
    public class ReportsController : ApiController
    {

        private GoodSamaritanModel db = new GoodSamaritanModel();

        // GET: api/Reports
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Reports/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        // POST: api/Reports
        public IHttpActionResult PostSearch([FromBody]ReportSearch search)
        {

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

        // PUT: api/Reports/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reports/5
        public void Delete(int id)
        {
        }
    }
}
