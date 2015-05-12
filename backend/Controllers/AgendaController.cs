using Microsoft.AspNet.Mvc;
using aspnetcast.Models;
using System.Linq;
using System.Collections.Generic;
using aspnetcast.Data;

namespace aspnetcast.Controllers
{
    public class AgendaController : Controller
    {
        private AppDbContext _db;

        public AgendaController()
        {
            _db = new AppDbContext();
        }
        
        [HttpGet]
        [Route("api/agenda")]
        public IEnumerable<Agenda> Get()
        {
            var agendas = _db.Agendas.ToList();
            return agendas;
        }
        
        [HttpPost]
        [Route("api/agenda")]
        public Agenda Post([FromBody] Agenda agenda)
        {
            _db.Agendas.Add(agenda);
            _db.SaveChanges();
            return agenda;
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
	}
}