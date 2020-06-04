using System.Data;
using Npgsql;

namespace Arkanoid.Controlador
{
    public static class ConnectionDB
    {
        private static readonly string host = "ec2-52-44-166-58.compute-1.amazonaws.com";

        private static readonly string database = "dc353pq438duni";

        private static readonly string userId = "fwausivxslwhcz";

        private static readonly string password = "f84e5348422d0a85a1bfca731578c72461258f0fa9cb0180077820ef4959d289";

        private static readonly string sConnection=
            $"Host={host};Port=5432;User Id={userId};Password={password};Database={database};" +
            $"sslmode=Require;Trust Server Certificate=true";
        
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();
            return ds.Tables[0];
        }
       
        public static void ExecuteNonQuery(string act)
        { 
            NpgsqlConnection conn = new NpgsqlConnection(sConnection);
            conn.Open();

            NpgsqlCommand nc = new NpgsqlCommand(act, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
    }
}