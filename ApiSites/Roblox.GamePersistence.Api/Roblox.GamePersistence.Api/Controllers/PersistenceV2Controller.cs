using System;
using System.IO;
using System.Web.Mvc;
using System.Text.Json;

namespace Roblox.GamePersistence.Api.Controllers
{
    [RoutePrefix("v2/persistence")]
    public class PersistenceV2Controller : Controller
    {
        [Route("Help")]
        [HttpGet]
        public object Method() 
        {
            Stream req = Request.InputStream;

            req.Seek(0, SeekOrigin.Begin);
            string json = new StreamReader(req).ReadToEnd();
            object js = JsonSerializer.Deserialize<object>(json);
            return js; 
        }
    }
}