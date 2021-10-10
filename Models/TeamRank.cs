namespace BayernData.Models
{
    public class TeamRank
    {
        public TeamRank(string Rank, string TeamName, string P, string W, string D, string L,
            string GF, string GA, string GD, string Pts, string Form, string TeamBadge)
        {
            this.Rank = Rank;
            this.TeamName = TeamName;
            this.P = P;
            this.W = W;
            this.D = D;
            this.L = L;
            this.GF = GF;
            this.GA = GA;
            this.GD = GD;
            this.Pts = Pts;
            this.Form = Form;
            this.TeamBadge = TeamBadge;
        }

        public string Rank { get; }
        public string TeamName { get; }
        public string P { get; }
        public string W { get; }
        public string D { get; }
        public string L { get; }
        public string GF { get; }
        public string GA { get; }
        public string GD { get; }
        public string Pts { get; }
        public string Form { get; }
        public string TeamBadge { get; }
    }
}
