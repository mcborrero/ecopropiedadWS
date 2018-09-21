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
    public class setReservationController : ApiController
    {
        [ResponseType(typeof(sp_setReservations_Result))]
        public HttpResponseMessage sp_setReservations_Result(int IDPlace, int IDUSer,  DateTime dateReserved ,DateTime dateEvent, string reason, int numberPeople, string time, string notes)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_setReservations_Result> obtorercord = objdemoentity.sp_setReservations(IDPlace,IDUSer,dateReserved,dateEvent,  reason,  numberPeople,  time,  notes).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
