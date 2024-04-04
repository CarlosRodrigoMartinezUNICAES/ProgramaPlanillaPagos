using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.PerformanceData;
using System.Data.SqlClient;
using System.ComponentModel.Design.Serialization;

namespace ProgramaPlanillaPagos
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            ShowEmployee();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        SqlConnection Connection = new SqlConnection (@"Data Source=HP_PAVILION\MSSQLSERVER01;Initial Catalog=Planilla;Integrated Security=True");
        private void Clear()
        {
            EmpNameTb.Text = "";
            EmpAddTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpSalTb.Text = "";
            EmpGenCb.SelectedIndex= 0;
            EmpPosCb.SelectedIndex= 0;
            EmpQualCb.SelectedIndex= 0;
            key = 0;
            
        }
        private void ShowEmployee()
        {
            Connection.Open ();
            String Query = " Select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter (Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder (sda);
            var ds = new DataSet();
            sda.Fill(ds);   
            EmployeeDGV.DataSource = ds.Tables[0];
            Connection.Close ();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
         if (EmpNameTb.Text == ""  || EmpPhoneTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "" || EmpQualCb.SelectedIndex == -1)
         {
           MessageBox.Show("Falta Informacion");
        
         }else
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

         
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Close();
        }

        int key = 0;
        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpGenCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpDOB.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmpAddTb.Text = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpPosCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[6].Value.ToString();
            JDate.Text = EmployeeDGV.SelectedRows[0].Cells[7].Value.ToString();
            EmpQualCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[8].Value.ToString();
            EmpSalTb.Text = EmployeeDGV.SelectedRows[0].Cells[9].Value.ToString();
            if(EmpNameTb.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

            
            
              
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "" || EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Falta Informacion");

            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Update EmployeeTbl Set (EmpName=@EN,EmpGen=@EG,EmpDOB=@ED,EmpPhone=@EP,EmpAdd=@EA,EmpPos=@Epos,JoinDate=@JD,EmpQual=@EQ,EmpBasSal=@EBS where EmpId=@EmpKey)", Connection);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPos", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.Parameters.AddWithValue("@EmpKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleados Actualizados");
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key== 0 )
            {
                MessageBox.Show("Falta Informacion");

            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Delete from EmployeeTbl Where EmpId=@EmpKey", Connection);
                    cmd.Parameters.AddWithValue("@EmpKey", key);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado Eliminado");
                    Connection.Close();
                    ShowEmployee();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

       
    }
}
