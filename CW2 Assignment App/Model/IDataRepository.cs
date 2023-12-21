
namespace CW2_Assignment_App.Model
{
    public interface IDataRepository
    {
        List<User> AddUser(User user);
        List<User> GetUsers();
        User PutUsers(User user);

        User GetUserById(string Id);
    }
}