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
    public class setDataUserController : ApiController
    {
        [ResponseType(typeof(sp_setDataUser_Result))]
        public HttpResponseMessage sp_setDataUser_Result(int idUser,string newPassword, int notifyMail, string emailUser, string phoneNumber)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_setDataUser_Result> obtorercord = objdemoentity.sp_setDataUser(idUser,newPassword ,notifyMail, emailUser ,phoneNumber ).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
