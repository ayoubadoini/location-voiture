using System.Data.SqlClient;

namespace location_voiture.ado
{
    public static class Connexion
    {
        public static SqlConnection cn = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=location_voiture;Integrated Security=True;Connect Timeout=30"
        );

        public static void Open()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        public static void Close()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}
