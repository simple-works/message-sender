using System;

namespace MessageSender
{
    class User
    {
        public object ID { get; set; }
        public object Name { get; set; }
        public object Password { get; set; }
        public object IPAddress { get; set; }
        public object MACAddress { get; set; }
        public object SignUpDate { get; set; }
        public object LoginDate { get; set; }

        public User() { }

        public User(string name = "")
        {
            this.ID = DBNull.Value;
            this.Name = name;
            this.Password = DBNull.Value;
            this.IPAddress = Network.GetIPAddress();
            this.MACAddress = Network.GetMACAddress();
            this.SignUpDate = DateTime.Now;
            this.LoginDate = DateTime.Now;
        }
    }
}
