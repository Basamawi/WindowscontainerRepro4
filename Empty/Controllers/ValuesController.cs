using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empty.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {   try
            {

            Entities DB = new Entities();
            var list =  DB.EMPs.ToList();
            return new string[] { list.ToList()[0].Name, list.ToList()[1].Name };
            }
            catch (System.Exception e)
            {
               Console.WriteLine(e.ToString());
                return new string[] { e.ToString() };
            }
             return new string[] { "Error!" };
        }

        // GET api/values/5
        public string Get(int id)
        {
          
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
