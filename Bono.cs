using System.Data;
using System.Data.SqlClient;

namespace ProgramaPlanillaPagos
{
    public partial class Bono : Form
    {
        public Bono()
        {
            InitializeComponent();
            ShowBonus();
        }

        private SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LGTP4HK\SQLEXPRESS;Initial Catalog=Planilla;Integrated Security=True");

        private void Clear()
        {
            BNameTb.Text = "";
            BAmountTb.Text = "";
            Key = 0;
        }

        private void ShowBonus()
        {
            Connection.Open();
            String Query = " Select * from BonusTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BonusDGV.DataSource = ds.Tables[0];
            Connection.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "")
            {
                MessageBox.Show("Falta Informacion");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into BonusTbl(Bname,Bamt) values(@BN,@BA)", Connection);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bono Guardado");
                    Connection.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private int Key = 0;

        private void BonusDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BNameTb.Text = BonusDGV.SelectedRows[0].Cells[1].Value.ToString();
            BAmountTb.Text = BonusDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (BNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BonusDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "")
            {
                MessageBox.Show("Falta Informacion");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Update BonusTbl Set BName=@BN, BAmt=@BA where Bid=@Bkey", Connection);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                    cmd.Parameters.AddWithValue("@BKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Actualizar Bono");
                    Connection.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Seleciona el bono");
            }
            else
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("Delete from BonusTbl Where BId=@BKey", Connection);
                    cmd.Parameters.AddWithValue("@BKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bono Eliminado");
                    Connection.Close();
                    ShowBonus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void label5_Click(object sender, EventArgs e)
        {
            Asistencia Obj = new Asistencia();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Salario Obj = new Salario();
            Obj.Show();
            this.Hide();
        }
    }
}