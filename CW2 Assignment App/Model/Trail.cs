namespace CW2_Assignment_App.Model
{
    public class Trail
    {
        public string TrailID { get; set; }
        public string TrailName { get; set; }

    }
    public class TrailCollection
    {
        public List<Trail> Trail { get; set; }

        public List<Trail> GetTrail()
        {
            return new List<Trail>()
            {
                new Trail()
                {
                    TrailID = "1",
                    TrailName = "Mountain Trail",
                },
                new Trail()
                {
                    TrailID = "2",
                    TrailName = "Forest Trail",
                },
            };
        }
    }
}
