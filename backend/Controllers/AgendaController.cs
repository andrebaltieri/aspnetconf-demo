using Microsoft.AspNet.Mvc;
using aspnetcast.Models;
using System;
using System.Collections.Generic;

namespace aspnetcast.Controllers
{
    public class AgendaController : Controller
    {
        [HttpGet]
        [Route("api/agenda")]
        public IEnumerable<Agenda> Get()
        {
            var agendas = new List<Agenda>();
            agendas.Add(new Agenda
            {
                Id = 0,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddHours(1),
                Title = "ASP.NET Conf"
            });

            return agendas;
        }
	}
}