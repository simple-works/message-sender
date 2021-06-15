using System.Data;
using MySql.Data.MySqlClient;
using MessageSender.Properties;

namespace MessageSender
{
    static class ADO
    {
        public static string ConnectionString
        {
            get
            {
                return Settings.Default.ConnectionString;
            }
        }

        public static DataTable GetTable(string commandText)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(commandText, connection))
                {
                    using (DataTable table = new DataTable())
                    {
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public static int SetTable(string commandText, DataTable table)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(commandText, connection))
                {
                    using (MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter))
                    {
                        return adapter.Update(table);
                    }
                }
            }
        }
    }
}
