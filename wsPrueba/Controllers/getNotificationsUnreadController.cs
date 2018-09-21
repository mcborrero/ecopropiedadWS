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
    public class getNotificationsUnreadController : ApiController
    {
        [ResponseType(typeof(sp_getNotificationsUnread_Result))]
        public HttpResponseMessage sp_getNotificationsUnread_Result(int IDUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getNotificationsUnread_Result> obtorercord = objdemoentity.sp_getNotificationsUnread(IDUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
