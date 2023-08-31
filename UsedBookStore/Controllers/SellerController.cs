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
    public class SellerController : ApiController
    {

        [HttpGet]
        [Route("api/seller/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = SellerRegistrationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/seller/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SellerRegistrationService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

      
        [Route("api/seller/add")]
        [HttpPost]
        public HttpResponseMessage Add(SellerRegistrationDTO obj)
        {
            var data = SellerRegistrationService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/seller/update")]
        public HttpResponseMessage Update(SellerRegistrationDTO obj)
        {
            var data = SellerRegistrationService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/seller/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = SellerRegistrationService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    
}
}
