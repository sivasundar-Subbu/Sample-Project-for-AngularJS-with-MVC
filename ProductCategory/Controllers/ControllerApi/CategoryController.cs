using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductCategory.Models;

namespace ProductCategory.Controllers.ControllerApi
{
    public class CategoryController : ApiController
    {

        // GET api/<controller>
        [HttpGet()]
        public IEnumerable<Category> Get()
        {
            ProductViewModel vmPvm = new ProductViewModel();
            vmPvm.LoadSearchCategory();
            if (vmPvm.SearchCategories.Count > 0)
            {
                return vmPvm.SearchCategories.ToList();
            }
            else
            {
                return null;
            }
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}