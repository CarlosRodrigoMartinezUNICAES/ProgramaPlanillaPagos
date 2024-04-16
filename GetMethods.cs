using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class GetMethods
{

    public static void GetEmpleadosNombreSalario(int empId, TextBox empNameTb, TextBox baseSalaryTb)
    {
        SqlConnection Connection = DatabaseConnection.GetConnection();
        string query = "SELECT * FROM EmployeeTbl WHERE EmpId = @EmpId";
        SqlCommand cmd = new SqlCommand(query, Connection);
        cmd.Parameters.AddWithValue("@EmpId", empId);
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            empNameTb.Text = dr["EmpName"].ToString();
            baseSalaryTb.Text = dr["EmpBasSal"].ToString();
        }
        DatabaseConnection.CloseConnection();
    }

    public static void GetBonus(ComboBox bonusIdCb)
    {
        SqlConnection Connection = DatabaseConnection.GetConnection();
        SqlCommand cmd = new SqlCommand("SELECT * FROM BonusTbl", Connection);
        SqlDataReader Rdr;
        Rdr = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Columns.Add("BName", typeof(string));
        dt.Load(Rdr);
        bonusIdCb.ValueMember = "BName";
        bonusIdCb.DataSource = dt;
        DatabaseConnection.CloseConnection();
    }

    public static void GetAttendance(ComboBox attNumCb, int empId)
    {
        SqlConnection Connection = DatabaseConnection.GetConnection();
        SqlCommand cmd = new SqlCommand("SELECT * FROM AttendanceTbl WHERE EmpId = @EmpId", Connection);
        cmd.Parameters.AddWithValue("@EmpId", empId);
        SqlDataReader Rdr;
        Rdr = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Columns.Add("AttNum", typeof(int));
        dt.Load(Rdr);
        attNumCb.ValueMember = "AttNum";
        attNumCb.DataSource = dt;
        DatabaseConnection.CloseConnection();
    }

    public static void GetAttendanceData(int attNum, TextBox presTb, TextBox absTb, TextBox excusedTb)
    {
        SqlConnection Connection = DatabaseConnection.GetConnection();
        string query = "SELECT * FROM AttendanceTbl WHERE AttNum = @AttNum";
        SqlCommand cmd = new SqlCommand(query, Connection);
        cmd.Parameters.AddWithValue("@AttNum", attNum);
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            presTb.Text = dr["DayPres"].ToString();
            absTb.Text = dr["DayAbs"].ToString();
            excusedTb.Text = dr["DayExcused"].ToString();
        }
        DatabaseConnection.CloseConnection();
    }

    public static void GetBonusAmt(string bonusName, TextBox bonusTb)
    {
        SqlConnection Connection = DatabaseConnection.GetConnection();
        string query = "SELECT * FROM BonusTbl WHERE BName = @BonusName";
        SqlCommand cmd = new SqlCommand(query, Connection);
        cmd.Parameters.AddWithValue("@BonusName", bonusName);
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            bonusTb.Text = dr["BAmt"].ToString();
        }
        DatabaseConnection.CloseConnection();


    }
}
