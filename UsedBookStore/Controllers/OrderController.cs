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
    public class OrderController : ApiController
    {
        [HttpGet]
        [Route("api/order/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = OrderService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpGet]
        [Route("api/order/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = OrderService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/order/add")]
        [HttpPost]
        public HttpResponseMessage Add(OrderDTO obj)
        {
            var data = OrderService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/order/update")]
        public HttpResponseMessage Update(OrderDTO obj)
        {
            var data = OrderService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/order/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = OrderService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
