namespace ProgramaPlanillaPagos
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            UnameTb = new TextBox();
            UPasswordTb = new TextBox();
            LoginBtn = new PictureBox();
            label4 = new Label();
            ExitButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 420);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(311, 15);
            label1.Name = "label1";
            label1.Size = new Size(316, 32);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Planillas de Pago";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(453, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(338, 148);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 10;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(338, 237);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 11;
            label3.Text = "Contraseña";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(338, 181);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(266, 23);
            UnameTb.TabIndex = 12;
            // 
            // UPasswordTb
            // 
            UPasswordTb.Location = new Point(338, 270);
            UPasswordTb.Name = "UPasswordTb";
            UPasswordTb.Size = new Size(266, 23);
            UPasswordTb.TabIndex = 13;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.Image = (Image)resources.GetObject("LoginBtn.Image");
            LoginBtn.Location = new Point(453, 347);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(35, 36);
            LoginBtn.SizeMode = PictureBoxSizeMode.Zoom;
            LoginBtn.TabIndex = 15;
            LoginBtn.TabStop = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(402, 314);
            label4.Name = "label4";
            label4.Size = new Size(144, 30);
            label4.TabIndex = 16;
            label4.Text = "Iniciar Sesion";
            // 
            // ExitButton
            // 
            ExitButton.Image = (Image)resources.GetObject("ExitButton.Image");
            ExitButton.Location = new Point(709, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(35, 36);
            ExitButton.SizeMode = PictureBoxSizeMode.Zoom;
            ExitButton.TabIndex = 17;
            ExitButton.TabStop = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(744, 420);
            Controls.Add(ExitButton);
            Controls.Add(label4);
            Controls.Add(LoginBtn);
            Controls.Add(UPasswordTb);
            Controls.Add(UnameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox UnameTb;
        private TextBox UPasswordTb;
        private PictureBox LoginBtn;
        private Label label4;
        private PictureBox ExitButton;
    }
}