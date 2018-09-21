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
    public class getCommunitiesByUserController : ApiController
    {
        [ResponseType(typeof(sp_getCommunitiesByUser_Result))]
        public HttpResponseMessage sp_getCommunitiesByUser_Result(int idUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getCommunitiesByUser_Result> obtorercord = objdemoentity.sp_getCommunitiesByUser(idUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
