using RestAPI_Endpoint_HockeyExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_Endpoint_HockeyExample.Data
{
    public class MySqlHockeyApiRepo : IHockeyApiRepo
    {
        private readonly HockeyApiDbContext _context;

        public MySqlHockeyApiRepo(HockeyApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }

        /*
        public IEnumerable<PlayerWithCurrentTeam> GetAllPlayersWithCurrentTeam()
        {
            throw new System.NotImplementedException();
            //return _context.Players.ToList();
        }
        */

        public Player GetPlayer(int id)
        {
            return _context.Players.FirstOrDefault(p => p.Id == id);
        }

        /*
        public PlayerWithCurrentTeam GetPlayerWithCurrentTeam(int id)
        {
            throw new System.NotImplementedException();
            //return _context.PlayersWithCurrentTeam.FirstOrDefault(p => p.Id == id);
        }
        */

        public IEnumerable<Team> GetAllTeams() 
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Country> GetAllCountries()
        {
            throw new System.NotImplementedException();
        }


    }
}
