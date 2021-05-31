
namespace GPSys_Desk.View
{
    partial class NewPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassForm));
            this.Logo_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.checkBox_Show_Pass = new System.Windows.Forms.CheckBox();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.btn_Actualizar = new GPSys_Desk.Controls.Buttons();
            this.textBox_NewPass2 = new System.Windows.Forms.TextBox();
            this.textBox_NewPass1 = new System.Windows.Forms.TextBox();
            this.label_IncoerenciaInfo1 = new System.Windows.Forms.Label();
            this.label_IncoerenciaInfo2 = new System.Windows.Forms.Label();
            this.link_GoToLogin = new System.Windows.Forms.LinkLabel();
            this.Logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.Logo_panel.TabIndex = 7;
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
            // label_Login
            // 
            this.label_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_Login.Location = new System.Drawing.Point(49, 27);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(204, 38);
            this.label_Login.TabIndex = 6;
            this.label_Login.Text = "Nova senha";
            // 
            // checkBox_Show_Pass
            // 
            this.checkBox_Show_Pass.AutoSize = true;
            this.checkBox_Show_Pass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Show_Pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_Show_Pass.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Show_Pass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox_Show_Pass.Location = new System.Drawing.Point(163, 280);
            this.checkBox_Show_Pass.Name = "checkBox_Show_Pass";
            this.checkBox_Show_Pass.Size = new System.Drawing.Size(116, 20);
            this.checkBox_Show_Pass.TabIndex = 10;
            this.checkBox_Show_Pass.Text = "Mostrar senha";
            this.checkBox_Show_Pass.UseVisualStyleBackColor = false;
            // 
            // label_Info2
            // 
            this.label_Info2.AutoSize = true;
            this.label_Info2.BackColor = System.Drawing.Color.Transparent;
            this.label_Info2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info2.Location = new System.Drawing.Point(70, 164);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(162, 19);
            this.label_Info2.TabIndex = 12;
            this.label_Info2.Text = "com mais ninguem!";
            // 
            // label_Info1
            // 
            this.label_Info1.AutoSize = true;
            this.label_Info1.BackColor = System.Drawing.Color.Transparent;
            this.label_Info1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info1.Location = new System.Drawing.Point(33, 139);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(236, 19);
            this.label_Info1.TabIndex = 13;
            this.label_Info1.Text = "Lembre-se de não a partilhar";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Actualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Actualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Actualizar.BorderRadius = 15;
            this.btn_Actualizar.BorderSize = 0;
            this.btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.btn_Actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btn_Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar.Location = new System.Drawing.Point(29, 360);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(244, 61);
            this.btn_Actualizar.TabIndex = 11;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.TextColor = System.Drawing.Color.White;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // textBox_NewPass2
            // 
            this.textBox_NewPass2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_NewPass2.Location = new System.Drawing.Point(29, 247);
            this.textBox_NewPass2.Name = "textBox_NewPass2";
            this.textBox_NewPass2.PasswordChar = '*';
            this.textBox_NewPass2.PlaceholderText = "Redigite a nova senha";
            this.textBox_NewPass2.Size = new System.Drawing.Size(244, 27);
            this.textBox_NewPass2.TabIndex = 9;
            // 
            // textBox_NewPass1
            // 
            this.textBox_NewPass1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_NewPass1.Location = new System.Drawing.Point(29, 207);
            this.textBox_NewPass1.Name = "textBox_NewPass1";
            this.textBox_NewPass1.PasswordChar = '*';
            this.textBox_NewPass1.PlaceholderText = "Nova senha";
            this.textBox_NewPass1.Size = new System.Drawing.Size(244, 27);
            this.textBox_NewPass1.TabIndex = 8;
            // 
            // label_IncoerenciaInfo1
            // 
            this.label_IncoerenciaInfo1.AutoSize = true;
            this.label_IncoerenciaInfo1.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_IncoerenciaInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_IncoerenciaInfo1.Location = new System.Drawing.Point(33, 304);
            this.label_IncoerenciaInfo1.Name = "label_IncoerenciaInfo1";
            this.label_IncoerenciaInfo1.Size = new System.Drawing.Size(0, 16);
            this.label_IncoerenciaInfo1.TabIndex = 14;
            // 
            // label_IncoerenciaInfo2
            // 
            this.label_IncoerenciaInfo2.AutoSize = true;
            this.label_IncoerenciaInfo2.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_IncoerenciaInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_IncoerenciaInfo2.Location = new System.Drawing.Point(33, 320);
            this.label_IncoerenciaInfo2.Name = "label_IncoerenciaInfo2";
            this.label_IncoerenciaInfo2.Size = new System.Drawing.Size(0, 16);
            this.label_IncoerenciaInfo2.TabIndex = 14;
            // 
            // link_GoToLogin
            // 
            this.link_GoToLogin.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.link_GoToLogin.AutoSize = true;
            this.link_GoToLogin.BackColor = System.Drawing.Color.Transparent;
            this.link_GoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_GoToLogin.Font = new System.Drawing.Font("Gotham Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_GoToLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_GoToLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.link_GoToLogin.Location = new System.Drawing.Point(126, 433);
            this.link_GoToLogin.Name = "link_GoToLogin";
            this.link_GoToLogin.Size = new System.Drawing.Size(50, 18);
            this.link_GoToLogin.TabIndex = 15;
            this.link_GoToLogin.TabStop = true;
            this.link_GoToLogin.Text = "Login";
            this.link_GoToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_GoToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_GoToLogin_LinkClicked);
            // 
            // NewPassForm
            // 
            this.AcceptButton = this.btn_Actualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 516);
            this.Controls.Add(this.link_GoToLogin);
            this.Controls.Add(this.label_IncoerenciaInfo2);
            this.Controls.Add(this.label_IncoerenciaInfo1);
            this.Controls.Add(this.Logo_panel);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.checkBox_Show_Pass);
            this.Controls.Add(this.label_Info2);
            this.Controls.Add(this.label_Info1);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.textBox_NewPass2);
            this.Controls.Add(this.textBox_NewPass1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 555);
            this.MinimumSize = new System.Drawing.Size(320, 535);
            this.Name = "NewPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GP Sys";
            this.Logo_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Logo_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.CheckBox checkBox_Show_Pass;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.Label label_Info1;
        private Controls.Buttons btn_Actualizar;
        private System.Windows.Forms.TextBox textBox_NewPass2;
        private System.Windows.Forms.TextBox textBox_NewPass1;
        private System.Windows.Forms.Label label_IncoerenciaInfo1;
        private System.Windows.Forms.Label label_IncoerenciaInfo2;
        private System.Windows.Forms.LinkLabel link_GoToLogin;
    }
}