using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestWebapi.Controllers
{
    [RoutePrefix("Product")]
    public class ProductController : ApiController
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // GET: api/Product
        public IHttpActionResult Get()
        {
            return Json(_productRepository.GetAll());
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
