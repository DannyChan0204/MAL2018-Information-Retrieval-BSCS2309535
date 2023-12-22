using System.ComponentModel.DataAnnotations.Schema;

namespace CW2_Assignment_App.Model
{
    //[Table("Users", Schema = "CW2")]

    public class Profile
    {
        public string profileID { get; set; }
        public string userID { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string registerDate { get; set; }
        public string role { get; set; }
        public string archivedStatus { get; set; }

    }
    public class ProfileCollection
    {
        public List<Profile> Profile { get; set; }

        public List<Profile> GetProfile()
        {
            return new List<Profile>()
            {
                new Profile()
                {
                    profileID = "1",
                    userID = "1",
                    name = "Grace Hopper",
                    age = "25",
                    registerDate = "2023-01-01",
                    role = "Admin",
                    archivedStatus = "0"
                },
                new Profile()
                {
                    profileID = "2",
                    userID = "2",
                    name = "Tim Berners-Lee",
                    age = "30",
                    registerDate = "2023-02-15",
                    role = "User",
                    archivedStatus = "0"
                },
                new Profile()
                {
                    profileID = "3",
                    userID = "3",
                    name = "Ada Lovelace",
                    age = "17",
                    registerDate = "2023-03-17",
                    role = "User",
                    archivedStatus = "0"
                }
            };
        }
    }
}
