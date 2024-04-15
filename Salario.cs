using System.Data;
using System.Data.SqlClient;

namespace ProgramaPlanillaPagos
{
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
            GetEmpleados();
            GetAttendance();
            GetBonus();
            ShowSalary();
        }

        private SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LGTP4HK\SQLEXPRESS;Initial Catalog=Planilla;Integrated Security=True");

        private void Clear()
        {
            EmpNameTb.Text = "";
            PresTb.Text = "";
            AbsTb.Text = "";
            ExcusedTb.Text = "";

            //Key = 0;
        }

        private void ShowSalary()
        {
            Connection.Open();
            String Query = " Select * from SalaryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SalaryDGV.DataSource = ds.Tables[0];
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

        private void GetBonus()
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from BonusTbl", Connection);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BName", typeof(string));
            dt.Load(Rdr);
            BonusIdCb.ValueMember = "BName";
            BonusIdCb.DataSource = dt;
            Connection.Close();
        }

        private void GetAttendance()
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from AttendanceTbl Where EmpId=" + EmpIdCb.SelectedValue.ToString() + "", Connection);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AttNum", typeof(int));
            dt.Load(Rdr);
            AttNumCb.ValueMember = "AttNum";
            AttNumCb.DataSource = dt;
            Connection.Close();
        }

        private void GetAttendanceData()
        {
            Connection.Open();
            String query = "Select * from AttendanceTbl Where AttNum= " + AttNumCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PresTb.Text = dr["DayPres"].ToString();
                AbsTb.Text = dr["DayAbs"].ToString();
                ExcusedTb.Text = dr["DayExcused"].ToString();
            }
            Connection.Close();
        }

        private void GetEmpleadosNombre()
        {
            Connection.Open();
            String query = "SELECT * FROM EmployeeTbl WHERE EmpId=" + EmpIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmpNameTb.Text = dr["EmpName"].ToString();
                BaseSalaryTb.Text = dr["EmpBasSal"].ToString();
            }
            Connection.Close();
        }

        private void GetBonusAmt()
        {
            Connection.Open();
            String query = "Select * from BonusTbl where BName= '" + BonusIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BonusTb.Text = dr["BAmt"].ToString();
                BonusTb.Text = dr["BAmt"].ToString();
            }
            Connection.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EmpIdCb_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmpleadosNombre();
            GetAttendance();
        }

        private void BonusIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBonusAmt();
        }

        private void AttNumCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetAttendanceData();
        }

        private int DailyBase = 0, Total = 0, Pres = 0, Abs = 0, Exc = 0;
        private double GrdTot = 0, TotTax = 0;

        private void label18_Click(object sender, EventArgs e)
        {
            if (BaseSalaryTb.Text == "" || BonusTb.Text == "" || AdvanceTb.Text == "")
            {
                MessageBox.Show("Seleccione el empleado");
            }
            else
            {
                Pres = Convert.ToInt32(PresTb.Text);
                Abs = Convert.ToInt32(AbsTb.Text);
                Exc = Convert.ToInt32(ExcusedTb.Text);
                DailyBase = Convert.ToInt32(BaseSalaryTb.Text) / 22;
                Total = ((DailyBase) * Pres) + ((DailyBase / 2) * Exc) + ((DailyBase) * Pres);
                double ISSS = Total * 0.03;
                double IVA = Total * 0.0725;
                double Renta = Total * 0.1;
                TotTax = Total - ISSS - IVA - Renta;
                GrdTot = TotTax + Convert.ToInt32(BonusTb.Text);
                BalanceTb.Text = "$ " + GrdTot;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || PresTb.Text == "" || AbsTb.Text == "" || ExcusedTb.Text == "")
            {
                MessageBox.Show("Falta Informacion");
            }
            else
            {
                try
                {
                    string Period = SalDate.Value.Month + "-" + SalDate.Value.Year;
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into SalaryTbl(EmpId,EmpName,EmpBasSal,EmpBonus,EmpAdvance,EmpTax,EmpBalance,SalPeriod) values(@EI,@EN,@EBS,@EBon,@EAd,@ETax,@EBalance,@SPer)", Connection);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EBS", BaseSalaryTb.Text);
                    cmd.Parameters.AddWithValue("@Ebon", BonusTb.Text);
                    cmd.Parameters.AddWithValue("@EAd", AdvanceTb.Text);
                    cmd.Parameters.AddWithValue("@ETax", TotTax);
                    cmd.Parameters.AddWithValue("@EBalance", GrdTot);
                    cmd.Parameters.AddWithValue("@SPer", Period);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salario Guardado");
                    Connection.Close();
                    ShowSalary();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (SalaryDGV.SelectedRows.Count > 0)
            {
                e.Graphics.DrawString("Empresa Carlos Ltd", new Font("Arial", 12, FontStyle.Bold), Brushes.Red, new Point(160, 25));
                e.Graphics.DrawString("Sistema de Planillas de Pago 1.0", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(125, 45));

                string SalNum = SalaryDGV.SelectedRows[0].Cells[0].Value.ToString();
                string EmpId = SalaryDGV.SelectedRows[0].Cells[1].Value.ToString();
                string EmpName = SalaryDGV.SelectedRows[0].Cells[2].Value.ToString();
                string BasSal = SalaryDGV.SelectedRows[0].Cells[3].Value.ToString();
                string Bonus = SalaryDGV.SelectedRows[0].Cells[4].Value.ToString();
                string Advance = SalaryDGV.SelectedRows[0].Cells[5].Value.ToString();
                string Tax = SalaryDGV.SelectedRows[0].Cells[6].Value.ToString();
                string Balance = SalaryDGV.SelectedRows[0].Cells[7].Value.ToString();
                string Period = SalaryDGV.SelectedRows[0].Cells[8].Value.ToString();

                e.Graphics.DrawString("Numero de Salario: " + SalNum, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 100));
                e.Graphics.DrawString("Id del empleado: " + EmpId, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 150));
                e.Graphics.DrawString("Nombre del Empleado: " + EmpName, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(250, 150));
                e.Graphics.DrawString("Salario base: " + BasSal, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 180));
                e.Graphics.DrawString("Bono: $ " + Bonus, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 210));
                e.Graphics.DrawString("Adelanto en salario: $ " + Advance, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 240));
                e.Graphics.DrawString("Impuesto (IVA+ISSS+Renta) : $ " + Tax, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 270));
                e.Graphics.DrawString("Total: $ " + Balance, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 300));
                e.Graphics.DrawString("Periodo: " + Period, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, new Point(50, 330));

                e.Graphics.DrawString("Desarollado por estudiantes de UNICAES" + Period, new Font("Arial", 8, FontStyle.Bold), Brushes.Crimson, new Point(150, 420));
                e.Graphics.DrawString("Version Final" + Period, new Font("Arial", 8, FontStyle.Bold), Brushes.Crimson, new Point(100, 435));
            }
            else
            {
                // Manejar el caso cuando no hay ninguna fila seleccionada
                MessageBox.Show("No hay ninguna fila seleccionada para imprimir.");
            }
        }

        private void SalaryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 500, 800);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Asistencia Obj = new Asistencia();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Empleados Obj = new Empleados();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Principal Obj = new Principal();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Bono Obj = new Bono();
            Obj.Show();
            this.Hide();
        }

        private void BalanceTb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}