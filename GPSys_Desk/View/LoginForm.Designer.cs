
namespace GPSys_Desk
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_Login = new System.Windows.Forms.Label();
            this.Logo_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new GPSys_Desk.Controls.Buttons();
            this.link_PassRecForm = new System.Windows.Forms.LinkLabel();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.checkBox_Show_Pass = new System.Windows.Forms.CheckBox();
            this.label_IncoerenciaInfo1 = new System.Windows.Forms.Label();
            this.Logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_Login.Location = new System.Drawing.Point(96, 27);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(110, 38);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Login";
            // 
            // Logo_panel
            // 
            this.Logo_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo_panel.BackColor = System.Drawing.Color.Transparent;
            this.Logo_panel.Controls.Add(this.pictureBox1);
            this.Logo_panel.Controls.Add(this.pictureBox2);
            this.Logo_panel.Location = new System.Drawing.Point(70, 70);
            this.Logo_panel.Name = "Logo_panel";
            this.Logo_panel.Size = new System.Drawing.Size(162, 54);
            this.Logo_panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_User
            // 
            this.textBox_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox_User.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_User.Location = new System.Drawing.Point(29, 197);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.PlaceholderText = "Usuário";
            this.textBox_User.Size = new System.Drawing.Size(244, 27);
            this.textBox_User.TabIndex = 1;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Pass.Location = new System.Drawing.Point(29, 237);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.PasswordChar = '*';
            this.textBox_Pass.PlaceholderText = "Senha";
            this.textBox_Pass.Size = new System.Drawing.Size(244, 29);
            this.textBox_Pass.TabIndex = 2;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Entrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Entrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Entrar.BorderRadius = 15;
            this.btn_Entrar.BorderSize = 0;
            this.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btn_Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.Location = new System.Drawing.Point(29, 359);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(244, 61);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.TextColor = System.Drawing.Color.White;
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // link_PassRecForm
            // 
            this.link_PassRecForm.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.link_PassRecForm.AutoSize = true;
            this.link_PassRecForm.BackColor = System.Drawing.Color.Transparent;
            this.link_PassRecForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_PassRecForm.Font = new System.Drawing.Font("Gotham Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_PassRecForm.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_PassRecForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.link_PassRecForm.Location = new System.Drawing.Point(64, 431);
            this.link_PassRecForm.Name = "link_PassRecForm";
            this.link_PassRecForm.Size = new System.Drawing.Size(174, 18);
            this.link_PassRecForm.TabIndex = 5;
            this.link_PassRecForm.TabStop = true;
            this.link_PassRecForm.Text = "Esqueci-me da senha!";
            this.link_PassRecForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_PassRecForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_PassRecForm_LinkClicked);
            // 
            // label_Info1
            // 
            this.label_Info1.AutoSize = true;
            this.label_Info1.BackColor = System.Drawing.Color.Transparent;
            this.label_Info1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info1.Location = new System.Drawing.Point(46, 132);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(210, 19);
            this.label_Info1.TabIndex = 5;
            this.label_Info1.Text = "Para entrar, digite as suas";
            // 
            // label_Info2
            // 
            this.label_Info2.AutoSize = true;
            this.label_Info2.BackColor = System.Drawing.Color.Transparent;
            this.label_Info2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info2.Location = new System.Drawing.Point(101, 157);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(100, 19);
            this.label_Info2.TabIndex = 5;
            this.label_Info2.Text = "Credenciáis";
            // 
            // checkBox_Show_Pass
            // 
            this.checkBox_Show_Pass.AutoSize = true;
            this.checkBox_Show_Pass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Show_Pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_Show_Pass.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Show_Pass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox_Show_Pass.Location = new System.Drawing.Point(161, 272);
            this.checkBox_Show_Pass.Name = "checkBox_Show_Pass";
            this.checkBox_Show_Pass.Size = new System.Drawing.Size(116, 20);
            this.checkBox_Show_Pass.TabIndex = 3;
            this.checkBox_Show_Pass.Text = "Mostrar senha";
            this.checkBox_Show_Pass.UseVisualStyleBackColor = false;
            this.checkBox_Show_Pass.CheckedChanged += new System.EventHandler(this.checkBox_Show_Pass_CheckedChanged);
            // 
            // label_IncoerenciaInfo1
            // 
            this.label_IncoerenciaInfo1.AutoSize = true;
            this.label_IncoerenciaInfo1.BackColor = System.Drawing.Color.Transparent;
            this.label_IncoerenciaInfo1.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_IncoerenciaInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_IncoerenciaInfo1.Location = new System.Drawing.Point(29, 305);
            this.label_IncoerenciaInfo1.Name = "label_IncoerenciaInfo1";
            this.label_IncoerenciaInfo1.Size = new System.Drawing.Size(0, 16);
            this.label_IncoerenciaInfo1.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 516);
            this.Controls.Add(this.label_IncoerenciaInfo1);
            this.Controls.Add(this.checkBox_Show_Pass);
            this.Controls.Add(this.label_Info2);
            this.Controls.Add(this.label_Info1);
            this.Controls.Add(this.link_PassRecForm);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.Logo_panel);
            this.Controls.Add(this.label_Login);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 555);
            this.MinimumSize = new System.Drawing.Size(320, 555);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GP System";
            this.Logo_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Panel Logo_panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Pass;
        private Controls.Buttons btn_Entrar;
        private System.Windows.Forms.LinkLabel link_PassRecForm;
        private System.Windows.Forms.Label label_Info1;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.CheckBox checkBox_Show_Pass;
        private System.Windows.Forms.Label label_IncoerenciaInfo1;
    }
}

