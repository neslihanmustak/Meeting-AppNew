namespace MeetingAppNew.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "User 1", Email = "user1@example.com", Phone = "5550000001", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "User 2", Email = "user2@example.com", Phone = "5550000002", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "User 3", Email = "user3@example.com", Phone = "5550000003", WillAttend = true });
            _users.Add(new UserInfo() { Id = 4, Name = "User 4", Email = "user4@example.com", Phone = "5550000004", WillAttend = false });


        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
    
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }


}
