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
    public class AuthorController : ApiController
    {
        [HttpGet]
        [Route("api/Author/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = AuthorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/Author/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AuthorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [Route("api/Author/add")]
        [HttpPost]
        public HttpResponseMessage Add(AuthorDTO obj)
        {
            var data = AuthorService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/Author/update")]
        public HttpResponseMessage Update(AuthorDTO obj)
        {
            var data = AuthorService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/Author/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = AuthorService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}
