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
    public class GenreController : ApiController
    {
        [HttpGet]
        [Route("api/Genre/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = GenreService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/Genre/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = GenreService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [Route("api/Genre/add")]
        [HttpPost]
        public HttpResponseMessage Add(GenreDTO obj)
        {
            var data = GenreService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/Genre/update")]
        public HttpResponseMessage Update(GenreDTO obj)
        {
            var data = GenreService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/Genre/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = GenreService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}
