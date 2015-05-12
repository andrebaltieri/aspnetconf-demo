using System;

namespace aspnetcast.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
		public string Title { get; set; }
    }
}