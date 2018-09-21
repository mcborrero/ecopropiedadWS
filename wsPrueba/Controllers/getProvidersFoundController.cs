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
    public class getProvidersFoundController : ApiController
    {
        [ResponseType(typeof(sp_getProvidersFound_Result))]
        public HttpResponseMessage sp_getProvidersFound_Result(string searchtext)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getProvidersFound_Result> obtorercord = objdemoentity.sp_getProvidersFound(searchtext).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
