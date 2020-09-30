using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NelsonProjects.Shared;

namespace NelsonProjects.Server.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            var listOfEvents = new List<Event>();

            listOfEvents.Add(new Event() { Date = new DateTime(2020, 12, 25), Description = "Test is True" });
            listOfEvents.Add(new Event() { Date = DateTime.Now, Description = "Test is false" });
            listOfEvents.Add(new Event() { Date = new DateTime(2020, 3, 15), Description = "Test is false" });

            return listOfEvents;
        }
    }
}
