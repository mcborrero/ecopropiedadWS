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
    public class getTypesController : ApiController
    {
        [ResponseType(typeof(sp_getTypes_Result1))]
        public HttpResponseMessage sp_getTypes_Result1(string applyTypes)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getTypes_Result1> obtorercord = objdemoentity.sp_getTypes(applyTypes).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
