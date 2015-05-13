using Microsoft.AspNet.Mvc;
using aspnetcast.Models;
using System.Linq;
using System.Collections.Generic;
using aspnetcast.Data;

namespace aspnetcast.Controllers
{
    public class CasterController : Controller
	{
		private AppDbContext _db;

        public CasterController()
        {
            _db = new AppDbContext();
        }
        
        [HttpGet]
        [Route("api/casters")]
        public IEnumerable<Caster> Get()
        {
            var casters = _db.Casters.ToList();
            return casters;
        }
        
        [HttpPost]
        [Route("api/casters")]
        public Caster Post([FromBody] Caster caster)
        {
            _db.Casters.Add(caster);
            _db.SaveChanges();
            return caster;
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
	}
}