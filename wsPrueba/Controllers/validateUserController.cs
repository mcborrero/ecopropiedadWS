using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using wsPrueba.Models;

namespace wsPrueba.Controllers
{



    public class sp_validateUserController : ApiController
    {
        [ResponseType (typeof(sp_validateUser_Result))]
        public HttpResponseMessage sp_validateUser_Result(string codeUser, string passwordUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_validateUser_Result> obtorercord = objdemoentity.sp_validateUser(codeUser,passwordUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }

        [ResponseType(typeof(sp_validateUserWithMail_Result))]
        public HttpResponseMessage sp_validateUserWithMail_Result(string emailUser, string passwordUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_validateUserWithMail_Result> obtorercord = objdemoentity.sp_validateUserWithMail(emailUser, passwordUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }


}