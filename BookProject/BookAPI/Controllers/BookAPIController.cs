using BookAPI.Models;
using BookAPI.Repository;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookAPI.Controllers
{
    public class BookAPIController : ApiController
    {
        IBookRepo _repo = new BookRepo(); 
        [HttpGet]
        public HttpResponseMessage GetBookList()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetList());

            }
            catch(Exception ex)
            {
                throw ex;
            }
      }
        [HttpPost]
        public HttpResponseMessage GetByID([FromBody]int i)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.GetByID(i));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public HttpResponseMessage SaveModify(Book _obj)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repo.SaveModify(_obj));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
