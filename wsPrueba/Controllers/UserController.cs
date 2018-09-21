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
    public class UserController : ApiController
    {
        [ResponseType(typeof(sp_getdataUser_Result))]
        public HttpResponseMessage sp_getdataUser_Result(string codeUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getdataUser_Result> obtorercord = objdemoentity.sp_getdataUser(codeUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }

        [ResponseType(typeof(sp_getdataUserByEmail_Result))]
        public HttpResponseMessage sp_getdataUserByEmail_Result(string emailUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getdataUserByEmail_Result> obtorercord = objdemoentity.sp_getdataUserByEmail(emailUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }

        [ResponseType(typeof(sp_getdataUserByID_Result))]
        public HttpResponseMessage sp_getdataUserByID_Result(int IDUser)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getdataUserByID_Result> obtorercord = objdemoentity.sp_getdataUserByID(IDUser).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
