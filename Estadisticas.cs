using System.Data.SqlClient;
using System.Data;

public class Estadisticas
{
    private static SqlConnection Connection = DatabaseConnection.GetConnection();

    public static int CountEmployees()
    {
        DatabaseConnection.GetConnection();
        SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTbl", Connection);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        int employeeCount = Convert.ToInt32(dt.Rows[0][0]);
        DatabaseConnection.CloseConnection();
        return employeeCount;
    }

    public static int CountManagers()
    {
        string Pos = "Manager";
        DatabaseConnection.GetConnection();
        SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTbl where EmpPos='" + Pos + "'", Connection);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        int managerCount = Convert.ToInt32(dt.Rows[0][0]);
        DatabaseConnection.CloseConnection();
        return managerCount;
    }

    public static decimal SumSalary()
    {
        DatabaseConnection.GetConnection();
        SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBalance) from SalaryTbl", Connection);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        decimal totalSalary = Convert.ToDecimal(dt.Rows[0][0]);
        DatabaseConnection.CloseConnection();
        return totalSalary;
    }

    public static decimal SumBonus()
    {
        DatabaseConnection.GetConnection();
        SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBonus) from SalaryTbl", Connection);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        decimal totalBonus = Convert.ToDecimal(dt.Rows[0][0]);
        DatabaseConnection.CloseConnection();
        return totalBonus;
    }
}