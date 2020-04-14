using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApidemo2.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> Str = new List<string> { "Hello","Campus minds" };
        
        // GET api/values
        public IEnumerable<string> Get()
        {

            return Str;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return Str[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            Str.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            Str[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Str.RemoveAt(id);
        }
    }
}
