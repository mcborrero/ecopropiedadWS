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
    public class getProvidersByTypeController : ApiController
    {
        [ResponseType(typeof(sp_getProvidersByType_Result))]
        public HttpResponseMessage sp_getProvidersByType_Result(int IDType)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getProvidersByType_Result> obtorercord = objdemoentity.sp_getProvidersByType(IDType).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
