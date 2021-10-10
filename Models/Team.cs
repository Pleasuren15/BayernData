namespace BayernData.Models
{
    public class Team
    {
        public string TeamId { get; }
        public string TeamScore { get; }
        public string TeamName { get; set; }
        public string TeamLogoUrl { get; set; }
        public string TeamKitUrl { get; set; }

        public Team(string TeamId, string TeamScore, string TeamName, string TeamLogoUrl, string TeamKitUrl)
        {
            this.TeamId = TeamId;
            this.TeamScore = TeamScore;
            this.TeamName = TeamName;
            this.TeamLogoUrl = TeamLogoUrl;
            this.TeamKitUrl = TeamKitUrl;
        }
    }
}
