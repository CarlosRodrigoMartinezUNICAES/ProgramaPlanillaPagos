using System.Data;
using System.Data.SqlClient;

namespace ProgramaPlanillaPagos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            CountEmployees();
            CountManagers();
            SumSalary();
            SumBonus();
        }

        private SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LGTP4HK\SQLEXPRESS;Initial Catalog=Planilla;Integrated Security=True");

        private void CountEmployees()
        {
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTbl", Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmpLbl.Text = dt.Rows[0][0].ToString();
            Connection.Close();
        }

        private void CountManagers()
        {
            string Pos = "Manager";
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from EmployeeTbl where EmpPos='" + Pos + "'", Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ManagerLbl.Text = dt.Rows[0][0].ToString();
            Connection.Close();
        }

        private void SumSalary()
        {
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBalance) from SalaryTbl", Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SalaryLbl.Text = "$ " + dt.Rows[0][0].ToString();
            Connection.Close();
        }

        private void SumBonus()
        {
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(EmpBonus) from SalaryTbl", Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BonusLbl.Text = "$ " + dt.Rows[0][0].ToString();
            Connection.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Salario Obj = new Salario();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Empleados Obj = new Empleados();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Asistencia Obj = new Asistencia();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Bono Obj = new Bono();
            Obj.Show();
            this.Hide();
        }
    }
}