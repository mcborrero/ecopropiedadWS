﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using wsPrueba.Models;

namespace wsPrueba.Controllers
{
    public class getDetailsPlacesController : ApiController
    {

        [ResponseType(typeof(sp_getDetailsPlaces_Result))]
        public HttpResponseMessage sp_getDetailsPlaces_Result(int IDPlace)
        {
            var objdemoentity = new EcoPropiedadEntities();

            List<sp_getDetailsPlaces_Result> obtorercord = objdemoentity.sp_getDetailsPlaces(IDPlace).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, obtorercord.ToList());

        }
    }
}
