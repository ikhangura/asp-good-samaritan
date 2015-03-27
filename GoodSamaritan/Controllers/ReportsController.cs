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



            // put results into object

            ReportSearchReply success = new ReportSearchReply()
            {
                status = JObject.Parse("{ 'open' : '" + numOpen + "', 'closed': '" + numClosed + "', 'reopened': '" + numReOpened + "' }")
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
