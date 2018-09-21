using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using wsPrueba.Models;

namespace wsPrueba.Controllers
{
    public class IssuesController : ApiController
    {
        [ResponseType(typeof(sp_getIssuesByUser_Result))]
        public HttpResponseMessage sp_getIssuesByUser_Result(int IDCommunity)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getIssuesByUser_Result> obtorercord = objdemoentity.sp_getIssuesByUser(IDCommunity).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }

    }
}
