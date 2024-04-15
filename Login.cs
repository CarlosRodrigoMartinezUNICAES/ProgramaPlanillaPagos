namespace ProgramaPlanillaPagos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UPasswordTb.Text == "")
            {
                MessageBox.Show("Falta informacion, revisa de nuevo");
            }
            else if (UnameTb.Text == "Admin" && UPasswordTb.Text == "Password")
            {
                Principal Obj = new Principal();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña es incorrecta, revisa de nuevo");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckmostrar.Checked)
            {
                UPasswordTb.PasswordChar = '*';
            }
            else
            {
                UPasswordTb.PasswordChar = '\0';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
