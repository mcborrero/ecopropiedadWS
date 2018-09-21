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
    public class getDocumentsController : ApiController
    {
        [ResponseType(typeof(sp_getDocumentsByUser_Result))]
        public HttpResponseMessage sp_getDocumentsByUser_Result(int IDUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getDocumentsByUser_Result> obtorercord = objdemoentity.sp_getDocumentsByUser(IDUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }

        [ResponseType(typeof(sp_getDocumentsByCommunity_Result))]
        public HttpResponseMessage sp_getDocumentsByCommunity_Result(int IDCommunity)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getDocumentsByCommunity_Result> obtorercord = objdemoentity.sp_getDocumentsByCommunity(IDCommunity).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
