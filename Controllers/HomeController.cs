using BayernData.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace BayernData.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            List<Match> lstMatches = new List<Match>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.thesportsdb.com/api/v1/json/1/eventslast.php?id=133664");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("https://www.thesportsdb.com/api/v1/json/1/eventslast.php?id=133664");
                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    jsonData = jsonData.Remove(0, 11);
                    jsonData = jsonData.Remove(jsonData.LastIndexOf("}"), 1);
                    var array = JArray.Parse(jsonData);

                    foreach (var item in array)
                    {
                        lstMatches.Add(new Match(item["idLeague"].ToString(), item["strVenue"].ToString(), item["strTime"].ToString(), item["dateEvent"].ToString(), await GetTeamDetailsAsync(item["idHomeTeam"].ToString(), item["intHomeScore"].ToString()),
                           await GetTeamDetailsAsync(item["idAwayTeam"].ToString(), item["intAwayScore"].ToString())));
                    }
                }
            }
            lstMatches = lstMatches.Take(1).ToList();
            return View(lstMatches);
        }

        public async Task<IActionResult> ResultsAsync()
        {
            List<Match> lstMatches = new List<Match>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.thesportsdb.com/api/v1/json/1/eventslast.php?id=133664");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("https://www.thesportsdb.com/api/v1/json/1/eventslast.php?id=133664");
                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    jsonData = jsonData.Remove(0, 11);
                    jsonData = jsonData.Remove(jsonData.LastIndexOf("}"), 1);
                    var array = JArray.Parse(jsonData);

                    foreach (var item in array)
                    {
                        lstMatches.Add(new Match(item["idLeague"].ToString(), item["strVenue"].ToString(), item["strTime"].ToString(), item["dateEvent"].ToString(), await GetTeamDetailsAsync(item["idHomeTeam"].ToString(), item["intHomeScore"].ToString()),
                           await GetTeamDetailsAsync(item["idAwayTeam"].ToString(), item["intAwayScore"].ToString())));
                    }
                }
            }
            return View(lstMatches);
        }

        public async Task<IActionResult> TableAsync()
        {
            List<TeamRank> teams = await GetLeagueStandingsAsync();
            return View(teams);
        }

        //HELPER METHODS.
        private async Task<Team> GetTeamDetailsAsync(string id, string score)
        {
            string teamName = "", teamLogoUrl = "", teamKitUrl = "";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://www.thesportsdb.com/api/v1/json/1/lookupteam.php?id={id}");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync($"https://www.thesportsdb.com/api/v1/json/1/lookupteam.php?id={id}");
                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    jsonData = jsonData.Remove(0, 9);
                    jsonData = jsonData.Remove(jsonData.LastIndexOf("}"), 1);
                    var array = JArray.Parse(jsonData);
                    teamName = array[0]["strTeam"].ToString();
                    teamLogoUrl = array[0]["strTeamBadge"].ToString();
                    teamKitUrl = array[0]["strTeamJersey"].ToString();
                }
            }

            return new Team(id, score, teamName, teamLogoUrl, teamKitUrl);
        }

        private async Task<List<TeamRank>> GetLeagueStandingsAsync()
        {
            List<TeamRank> lstRanks = new List<TeamRank>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://www.thesportsdb.com/api/v1/json/1/lookuptable.php?l=4331&s=2021-2022");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync($"https://www.thesportsdb.com/api/v1/json/1/lookuptable.php?l=4331&s=2021-2022");
                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    jsonData = jsonData.Remove(0, 9);
                    jsonData = jsonData.Remove(jsonData.LastIndexOf("}"), 1);
                    var array = JArray.Parse(jsonData);

                    foreach (var item in array)
                    {
                        lstRanks.Add(new TeamRank(item["intRank"].ToString(), item["strTeam"].ToString(), item["intPlayed"].ToString(), item["intWin"].ToString(),
                            item["intDraw"].ToString(), item["intLoss"].ToString(), item["intGoalsFor"].ToString(), item["intGoalsAgainst"].ToString(),
                            item["intGoalDifference"].ToString(), item["intPoints"].ToString(), item["strForm"].ToString(), item["strTeamBadge"].ToString()));
                    }
                }
            }
            return lstRanks;
        }
    }
}
