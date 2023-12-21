namespace CW2_Assignment_App.Model
{
    public class Badges
    {
        public string BadgesID { get; set; }
        public string profileID { get; set; }
        public string badgeName { get; set; }
        public string dateGained { get; set; }


    }
    public class BadgesCollection
    {
        public List<Badges> Badges { get; set; }

        public List<Badges> GetProfile()
        {
            return new List<Badges>()
            {
                new Badges()
                {
                    BadgesID = "1",
                    profileID = "1",
                    badgeName = "First Achievement",
                    dateGained = "2023-01-10",
                },
                new Badges()
                {
                    BadgesID = "2",
                    profileID = "2",
                    badgeName = "Trail Explorer",
                    dateGained = "2023-03-05",
                },
            };
        }
    }
}
