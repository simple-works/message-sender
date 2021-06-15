using System.Collections.Generic;
using System.Data;

namespace MessageSender
{
    static class Messages
    {
        public static bool Add(Message message)
        {
            string commandText = string.Format("SELECT * FROM message");
            DataTable table = ADO.GetTable(commandText);
            DataRow row = table.Rows.Add();
            row["id"] = message.ID;
            row["sender_id"] = message.SenderID;
            row["receiver_id"] = message.ReceiverID;
            row["content"] = message.Content;
            row["sending_date"] = message.SendingDate;
            return ADO.SetTable(commandText, table) > 0;
        }

        public static List<Message> Get()
        {
            string commandText = string.Format(
                "SELECT * FROM message ORDER BY sending_date ASC LIMIT 100");
            DataTable table = ADO.GetTable(commandText);
            List<Message> messages = new List<Message>();
            foreach (DataRow row in table.Rows)
            {
                Message message = new Message();
                message.ID = row["id"];
                message.SenderID = row["sender_id"];
                message.ReceiverID = row["receiver_id"];
                message.Content = row["content"];
                message.SendingDate = row["sending_date"];
                messages.Add(message);
            }
            return messages;
        }
    }
}
