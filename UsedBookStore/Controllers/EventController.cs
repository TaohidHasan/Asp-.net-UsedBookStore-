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
    public class EventController : ApiController
    {

        [HttpGet]
        [Route("api/Event/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = EventService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/Event/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = EventService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [Route("api/Event/add")]
        [HttpPost]
        public HttpResponseMessage Add(EventDTO obj)
        {
            var data = EventService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/Event/update")]
        public HttpResponseMessage Update(EventDTO obj)
        {
            var data = EventService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/Event/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = EventService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/Event/Address/{cat}/date/{date}")]
        public HttpResponseMessage GetByCatDate(string cat, DateTime date)
        {
            try
            {
                var data = EventService.GetByAddressDate(cat, date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
