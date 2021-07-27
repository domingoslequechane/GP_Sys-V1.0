
namespace GPSys_Desk_APP.Views
{
    partial class DBConnectionSettingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConnectionSettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ShowHidePassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_ServerPort = new System.Windows.Forms.ComboBox();

            this.Cb_ServerName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cb_DBUserName = new System.Windows.Forms.ComboBox();
            this.Tb_DBPassword = new System.Windows.Forms.TextBox();
            this.Cb_DBName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Save = new GPSys_Desk_APP.Controls.Buttons();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_TestConnection = new GPSys_Desk_APP.Controls.Buttons();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.ShowHidePassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cb_ServerPort);
            this.groupBox1.Controls.Add(this.Cb_ServerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Cb_DBUserName);
            this.groupBox1.Controls.Add(this.Tb_DBPassword);
            this.groupBox1.Controls.Add(this.Cb_DBName);
            this.groupBox1.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 448);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conectar-se ao BD";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(292, 400);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(20, 20);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 36;
            this.pictureBox.TabStop = false;
            // 
            // ShowHidePassword
            // 
            this.ShowHidePassword.AutoSize = true;
            this.ShowHidePassword.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHidePassword.Location = new System.Drawing.Point(275, 403);
            this.ShowHidePassword.Name = "ShowHidePassword";
            this.ShowHidePassword.Size = new System.Drawing.Size(15, 14);
            this.ShowHidePassword.TabIndex = 6;
            this.ShowHidePassword.UseVisualStyleBackColor = true;
            this.ShowHidePassword.CheckedChanged += new System.EventHandler(this.ShowHidePassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "abaixo para se conectar ao servidor!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Por favor, preencha os campos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Porta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Servidor: *";
            // 
            // Cb_ServerPort
            // 
            this.Cb_ServerPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cb_ServerPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.Cb_ServerPort.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ServerPort.FormattingEnabled = true;
            this.Cb_ServerPort.Location = new System.Drawing.Point(30, 202);
            this.Cb_ServerPort.Name = "Cb_ServerPort";
            this.Cb_ServerPort.Size = new System.Drawing.Size(287, 27);
            this.Cb_ServerPort.TabIndex = 1;
            // 
            // Cb_ServerName
            // 
            this.Cb_ServerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cb_ServerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.Cb_ServerName.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ServerName.FormattingEnabled = true;
            this.Cb_ServerName.Location = new System.Drawing.Point(30, 137);
            this.Cb_ServerName.Name = "Cb_ServerName";
            this.Cb_ServerName.Size = new System.Drawing.Size(287, 27);
            this.Cb_ServerName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Banco de Dados: *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Senha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Usuário: *";
            // 
            // Cb_DBUserName
            // 
            this.Cb_DBUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cb_DBUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.Cb_DBUserName.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_DBUserName.FormattingEnabled = true;
            this.Cb_DBUserName.Location = new System.Drawing.Point(30, 332);
            this.Cb_DBUserName.Name = "Cb_DBUserName";
            this.Cb_DBUserName.Size = new System.Drawing.Size(287, 27);
            this.Cb_DBUserName.TabIndex = 3;
            // 
            // Tb_DBPassword
            // 
            this.Tb_DBPassword.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_DBPassword.Location = new System.Drawing.Point(30, 397);
            this.Tb_DBPassword.Name = "Tb_DBPassword";
            this.Tb_DBPassword.Size = new System.Drawing.Size(239, 27);
            this.Tb_DBPassword.TabIndex = 4;
            // 
            // Cb_DBName
            // 
            this.Cb_DBName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cb_DBName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.Cb_DBName.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_DBName.FormattingEnabled = true;
            this.Cb_DBName.Location = new System.Drawing.Point(30, 267);
            this.Cb_DBName.Name = "Cb_DBName";
            this.Cb_DBName.Size = new System.Drawing.Size(287, 27);
            this.Cb_DBName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Btn_TestConnection);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 638);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 612);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 26);
            this.panel3.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "dos dados informados!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "\"Testar Conexão\" para verificar a autenticação";
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_Save.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Save.BorderRadius = 10;
            this.Btn_Save.BorderSize = 0;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Location = new System.Drawing.Point(214, 571);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(163, 37);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Guardar";
            this.Btn_Save.TextColor = System.Drawing.Color.White;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Antes de Guardar as informações, clique em";
            // 
            // Btn_TestConnection
            // 
            this.Btn_TestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_TestConnection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_TestConnection.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_TestConnection.BorderRadius = 10;
            this.Btn_TestConnection.BorderSize = 0;
            this.Btn_TestConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TestConnection.FlatAppearance.BorderSize = 0;
            this.Btn_TestConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_TestConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_TestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TestConnection.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TestConnection.ForeColor = System.Drawing.Color.White;
            this.Btn_TestConnection.Location = new System.Drawing.Point(30, 571);
            this.Btn_TestConnection.Name = "Btn_TestConnection";
            this.Btn_TestConnection.Size = new System.Drawing.Size(163, 37);
            this.Btn_TestConnection.TabIndex = 0;
            this.Btn_TestConnection.Text = "Testar Conexão";
            this.Btn_TestConnection.TextColor = System.Drawing.Color.White;
            this.Btn_TestConnection.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(405, 10);
            this.panel6.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 10);
            this.panel2.TabIndex = 48;
            // 
            // DBConnectionSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(405, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 677);
            this.MinimumSize = new System.Drawing.Size(421, 677);
            this.Name = "DBConnectionSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração BD";
            this.Load += new System.EventHandler(this.ConnectionSettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_ServerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cb_DBUserName;
        private System.Windows.Forms.TextBox Tb_DBPassword;
        private Controls.Buttons Btn_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_ServerPort;
        private System.Windows.Forms.ComboBox Cb_DBName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Controls.Buttons Btn_TestConnection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox ShowHidePassword;
    }
}