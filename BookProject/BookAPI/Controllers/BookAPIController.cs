using BookAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return Request.CreateResponse(HttpStatusCode.OK, _repo.GetList());
        }
    }
}
