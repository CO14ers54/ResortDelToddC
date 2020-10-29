using Microsoft.AspNetCore.Mvc;
using RestAPI_Endpoint_HockeyExample.Data;
using RestAPI_Endpoint_HockeyExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_Endpoint_HockeyExample.Controllers
{
    [Route("api/hockeyapi")]
    [ApiController]
    public class HockeyPlayersController : ControllerBase
    {
        private readonly IHockeyApiRepo _repository;
        //private readonly MockHockeyApiRepo _repository = new MockHockeyApiRepo();
        public HockeyPlayersController(IHockeyApiRepo repository )
        {
            _repository = repository;
        }

        // GET api/hockeyapi
        [HttpGet]
        public ActionResult <IEnumerable<Player>> GetAllPlayers()
        {
            var players = _repository.GetAllPlayers();

            return Ok(players);
        }

        // GET api/hockeyapi/{id}
        [HttpGet("{id}")]
        public ActionResult <Player> GetPlayer(int id)
        {
            Player player = _repository.GetPlayer(id);

            return Ok(player);
        }

    }
}
