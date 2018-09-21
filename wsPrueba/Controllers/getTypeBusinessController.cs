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
    public class getTypeBusinessController : ApiController
    {
        [ResponseType(typeof(sp_getTypeBusiness_Result))]
        public HttpResponseMessage sp_getTypeBusiness_Result()
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getTypeBusiness_Result> obtorercord = objdemoentity.sp_getTypeBusiness().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
