using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prog6RpgMakerBackEnd.Controllers
{
    public class CharacterSheetController : ApiController
    {
        // GET: api/CharacterSheet
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CharacterSheet/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CharacterSheet
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CharacterSheet/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CharacterSheet/5
        public void Delete(int id)
        {
        }
    }
}
