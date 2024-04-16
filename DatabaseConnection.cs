using System.Data.SqlClient;

public class DatabaseConnection
{
    private static string connectionString = @"Data Source=DESKTOP-LGTP4HK\SQLEXPRESS;Initial Catalog=Planilla;Integrated Security=True";
    private static SqlConnection Connection;

    private DatabaseConnection()
    {
        // Constructor privado para evitar instanciación directa
    }

    public static SqlConnection GetConnection()
    {
        if (Connection == null)
        {
            Connection = new SqlConnection(connectionString);
        }
        else if (Connection.State == System.Data.ConnectionState.Closed)
        {
            Connection.Open();
        }

        return Connection;
    }

    public static void CloseConnection()
    {
        if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
        {
            Connection.Close();
            //Connection = null;
        }
    }
}