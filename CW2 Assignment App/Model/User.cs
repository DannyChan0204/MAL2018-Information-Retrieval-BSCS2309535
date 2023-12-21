using System.ComponentModel.DataAnnotations.Schema;

namespace CW2_Assignment_App.Model
{
    //[Table("Users", Schema = "CW2")]

    public class User
    {
        public string userID { get; set; }  
        
        public string password { get; set; }
        public string email { get; set; }

    }
    public class UserCollection
    {
        public List<User> Users { get; set; }

        public List<User> GetUser()
        {
            return new List<User>()
            {
                new User()
                {
                    userID = "1",
                   
                    email = "grace@plymouth.ac.uk",
                    password = "ISAD123!"
                },
                new User()
                {
                    userID = "2",
                    
                    email = "tim@plymouth.ac.uk",
                    password = "COMP2001!"
                },
                new User()
                {
                    userID = "3",
                    
                    email = "ada@plymouth.ac.uk",
                    password = "insecurePassword"
                }
            };
        }
    }
}
