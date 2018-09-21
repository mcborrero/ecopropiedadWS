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
    public class changePasswordController : ApiController
    {
        [ResponseType(typeof(sp_changePassword_Result))]
        public HttpResponseMessage sp_changePassword_Result(int IDUser, string newPassword )
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_changePassword_Result> obtorercord = objdemoentity.sp_changePassword(IDUser, newPassword).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
