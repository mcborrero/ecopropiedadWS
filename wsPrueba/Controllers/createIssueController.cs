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
    public class createIssueController : ApiController
    {
        [ResponseType(typeof(sp_createIssue_Result))]
        public HttpResponseMessage sp_createIssue_Result(int IDCommunity, string titleIssue, string descriptionIssue, string img1Issue, string img2Issue, int typeIssue)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_createIssue_Result> obtorercord = objdemoentity.sp_createIssue(IDCommunity, titleIssue, descriptionIssue, img1Issue, img2Issue, typeIssue).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
