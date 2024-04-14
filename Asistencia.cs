using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPlanillaPagos
{
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
            ShowAsistencia();
            GetEmpleados();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=HP_PAVILION\MSSQLSERVER01;Initial Catalog=Planilla;Integrated Security=True");
        private void Clear()
        {
            EmpleadoNombreTb.Text = "";
            PresenteTb.Text = "";
            AusenciaTb.Text = "";
            PermisosTb.Text = "";

            key = 0;

        }
        private void ShowAsistencia()
        {
            Connection.Open();
            String Query = " Select * from AsistenciaTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AsistenciaDGV.DataSource = ds.Tables[0];
            Connection.Close();
        }
        private void GetEmpleados()
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmpleadosTbl", Connection);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            EmpleadoCb.ValueMember = "EmpId";
            EmpleadoCb.DataSource = dt;
            Connection.Close();
        }
        private void GetEmpleadosNombre()
        {
            Connection.Open();
            String query = " Select * from EmpleadosTbl where EmpId " + EmpleadoCb.SelectedValue.ToString() + ""
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmpleadoNombreTb.Text = dr["EmpName"].ToString();
            }
            Connection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || PresenteTb.Text == "" || PermisosTb.Text == "" || AusenciaTb.Text == "" )
            {
                MessageBox.Show("Falta Informacion");

            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into EmployeeTbl(EmpName,EmpGen,EmpDOB,EmpPhone,EmpAdd,EmpPos,JoinDate,EmpQual,EmpBasSal) values(@EN,@EG,@ED,@EP,@EA,@Epos,@JD,@EQ,@EBS)", Connection);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPos", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleados Guardados");
                    Connection.Close();
                    ShowEmployee();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }
        int key = 0;

        private void AsistenciaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void EmpleadoCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmpleadosNombre();
        }
    }
}
