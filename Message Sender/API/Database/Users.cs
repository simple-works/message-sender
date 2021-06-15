using System.Data;

namespace MessageSender
{
    static class Users
    {
        public static bool Have(string fieldName, object fieldValue)
        {
            string commandText = string.Format(
                "SELECT * FROM user where {0} = '{1}'", fieldName, fieldValue);
            DataTable table = ADO.GetTable(commandText);
            return table.Rows.Count > 0;
        }

        public static bool Add(User user)
        {
            string commandText = string.Format("SELECT * FROM user");
            DataTable table = ADO.GetTable(commandText);
            DataRow row = table.Rows.Add();
            row["id"] = user.ID;
            row["name"] = user.Name;
            row["password"] = user.Password;
            row["ip_address"] = user.IPAddress;
            row["mac_address"] = user.MACAddress;
            row["signup_date"] = user.SignUpDate;
            row["login_date"] = user.LoginDate;
            return ADO.SetTable(commandText, table) > 0;
        }

        public static User Get(string fieldName, object fieldValue)
        {
            string commandText = string.Format("SELECT * FROM user where {0} = '{1}'",
                fieldName, fieldValue);
            DataTable table = ADO.GetTable(commandText);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                User user = new User();
                user.ID = row["id"];
                user.Name = row["name"];
                user.Password = row["password"];
                user.IPAddress = row["ip_address"];
                user.MACAddress = row["mac_address"];
                user.SignUpDate = row["signup_date"];
                user.LoginDate = row["login_date"];
                return user;
            }
            return null;
        }
    }
}
