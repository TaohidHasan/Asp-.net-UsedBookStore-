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
    public class BuyerController : ApiController
    {
        [HttpGet]
        [Route("api/buyer/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = BuyerRegistrationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/allBooks")]
        public HttpResponseMessage AllBooks()
        {
            try
            {
                var data = BuyerRegistrationService.GetBooks();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpGet]
        [Route("api/buyer/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = BuyerRegistrationService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/buyer/add")]
        [HttpPost]
        public HttpResponseMessage Add(BuyerRegistrationDTO obj)
        {
            var data = BuyerRegistrationService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/buyer/update")]
        public HttpResponseMessage Update(BuyerRegistrationDTO obj)
        {
            var data = BuyerRegistrationService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/buyer/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = BuyerRegistrationService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}