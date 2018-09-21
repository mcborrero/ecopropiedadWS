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
    public class CitiesbyCountryController : ApiController
    {
        [ResponseType(typeof(sp_getCitiesbyCountry_Result))]
        public HttpResponseMessage sp_getCitiesbyCountry_Result(string IDCountry)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getCitiesbyCountry_Result> obtorercord = objdemoentity.sp_getCitiesbyCountry(IDCountry ).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
