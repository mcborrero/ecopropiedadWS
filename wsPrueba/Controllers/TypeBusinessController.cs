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
    public class TypeBusinessController : ApiController
    {
   
        [ResponseType(typeof(sp_typeBusiness_Result))]
        public HttpResponseMessage sp_typeBusiness_Result()
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_typeBusiness_Result> obtorercord = objdemoentity.sp_typeBusiness().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
