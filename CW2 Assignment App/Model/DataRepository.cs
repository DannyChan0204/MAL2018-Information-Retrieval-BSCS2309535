namespace CW2_Assignment_App.Model
{
    public class DataRepository : IDataRepository
    {
        public readonly UserDBContext db;
        public DataRepository(UserDBContext db)
        {
            this.db = db;
        }

        public List<User> GetUsers() => db.Users.ToList();

        public User PutUsers(User user)
        {

            db.Users.Update(user);
            db.SaveChanges();
            return db.Users.Where(x => x.userID == user.userID).FirstOrDefault();
        }

        public List<User> AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return db.Users.ToList();
        }

        public User GetUserById(string Id) 
        {
            return db.Users.Where(x => x.userID == Id).FirstOrDefault();
        }
    }
}

