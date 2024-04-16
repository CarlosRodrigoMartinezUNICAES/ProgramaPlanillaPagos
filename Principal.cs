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

        private SqlConnection Connection = DatabaseConnection.GetConnection();
        //private SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LGTP4HK\SQLEXPRESS;Initial Catalog=Planilla;Integrated Security=True");

        private void CountEmployees()
        {
            EmpLbl.Text = Estadisticas.CountEmployees().ToString();
        }

        private void CountManagers()
        {
            ManagerLbl.Text = Estadisticas.CountManagers().ToString();
        }

        private void SumSalary()
        {
            SalaryLbl.Text = "$ " + Estadisticas.SumSalary().ToString();
        }

        private void SumBonus()
        {
            BonusLbl.Text = "$ " + Estadisticas.SumBonus().ToString();
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