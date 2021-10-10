using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BayernData.Models
{
    /*Used for the API in HomeController/Results*/
    public class Match
    {
        public Match(string LeagueId, string Venue, string Time, string Date, Team HomeTeam, Team AwayTeam)
        {
            this.LeagueId = LeagueId;
            this.Venue = Venue;
            this.Time = Time;
            this.Date = Date;
            this.HomeTeam = HomeTeam;
            this.AwayTeam = AwayTeam;
        }
        public string LeagueId { get; set; }
        public string Venue { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public Team HomeTeam { get; }
        public Team AwayTeam { get; }
    }
}
