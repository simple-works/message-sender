
using System;
namespace MessageSender
{
    class Message
    {
        public object ID { get; set; }
        public object SenderID { get; set; }
        public object ReceiverID { get; set; }
        public object Content { get; set; }
        public object SendingDate { get; set; }

        public Message() { }

        public Message(string content)
        {
            this.ID = DBNull.Value;
            this.SenderID = Session.CurrentUser.ID;
            this.ReceiverID = DBNull.Value;
            this.Content = content;
            this.SendingDate = DateTime.Now;
        }
    }
}
