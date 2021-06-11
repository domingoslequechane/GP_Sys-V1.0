
namespace GPSys_Desk
{
    partial class PassRecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassRecForm));
            this.checkBox_Show_Pass = new System.Windows.Forms.CheckBox();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.textBox_Cod = new System.Windows.Forms.TextBox();
            this.Logo_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.link_goToLogin = new System.Windows.Forms.LinkLabel();
            this.label_CodigoIncorrecto_Info2 = new System.Windows.Forms.Label();
            this.label_CodigoIncorrecto_Info1 = new System.Windows.Forms.Label();
            this.link_RecCodErrorForm = new System.Windows.Forms.LinkLabel();
            this.btn_Verificar = new GPSys_Desk.Controls.Buttons();
            this.label_Info3 = new System.Windows.Forms.Label();
            this.label_RecuperarSenha = new System.Windows.Forms.Label();
            this.Logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_Show_Pass
            // 
            this.checkBox_Show_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Show_Pass.AutoSize = true;
            this.checkBox_Show_Pass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Show_Pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_Show_Pass.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Show_Pass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox_Show_Pass.Location = new System.Drawing.Point(156, 247);
            this.checkBox_Show_Pass.Name = "checkBox_Show_Pass";
            this.checkBox_Show_Pass.Size = new System.Drawing.Size(122, 20);
            this.checkBox_Show_Pass.TabIndex = 34;
            this.checkBox_Show_Pass.Text = "Mostrar código";
            this.checkBox_Show_Pass.UseVisualStyleBackColor = false;
            this.checkBox_Show_Pass.CheckedChanged += new System.EventHandler(this.checkBox_Show_Pass_CheckedChanged);
            // 
            // label_Info2
            // 
            this.label_Info2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Info2.AutoSize = true;
            this.label_Info2.BackColor = System.Drawing.Color.Transparent;
            this.label_Info2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info2.Location = new System.Drawing.Point(60, 156);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(183, 19);
            this.label_Info2.TabIndex = 35;
            this.label_Info2.Text = "incira o seu código de";
            // 
            // label_Info1
            // 
            this.label_Info1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Info1.AutoSize = true;
            this.label_Info1.BackColor = System.Drawing.Color.Transparent;
            this.label_Info1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info1.Location = new System.Drawing.Point(39, 131);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(225, 19);
            this.label_Info1.TabIndex = 37;
            this.label_Info1.Text = "Para recuperar a sua senha,";
            // 
            // textBox_Cod
            // 
            this.textBox_Cod.AcceptsReturn = true;
            this.textBox_Cod.AcceptsTab = true;
            this.textBox_Cod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Cod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Cod.Location = new System.Drawing.Point(29, 214);
            this.textBox_Cod.MaxLength = 30;
            this.textBox_Cod.Name = "textBox_Cod";
            this.textBox_Cod.PlaceholderText = "Código de recuperação";
            this.textBox_Cod.Size = new System.Drawing.Size(244, 29);
            this.textBox_Cod.TabIndex = 33;
            // 
            // Logo_panel
            // 
            this.Logo_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo_panel.BackColor = System.Drawing.Color.Transparent;
            this.Logo_panel.Controls.Add(this.pictureBox1);
            this.Logo_panel.Controls.Add(this.pictureBox2);
            this.Logo_panel.Location = new System.Drawing.Point(70, 68);
            this.Logo_panel.Name = "Logo_panel";
            this.Logo_panel.Size = new System.Drawing.Size(162, 54);
            this.Logo_panel.TabIndex = 32;
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
            // link_goToLogin
            // 
            this.link_goToLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.link_goToLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_goToLogin.AutoSize = true;
            this.link_goToLogin.BackColor = System.Drawing.Color.Transparent;
            this.link_goToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_goToLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.link_goToLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_goToLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.link_goToLogin.Location = new System.Drawing.Point(128, 432);
            this.link_goToLogin.Name = "link_goToLogin";
            this.link_goToLogin.Size = new System.Drawing.Size(46, 19);
            this.link_goToLogin.TabIndex = 42;
            this.link_goToLogin.TabStop = true;
            this.link_goToLogin.Text = "Login";
            this.link_goToLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.link_goToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_goToLogin_LinkClicked);
            // 
            // label_CodigoIncorrecto_Info2
            // 
            this.label_CodigoIncorrecto_Info2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CodigoIncorrecto_Info2.AutoSize = true;
            this.label_CodigoIncorrecto_Info2.BackColor = System.Drawing.Color.Transparent;
            this.label_CodigoIncorrecto_Info2.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_CodigoIncorrecto_Info2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_CodigoIncorrecto_Info2.Location = new System.Drawing.Point(33, 293);
            this.label_CodigoIncorrecto_Info2.Name = "label_CodigoIncorrecto_Info2";
            this.label_CodigoIncorrecto_Info2.Size = new System.Drawing.Size(0, 16);
            this.label_CodigoIncorrecto_Info2.TabIndex = 40;
            // 
            // label_CodigoIncorrecto_Info1
            // 
            this.label_CodigoIncorrecto_Info1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CodigoIncorrecto_Info1.AutoSize = true;
            this.label_CodigoIncorrecto_Info1.BackColor = System.Drawing.Color.Transparent;
            this.label_CodigoIncorrecto_Info1.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_CodigoIncorrecto_Info1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_CodigoIncorrecto_Info1.Location = new System.Drawing.Point(33, 272);
            this.label_CodigoIncorrecto_Info1.Name = "label_CodigoIncorrecto_Info1";
            this.label_CodigoIncorrecto_Info1.Size = new System.Drawing.Size(0, 16);
            this.label_CodigoIncorrecto_Info1.TabIndex = 41;
            // 
            // link_RecCodErrorForm
            // 
            this.link_RecCodErrorForm.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.link_RecCodErrorForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_RecCodErrorForm.AutoSize = true;
            this.link_RecCodErrorForm.BackColor = System.Drawing.Color.Transparent;
            this.link_RecCodErrorForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_RecCodErrorForm.Font = new System.Drawing.Font("Gotham Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_RecCodErrorForm.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_RecCodErrorForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.link_RecCodErrorForm.Location = new System.Drawing.Point(58, 404);
            this.link_RecCodErrorForm.Name = "link_RecCodErrorForm";
            this.link_RecCodErrorForm.Size = new System.Drawing.Size(186, 18);
            this.link_RecCodErrorForm.TabIndex = 39;
            this.link_RecCodErrorForm.TabStop = true;
            this.link_RecCodErrorForm.Text = "Esqueci-me do Código!";
            this.link_RecCodErrorForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_RecCodErrorForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_RecCodErrorForm_LinkClicked_1);
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Verificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Verificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Verificar.BorderColor = System.Drawing.Color.Black;
            this.btn_Verificar.BorderRadius = 15;
            this.btn_Verificar.BorderSize = 0;
            this.btn_Verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Verificar.FlatAppearance.BorderSize = 0;
            this.btn_Verificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btn_Verificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verificar.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Verificar.ForeColor = System.Drawing.Color.White;
            this.btn_Verificar.Location = new System.Drawing.Point(29, 335);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(244, 61);
            this.btn_Verificar.TabIndex = 38;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.TextColor = System.Drawing.Color.White;
            this.btn_Verificar.UseVisualStyleBackColor = false;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // label_Info3
            // 
            this.label_Info3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Info3.AutoSize = true;
            this.label_Info3.BackColor = System.Drawing.Color.Transparent;
            this.label_Info3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info3.Location = new System.Drawing.Point(96, 181);
            this.label_Info3.Name = "label_Info3";
            this.label_Info3.Size = new System.Drawing.Size(110, 19);
            this.label_Info3.TabIndex = 36;
            this.label_Info3.Text = "recuperação!";
            // 
            // label_RecuperarSenha
            // 
            this.label_RecuperarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_RecuperarSenha.AutoSize = true;
            this.label_RecuperarSenha.BackColor = System.Drawing.Color.Transparent;
            this.label_RecuperarSenha.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_RecuperarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_RecuperarSenha.Location = new System.Drawing.Point(43, 31);
            this.label_RecuperarSenha.Name = "label_RecuperarSenha";
            this.label_RecuperarSenha.Size = new System.Drawing.Size(216, 29);
            this.label_RecuperarSenha.TabIndex = 31;
            this.label_RecuperarSenha.Text = "Recuperar senha";
            // 
            // PassRecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 516);
            this.Controls.Add(this.checkBox_Show_Pass);
            this.Controls.Add(this.label_Info2);
            this.Controls.Add(this.label_Info1);
            this.Controls.Add(this.textBox_Cod);
            this.Controls.Add(this.Logo_panel);
            this.Controls.Add(this.link_goToLogin);
            this.Controls.Add(this.label_CodigoIncorrecto_Info2);
            this.Controls.Add(this.label_CodigoIncorrecto_Info1);
            this.Controls.Add(this.link_RecCodErrorForm);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.label_Info3);
            this.Controls.Add(this.label_RecuperarSenha);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 555);
            this.MinimumSize = new System.Drawing.Size(320, 555);
            this.Name = "PassRecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GP System";
            this.Logo_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Show_Pass;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.Label label_Info1;
        private System.Windows.Forms.TextBox textBox_Cod;
        private System.Windows.Forms.Panel Logo_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel link_goToLogin;
        private System.Windows.Forms.Label label_CodigoIncorrecto_Info2;
        private System.Windows.Forms.Label label_CodigoIncorrecto_Info1;
        private System.Windows.Forms.LinkLabel link_RecCodErrorForm;
        private Controls.Buttons btn_Verificar;
        private System.Windows.Forms.Label label_Info3;
        private System.Windows.Forms.Label label_RecuperarSenha;
    }
}