using Npgsql;

namespace cweed
{
    internal class Connection
    {
        public static NpgsqlConnection GetConnection()
        {
            string conn =
            "Host=localhost;" +
            "Port=5432;" +
            "Username=postgres;" +
            "Password=191206;" +
            "Database=cweed";

            NpgsqlConnection connection =
            new NpgsqlConnection(conn);

            return connection;
        }
    }
}