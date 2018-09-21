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
    public class getReservationsByUserController : ApiController
    {
        [ResponseType(typeof(sp_getReservationsByUser_Result1))]
        public HttpResponseMessage sp_getReservationsByUser_Result1(int IDUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getReservationsByUser_Result1> obtorercord = objdemoentity.sp_getReservationsByUser(IDUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
