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
    public class CountriesController : ApiController
    {
        [ResponseType(typeof(sp_getCountries_Result))]
        public HttpResponseMessage sp_getCountries_Result()
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getCountries_Result> obtorercord = objdemoentity.sp_getCountries().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
