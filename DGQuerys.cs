using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DGQuerys
{
 
    public static void ShowData(string query, DataGridView dataGridView)
    {


        SqlConnection Connection = DatabaseConnection.GetConnection();
        SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
        SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        var ds = new DataSet();
        sda.Fill(ds);
        dataGridView.DataSource = ds.Tables[0];
        DatabaseConnection.CloseConnection();
    }
}
