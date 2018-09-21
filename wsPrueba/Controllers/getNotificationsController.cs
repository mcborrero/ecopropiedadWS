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
    public class getNotificationsController : ApiController
    {
        [ResponseType(typeof(sp_getNotificationsByUser_Result))]
        public HttpResponseMessage sp_getNotificationsByUser_Result(int IDUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getNotificationsByUser_Result> obtorercord = objdemoentity.sp_getNotificationsByUser(IDUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }

        [ResponseType(typeof(sp_getNotificationsByID_Result))]
        public HttpResponseMessage sp_getNotificationsByID_Result(int IDNotification, int IDUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getNotificationsByID_Result> obtorercord = objdemoentity.sp_getNotificationsByID(IDNotification, IDUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
