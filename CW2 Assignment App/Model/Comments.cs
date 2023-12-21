namespace CW2_Assignment_App.Model
{
    public class Comments
    {
        public string CommentsID { get; set; }
        public string TrailID { get; set; }
        public string ProfileID { get; set; }
        public string Description { get; set; }


    }
    public class CommentsCollection
    {
        public List<Comments> Comments { get; set; }

        public List<Comments> GetComments()
        {
            return new List<Comments>()
            {
                new Comments()
                {
                    CommentsID = "1",
                    TrailID = "1",
                    ProfileID = "1",
                    Description = "Great job on the Mountain Trail!",
                },
                new Comments()
                {
                    CommentsID = "2",
                    TrailID = "1",
                    ProfileID = "2",
                    Description = "Awesome time on the Mountain Trail!",
                },
                new Comments()
                {
                    CommentsID = "3",
                    TrailID = "2",
                    ProfileID = "3",
                    Description = "Nice exploration of the Forest Trail.",
                },
            };
        }
    }
}
