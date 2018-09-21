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
    public class getCountNotificationsUnreadController : ApiController
    {
        [ResponseType(typeof(sp_getCountNotificationsUnread_Result))]
        public HttpResponseMessage sp_getCountNotificationsUnread_Result(int idUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getCountNotificationsUnread_Result> obtorercord = objdemoentity.sp_getCountNotificationsUnread(idUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
