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
    public class getProviderController : ApiController
    {

        [ResponseType(typeof(sp_getProvider_Result))]
        public HttpResponseMessage sp_getProvider_Result(int IDProvider)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getProvider_Result> obtorercord = objdemoentity.sp_getProvider(IDProvider).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }

    }
}
