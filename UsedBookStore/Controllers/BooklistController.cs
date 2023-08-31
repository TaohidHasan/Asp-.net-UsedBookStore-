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
    public class BooklistController : ApiController
    
    {
        [HttpGet]
        [Route("api/Book/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = BooklistService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/Book/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = BooklistService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/Book/name/{Author_Name}")]
        public HttpResponseMessage GetByAuthor_Name(string Author_Name)
        {
            try
            {
                var data = BooklistService.Get(Author_Name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/Book/cat/{cat}")]
        public HttpResponseMessage GetByCategory(string cat)
        {
            try
            {
                var data = BooklistService.Get(cat);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/Book/add")]
        [HttpPost]
        public HttpResponseMessage Add(BooklistDTO obj)
        {
            var data = BooklistService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/Book/update")]
        public HttpResponseMessage Update(BooklistDTO obj)
        {
            var data = BooklistService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/Book/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = BooklistService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}
