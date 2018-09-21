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
    public class getImagesPlaceController : ApiController
    {
        [ResponseType(typeof(sp_getImagesPlace_Result))]
        public HttpResponseMessage sp_getImagesPlace_Result(int IDPlace)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getImagesPlace_Result> obtorercord = objdemoentity.sp_getImagesPlace(IDPlace).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
