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
    public class setProviderController : ApiController
    {

        [ResponseType(typeof(sp_setProvider_Result))]
        public HttpResponseMessage sp_setProvider_Result( string nameProvider, int typeProvider, string emailProvider ,
  string addressProvider, string latitudeProvider, string altitudeProvider, string desriptionProvider, string imageProvider,
  int cityProvider, string contactProvider, int typephone1Provider, string numberphone1Provider, int typephone2Provider,
  string numberphone2Provider)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_setProvider_Result> obtorercord = objdemoentity.sp_setProvider(nameProvider, typeProvider, emailProvider,
  addressProvider, latitudeProvider, altitudeProvider, desriptionProvider, imageProvider,
  cityProvider, contactProvider, typephone1Provider, numberphone1Provider,  typephone2Provider,
  numberphone2Provider).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
