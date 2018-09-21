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
    public class readNotificationController : ApiController
    {

        [ResponseType(typeof(sp_readNotification_Result))]
        public HttpResponseMessage sp_readNotification_Result(int IDNotification, int IDUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_readNotification_Result> obtorercord = objdemoentity.sp_readNotification(IDNotification, IDUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
