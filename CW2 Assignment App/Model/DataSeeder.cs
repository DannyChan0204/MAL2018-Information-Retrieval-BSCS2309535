namespace CW2_Assignment_App.Model
{
        public class DataSeeder
        {
            private readonly UserDBContext userDbContext;
            public DataSeeder(UserDBContext userDbContext)
            {
                this.userDbContext = userDbContext;
            }

        public void Seed()
        {
            if(!userDbContext.Users.Any())
            {
                var user = new List<User>()
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

                userDbContext.Users.AddRange(user);
                userDbContext.SaveChanges();

            }
        }
        }
    
}
