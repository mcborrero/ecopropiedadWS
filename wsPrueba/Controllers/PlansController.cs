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
    public class PlansController : ApiController
    {
        [ResponseType(typeof(sp_getPlans_Result))]
        public HttpResponseMessage sp_getPlans_Result(int cityApply)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getPlans_Result> obtorercord = objdemoentity.sp_getPlans(cityApply).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
