using AutoMapper;

namespace CW2_Assignment_App.Model
{
    public class DataRepository : IDataRepository
    {
        public readonly UserDBContext db;

        //User
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

        //Profile--------------------------------------------------------------
        public List<Profile> GetProfile() => db.Profile.ToList();

        public Profile PutProfile(Profile Profile)
        {

            db.Profile.Update(Profile);
            db.SaveChanges();
            return db.Profile.Where(x => x.profileID == Profile.profileID).FirstOrDefault();
        }

        public List<Profile> AddProfile(Profile Profile)
        {
            db.Profile.Add(Profile);
            db.SaveChanges();
            return db.Profile.ToList();
        }

        public Profile GetProfileById(string Id)
        {
            return db.Profile.Where(x => x.profileID == Id).FirstOrDefault();
        }

        //Badges--------------------------------------------------------------
        public List<Badges> GetBadges() => db.Badges.ToList();

        public Badges PutBadges(Badges Badges)
        {

            db.Badges.Update(Badges);
            db.SaveChanges();
            return db.Badges.Where(x => x.BadgesID == Badges.BadgesID).FirstOrDefault();
        }

        public List<Badges> AddBadges(Badges Badges)
        {
            db.Badges.Add(Badges);
            db.SaveChanges();
            return db.Badges.ToList();
        }

        public Badges GetBadgesById(string Id)
        {
            return db.Badges.Where(x => x.BadgesID == Id).FirstOrDefault();
        }

        Badges IDataRepository.PutBadges(Badges Badges)
        {
            throw new NotImplementedException();
        }

        Badges IDataRepository.GetBadgesById(string Id)
        {
            throw new NotImplementedException();
        }

        //Trail ------------------------------------------------------

        public List<Trail> GetTrail() => db.Trail.ToList();

        public Trail PutTrail(Trail Trail)
        {

            db.Trail.Update(Trail);
            db.SaveChanges();
            return db.Trail.Where(x => x.TrailID == Trail.TrailID).FirstOrDefault();
        }

        public List<Trail> AddTrail(Trail Trail)
        {
            db.Trail.Add(Trail);
            db.SaveChanges();
            return db.Trail.ToList();
        }

        public Trail GetTrailById(string Id)
        {
            return db.Trail.Where(x => x.TrailID == Id).FirstOrDefault();
        }

        //Leaderboard------------------------------------------------------------
        public List<Leaderboard> GetLeaderboard() => db.Leaderboard.ToList();

        public Leaderboard PutLeaderboard(Leaderboard Leaderboard)
        {

            db.Leaderboard.Update(Leaderboard);
            db.SaveChanges();
            return db.Leaderboard.Where(x => x.LeaderboardID == Leaderboard.LeaderboardID).FirstOrDefault();
        }

        public List<Leaderboard> AddLeaderboard(Leaderboard Leaderboard)
        {
            db.Leaderboard.Add(Leaderboard);
            db.SaveChanges();
            return db.Leaderboard.ToList();
        }

        public Leaderboard GetLeaderboardById(string Id)
        {
            return db.Leaderboard.Where(x => x.LeaderboardID == Id).FirstOrDefault();
        }

        //Comments-----------------------------------------------------------------
        public List<Comments> GetComments() => db.Comments.ToList();

        public Comments PutComments(Comments Comments)
        {

            db.Comments.Update(Comments);
            db.SaveChanges();
            return db.Comments.Where(x => x.CommentsID == Comments.CommentsID).FirstOrDefault();
        }

        public List<Comments> AddComments(Comments Comments)
        {
            db.Comments.Add(Comments);
            db.SaveChanges();
            return db.Comments.ToList();
        }

        public Comments GetCommentsById(string Id)
        {
            return db.Comments.Where(x => x.CommentsID == Id).FirstOrDefault();
        }

        public List<Profile> AddProfile(User user)
        {
            throw new NotImplementedException();
        }

        public Profile PutProfile(User user)
        {
            throw new NotImplementedException();
        }

        void IDataRepository.PutProfile(Profile profile)
        {
            throw new NotImplementedException();
        }

        void IDataRepository.AddProfile(Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}

