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
    public class setAnswerIssueController : ApiController
    {
        [ResponseType(typeof(sp_setAnswerIssue_Result))]
        public HttpResponseMessage sp_setAnswerIssue_Result(int IDIssue, string IDUser, string messageAnswer)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_setAnswerIssue_Result> obtorercord = objdemoentity.sp_setAnswerIssue(IDIssue, IDUser, messageAnswer).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
