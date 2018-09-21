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
    public class getPlacesToReserveController : ApiController
    {
        [ResponseType(typeof(sp_getPlacesToReserve_Result))]
        public HttpResponseMessage sp_getPlacesToReserve_Result(int IDCommunity)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getPlacesToReserve_Result> obtorercord = objdemoentity.sp_getPlacesToReserve(IDCommunity).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
        
    }
}
