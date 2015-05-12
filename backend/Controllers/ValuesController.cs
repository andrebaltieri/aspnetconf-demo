using Microsoft.AspNet.Mvc;

namespace aspnetcast.Controllers
{
    public class ValuesController : Controller
    {
        [HttpGet]
        [Route("api/values")]
        public string Get()
        {
            return "Hello";
        }
	}
}