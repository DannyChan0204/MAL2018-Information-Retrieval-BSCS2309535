namespace CW2_Assignment_App.Model
{
    public class Leaderboard
    {
        public string LeaderboardID { get; set; }
        public string TrailID { get; set; }
        public string ProfileID { get; set; }
        public string FriendsRanking { get; set; }
        public string GlobalRanking { get; set; }
        public string TimeTaken { get; set; }

    }
    public class LeaderboardCollection
    {
        public List<Leaderboard> Leaderboard { get; set; }

        public List<Leaderboard> GetLeaderboard()
        {
            return new List<Leaderboard>()
            {
                new Leaderboard()
                {
                    LeaderboardID = "1",
                    TrailID = "1",
                    ProfileID = "1",
                    FriendsRanking = "2",
                    GlobalRanking = "1",
                    TimeTaken = "00:25:30",
                 
                },
                new Leaderboard()
                {
                    LeaderboardID = "2",
                    TrailID = "2",
                    ProfileID = "2",
                    FriendsRanking = "1",
                    GlobalRanking = "1",
                    TimeTaken = "00:20:15",
                },
                new Leaderboard()
                {
                    LeaderboardID = "3",
                    TrailID = "2",
                    ProfileID = "3",
                    FriendsRanking = "2",
                    GlobalRanking = "2",
                    TimeTaken = "00:30:45",
                },
            };
        }
    }
}
