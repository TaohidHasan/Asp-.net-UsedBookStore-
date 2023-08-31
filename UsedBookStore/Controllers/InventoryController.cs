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
    public class InventoryController : ApiController
    {
        [HttpGet]
        [Route("api/Inventory/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = InventoryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/Inventory/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = InventoryService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

     

        [Route("api/Inventory/add")]
        [HttpPost]
        public HttpResponseMessage Add(InventoryDTO obj)
        {
            var data = InventoryService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/Inventory/update")]
        public HttpResponseMessage Update(InventoryDTO obj)
        {
            var data = InventoryService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/Inventory/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = InventoryService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}

