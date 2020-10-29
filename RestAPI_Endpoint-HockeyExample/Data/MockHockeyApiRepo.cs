using RestAPI_Endpoint_HockeyExample.Models;
using System;
using System.Collections.Generic;

namespace RestAPI_Endpoint_HockeyExample.Data
{
    public class MockHockeyApiRepo : IHockeyApiRepo
    {
        public IEnumerable<Player> GetAllPlayers()
        {
            var players = new List<Player>();

            Player player1 = new Player
            {
                Id = 0,
                NameFirst = "Todd",
                NameMiddle = "John",
                NameLast = "Christensen",
                HeightFeet = 6,
                HeightInches = 4,
                Weight = 220,
                ShotSide = "Right",
                Born = new DateTime(1965, 10, 19)
            };

            Player player2 = new Player
            {
                Id = 1,
                NameFirst = "Gus",
                NameMiddle = "John",
                NameLast = "Gustafson",
                HeightFeet = 6,
                HeightInches = 0,
                Weight = 180,
                ShotSide = "Right",
                Born = new DateTime(1966, 5, 23)
            };

            players.Add(player1);
            players.Add(player2);

            return players;
        }

        /*
        public IEnumerable<PlayerWithCurrentTeam> GetAllPlayersWithCurrentTeam()
        {
            var players = new List<PlayerWithCurrentTeam>();

            PlayerWithCurrentTeam player1 = new PlayerWithCurrentTeam
            {
                Id = 0,
                NameFirst = "Todd",
                NameMiddle = "John",
                NameLast = "Christensen",
                HeightFeet = 6,
                HeightInches = 4,
                Weight = 220,
                Position = "Right Wing",
                ShotSide = "Right",
                Born = new DateTime(1965, 10, 19),
                CurrentTeamName = "Colorado",
                CurrentTeamMascot = "Avalanche"
            };

            PlayerWithCurrentTeam player2 = new PlayerWithCurrentTeam
            {
                Id = 1,
                NameFirst = "Gus",
                NameMiddle = "John",
                NameLast = "Gustafson",
                HeightFeet = 6,
                HeightInches = 0,
                Weight = 180,
                Position = "Left Wing",
                ShotSide = "Right",
                Born = new DateTime(1966, 5, 23),
                CurrentTeamName = "Detroit",
                CurrentTeamMascot = "Red Wings"
            };

            players.Add(player1);
            players.Add(player2);

            return players;
        }
        */

        public Player GetPlayer(int id)
        {
            Player player = new Player
            {
                Id = 0,
                NameFirst = "Todd",
                NameMiddle = "John",
                NameLast = "Christensen",
                HeightFeet = 6,
                HeightInches = 4,
                Weight = 220,
                ShotSide = "Right",
                Born = new DateTime(2020, 10, 19)
            };

            return player;
        }

        /*
        public PlayerWithCurrentTeam GetPlayerWithCurrentTeam(int id)
        {
            PlayerWithCurrentTeam player = new PlayerWithCurrentTeam
            {
                Id = 0,
                NameFirst = "Todd",
                NameMiddle = "John",
                NameLast = "Christensen",
                HeightFeet = 6,
                HeightInches = 4,
                Weight = 220,
                Position = "Right Wing",
                ShotSide = "Right",
                Born = new DateTime(2020, 10, 19),
                CurrentTeamName = "Colorado",
                CurrentTeamMascot = "Avalanche"
            };

            return player;
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
