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
    public class PaymentController : ApiController
    
        {
            [HttpGet]
            [Route("api/Payment/all")]
            public HttpResponseMessage All()
            {
                try
                {
                    var data = PaymentService.Get();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                }

            }

            [HttpGet]
            [Route("api/payment/get/{id}")]
            public HttpResponseMessage Get(int id)
            {
                try
                {
                    var data = PaymentService.Get(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                }
            }

            [Route("api/payment/add")]
            [HttpPost]
            public HttpResponseMessage Add(PaymentDTO obj)
            {
                var data = PaymentService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            [Route("api/payment/update")]
            public HttpResponseMessage Update(PaymentDTO obj)
            {
                var data = PaymentService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }

            [HttpDelete]
            [Route("api/payment/delete/{id}")]
            public HttpResponseMessage Delete(int id)
            {
                var data = PaymentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
        }
    }
