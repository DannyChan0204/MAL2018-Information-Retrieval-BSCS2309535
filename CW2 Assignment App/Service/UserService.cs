using CW2_Assignment_App.IService;

namespace CW2_Assignment_App.Service
{
    public class UserService : IUserService
    {
        public bool CheckUser(string email, string password)
        {
            return email.Equals("grace@plymouth.ac.uk") && password.Equals("ISAD123!");
        }
    }
}
