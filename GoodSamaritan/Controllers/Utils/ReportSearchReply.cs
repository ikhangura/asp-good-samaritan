using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Controllers
{
    public class ReportSearchReply
    {
        public JObject status{ get; set; }

        public JObject program { get; set; }

        public JObject gender { get; set; }

        public JObject age { get; set; }

    }
}