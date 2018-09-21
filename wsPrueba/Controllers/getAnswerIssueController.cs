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
    public class getAnswerIssueController : ApiController
    {
        [ResponseType(typeof(sp_getAnswersIssue_Result))]
        public HttpResponseMessage sp_getAnswersIssue_Result(int IDIssue)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getAnswersIssue_Result> obtorercord = objdemoentity.sp_getAnswersIssue(IDIssue).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
