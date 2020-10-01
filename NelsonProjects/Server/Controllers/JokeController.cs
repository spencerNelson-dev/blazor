using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NelsonProjects.Shared.DAL;
using NelsonProjects.Shared.Models;

namespace NelsonProjects.Server.Controllers
{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        private readonly IJokeData _db;

        public JokeController(IJokeData db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<JokeModel>> Get()
        {
           return await _db.GetJokes();
        }
    }
}
