namespace ProgramaPlanillaPagos
{
    partial class Bono
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bono));
            panel1 = new Panel();
            BonusDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            panel2 = new Panel();
            pictureBox10 = new PictureBox();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox11 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            BAmountTb = new TextBox();
            label7 = new Label();
            BNameTb = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox9 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BonusDGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BonusDGV);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(BAmountTb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(BNameTb);
            panel1.Location = new Point(76, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 506);
            panel1.TabIndex = 43;
            // 
            // BonusDGV
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            BonusDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            BonusDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            BonusDGV.ColumnHeadersHeight = 4;
            BonusDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            BonusDGV.DefaultCellStyle = dataGridViewCellStyle12;
            BonusDGV.GridColor = Color.FromArgb(231, 229, 255);
            BonusDGV.Location = new Point(54, 174);
            BonusDGV.Name = "BonusDGV";
            BonusDGV.RowHeadersVisible = false;
            BonusDGV.RowHeadersWidth = 51;
            BonusDGV.RowTemplate.Height = 25;
            BonusDGV.Size = new Size(589, 166);
            BonusDGV.TabIndex = 53;
            BonusDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BonusDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BonusDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BonusDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BonusDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BonusDGV.ThemeStyle.BackColor = Color.White;
            BonusDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BonusDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            BonusDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BonusDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BonusDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BonusDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BonusDGV.ThemeStyle.HeaderStyle.Height = 4;
            BonusDGV.ThemeStyle.ReadOnly = false;
            BonusDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BonusDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BonusDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BonusDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BonusDGV.ThemeStyle.RowsStyle.Height = 25;
            BonusDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            BonusDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            BonusDGV.CellContentClick += BonusDGV_CellContentClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(406, 411);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 52;
            DeleteBtn.Text = "Eliminar";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(305, 411);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 51;
            EditBtn.Text = "Editar";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(207, 411);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 50;
            SaveBtn.Text = "Guardar";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 66);
            panel2.TabIndex = 49;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(777, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(35, 36);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(240, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(128, 10);
            panel4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(512, 14);
            label6.Name = "label6";
            label6.Size = new Size(89, 32);
            label6.TabIndex = 5;
            label6.Text = "Planilla";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(375, 14);
            label5.Name = "label5";
            label5.Size = new Size(119, 32);
            label5.TabIndex = 4;
            label5.Text = "Asistencia";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(268, 14);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 2;
            label3.Text = "Bonos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(119, 14);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            label1.Click += label1_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(424, 365);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(40, 40);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 45;
            pictureBox11.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(322, 365);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 44;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(225, 365);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 43;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(412, 106);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 41;
            label8.Text = "Cantidad";
            // 
            // BAmountTb
            // 
            BAmountTb.Location = new Point(412, 129);
            BAmountTb.Name = "BAmountTb";
            BAmountTb.Size = new Size(113, 23);
            BAmountTb.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(185, 106);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 39;
            label7.Text = "Razon de bono";
            // 
            // BNameTb
            // 
            BNameTb.Location = new Point(185, 129);
            BNameTb.Name = "BNameTb";
            BNameTb.Size = new Size(113, 23);
            BNameTb.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(23, 442);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(35, 36);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 45;
            pictureBox9.TabStop = false;
            // 
            // Bono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(889, 505);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bono";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bono";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BonusDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox11;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label8;
        private TextBox BAmountTb;
        private Label label7;
        private TextBox BNameTb;
        private Panel panel2;
        private PictureBox pictureBox10;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private Guna.UI2.WinForms.Guna2DataGridView BonusDGV;
    }
}