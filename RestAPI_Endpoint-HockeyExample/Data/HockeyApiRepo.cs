using RestAPI_Endpoint_HockeyExample.Models;
using System;
using System.Collections.Generic;

namespace RestAPI_Endpoint_HockeyExample.Data
{
    public interface IHockeyApiRepo
    {
        IEnumerable<Player> GetAllPlayers();
        //IEnumerable<PlayerWithCurrentTeam> GetAllPlayersWithCurrentTeam();
        Player GetPlayer(int id);
        //PlayerWithCurrentTeam GetPlayerWithCurrentTeam(int id);
        IEnumerable<Team> GetAllTeams();
        IEnumerable<Country> GetAllCountries();
    }
}
