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
            ShowAttendance();
            GetEmpleados();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LGTP4HK\SQLEXPRESS;Initial Catalog=Planilla;Integrated Security=True");
        private void Clear()
        {
            EmpNameTb.Text = "";
            PresenceTb.Text = "";
            AbsTb.Text = "";
            ExcusedTb.Text = "";

            Key = 0;

        }
        private void ShowAttendance()
        {
            Connection.Open();
            String Query = " Select * from AttendanceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendanceDGV.DataSource = ds.Tables[0];
            Connection.Close();
        }
        private void GetEmpleados()
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmployeeTbl", Connection);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            EmpIdCb.ValueMember = "EmpId";
            EmpIdCb.DataSource = dt;
            Connection.Close();
        }
        private void GetEmpleadosNombre()
        {
            Connection.Open();
            String query = " Select * from EmployeeTbl where EmpId " + EmpIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmpNameTb.Text = dr["EmpName"].ToString();
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
            if (EmpNameTb.Text == "" || PresenceTb.Text == "" || ExcusedTb.Text == "" || AbsTb.Text == "" )
            {
                MessageBox.Show("Falta Informacion");

            }
            else
            {
                try
                {
                    string Period = AttDate.Value.Month + "-" + AttDate.Value.Year;
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into AttendanceTbl(EmpId,EmpName,DayPres,DayAbs,DayExcused,Period) values(@EI,@EN,@DP,@DA,@DE,@Per)", Connection);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                    cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                    cmd.Parameters.AddWithValue("@DE", ExcusedTb.Text);
                    cmd.Parameters.AddWithValue("@Per", Period);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Asistencia Guardada");
                    Connection.Close();
                    ShowAttendance();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || PresenceTb.Text == "" || ExcusedTb.Text == "" || AbsTb.Text == "")
            {
                MessageBox.Show("Falta Informacion");

            }
            else
            {
                try
                {
                    string Period = AttDate.Value.Month + "-" + AttDate.Value.Year;
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Update AttendanceTbl Set EmpId=@EI,EmpName=@EN,DayPres=@DP,DayAbs=@DA,DayExcused=@DE,Period=@Per where AttNum=@AttKey", Connection);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                    cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                    cmd.Parameters.AddWithValue("@DE", ExcusedTb.Text);
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.Parameters.AddWithValue("@AttKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Asistencia Actualizada");
                    Connection.Close();
                    ShowAttendance();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        int Key = 0;

        private void AttendanceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = AttendanceDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpIdCb.SelectedItem = AttendanceDGV.SelectedRows[0].Cells[1].Value.ToString();
            PresenceTb.Text = AttendanceDGV.SelectedRows[0].Cells[3].Value.ToString();
            AbsTb.Text = AttendanceDGV.SelectedRows[0].Cells[4].Value.ToString();
            ExcusedTb.Text = AttendanceDGV.SelectedRows[0].Cells[5].Value.ToString();
            AttDate.Text = AttendanceDGV.SelectedRows[0].Cells[3].Value.ToString();
            
            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AttendanceDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmpleadosNombre();
        }
    }
}
