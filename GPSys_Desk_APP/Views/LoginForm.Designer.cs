
namespace GPSys_Desk_APP.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Link_PassRec = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.btn_Entrar = new GPSys_Desk_APP.Controls.Buttons();
            this.checkBox_Pass = new System.Windows.Forms.CheckBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label_Info2 = new System.Windows.Forms.Label();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Link_PassRec);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Login);
            this.panel1.Controls.Add(this.btn_Entrar);
            this.panel1.Controls.Add(this.checkBox_Pass);
            this.panel1.Controls.Add(this.textBox_Pass);
            this.panel1.Controls.Add(this.textBox_User);
            this.panel1.Controls.Add(this.label_Info2);
            this.panel1.Controls.Add(this.label_Info1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 516);
            this.panel1.TabIndex = 0;
            // 
            // Link_PassRec
            // 
            this.Link_PassRec.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Link_PassRec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Link_PassRec.AutoSize = true;
            this.Link_PassRec.BackColor = System.Drawing.Color.Transparent;
            this.Link_PassRec.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_PassRec.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Link_PassRec.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Link_PassRec.Location = new System.Drawing.Point(59, 409);
            this.Link_PassRec.Name = "Link_PassRec";
            this.Link_PassRec.Size = new System.Drawing.Size(187, 19);
            this.Link_PassRec.TabIndex = 16;
            this.Link_PassRec.TabStop = true;
            this.Link_PassRec.Text = "Esqueci-me da senha!";
            this.Link_PassRec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_PassRec_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(67, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 54);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(116, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login.Font = new System.Drawing.Font("Gotham", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_Login.Location = new System.Drawing.Point(91, 42);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(122, 43);
            this.label_Login.TabIndex = 9;
            this.label_Login.Text = "Login";
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Entrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Entrar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Entrar.BorderRadius = 15;
            this.btn_Entrar.BorderSize = 0;
            this.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.Location = new System.Drawing.Point(36, 339);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(232, 61);
            this.btn_Entrar.TabIndex = 17;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.TextColor = System.Drawing.Color.White;
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // checkBox_Pass
            // 
            this.checkBox_Pass.AutoSize = true;
            this.checkBox_Pass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Pass.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkBox_Pass.Location = new System.Drawing.Point(150, 281);
            this.checkBox_Pass.Name = "checkBox_Pass";
            this.checkBox_Pass.Size = new System.Drawing.Size(126, 21);
            this.checkBox_Pass.TabIndex = 15;
            this.checkBox_Pass.Text = "Mostrar senha";
            this.checkBox_Pass.UseVisualStyleBackColor = false;
            this.checkBox_Pass.CheckedChanged += new System.EventHandler(this.checkBox_Pass_CheckedChanged);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(36, 248);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(232, 27);
            this.textBox_Pass.TabIndex = 14;
            // 
            // textBox_User
            // 
            this.textBox_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox_User.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_User.Location = new System.Drawing.Point(36, 210);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(232, 27);
            this.textBox_User.TabIndex = 13;
            // 
            // label_Info2
            // 
            this.label_Info2.AutoSize = true;
            this.label_Info2.BackColor = System.Drawing.Color.Transparent;
            this.label_Info2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_Info2.Location = new System.Drawing.Point(102, 173);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(100, 19);
            this.label_Info2.TabIndex = 12;
            this.label_Info2.Text = "Credenciáis";
            // 
            // label_Info1
            // 
            this.label_Info1.AutoSize = true;
            this.label_Info1.BackColor = System.Drawing.Color.Transparent;
            this.label_Info1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_Info1.Location = new System.Drawing.Point(47, 148);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(210, 19);
            this.label_Info1.TabIndex = 11;
            this.label_Info1.Text = "Para entrar, digite as suas";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 555);
            this.MinimumSize = new System.Drawing.Size(320, 555);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GP System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel Link_PassRec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Login;
        private Controls.Buttons btn_Entrar;
        private System.Windows.Forms.CheckBox checkBox_Pass;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.Label label_Info1;
    }
}