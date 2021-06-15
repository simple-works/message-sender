
namespace MessageSender
{
    static class Session
    {
        public static User CurrentUser { get; private set; }
        public static bool UserLogged { get { return CurrentUser != null; } }

        public static bool Register(string userName)
        {
            User newUser = new User(userName);
            if (Users.Have("mac_address", newUser.MACAddress))
            {
                return false;
            }
            // TODO: Update SignUpDate
            return Users.Add(newUser);
        }

        public static bool LogIn()
        {
            CurrentUser = Users.Get("mac_address", Network.GetMACAddress());
            // TODO: Update LoginDate
            return CurrentUser != null;
        }

        public static bool LogOut()
        {
            CurrentUser = null;
            return true;
        }
    }
}
