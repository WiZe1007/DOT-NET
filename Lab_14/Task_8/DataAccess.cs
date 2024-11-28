using System;
using System.Data.SqlClient;

namespace Lab__12
{
    public static class DataAccess
    {
        // Используйте ваш абсолютный путь к базе данных
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\source\repos\Lab__12\Lab__12\SocialNetworkDB.mdf;Integrated Security=True;Connect Timeout=30;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
