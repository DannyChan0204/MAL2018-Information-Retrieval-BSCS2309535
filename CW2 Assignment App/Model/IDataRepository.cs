
namespace CW2_Assignment_App.Model
{
    public interface IDataRepository
    {
        //user ------------------------------------------------------
        List<User> AddUser(User user);
        List<User> GetUsers();
        User PutUsers(User user);

        User GetUserById(string Id);


        //profile---------------------------------------------------
        List<User> AddProfile(User user);
        List<User> GetProfile();
        User PutProfile(User user);

        User GetProfileById(string Id);
        void PutProfile(Profile profile);
        void AddProfile(Profile profile);

        //Badges--------------------------------------------------------------
        List<Badges> AddBadges(Badges Badges);
        List<Badges> GetBadges();
        Badges PutBadges(Badges Badges);

        Badges GetBadgesById(string Id);

        //Trail----------------------------------------
        List<Trail> AddTrail(Trail Trail);
        List<Trail> GetTrail();
        Trail PutTrail(Trail Trail);

        Trail GetTrailById(string Id);

        //Leaderboard----------------------------------------
        List<Leaderboard> AddLeaderboard(Leaderboard Leaderboard);
        List<Leaderboard> GetLeaderboard();
        Leaderboard PutLeaderboard(Leaderboard Leaderboard);

        Leaderboard GetLeaderboardById(string Id);

        //Comments---------------------------------------------------
        List<Comments> AddComments(Comments Comments);
        List<Comments> GetComments();
        Comments PutComments(Comments Comments);

        Comments GetCommentsById(string Id);
    }
}