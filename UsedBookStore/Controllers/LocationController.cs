using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UsedBookStore.Controllers
{
    public class LocationController : ApiController
    {

        [HttpGet]
        [Route("api/Location/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = LocationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/Location/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = LocationService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [Route("api/Location/add")]
        [HttpPost]
        public HttpResponseMessage Add(LocationDTO obj)
        {
            var data = LocationService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/Location/update")]
        public HttpResponseMessage Update(LocationDTO obj)
        {
            var data = LocationService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/Location/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = EventService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


    }
}
