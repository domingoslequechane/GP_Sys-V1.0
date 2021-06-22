
namespace GPSys_Desk_APP.Views
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_Login = new System.Windows.Forms.LinkLabel();
            this.Link_CodeRec = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.btn_Verificar = new GPSys_Desk_APP.Controls.Buttons();
            this.checkBox_Pass = new System.Windows.Forms.CheckBox();
            this.textBox_RecCode = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.link_Login);
            this.panel1.Controls.Add(this.Link_CodeRec);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Login);
            this.panel1.Controls.Add(this.btn_Verificar);
            this.panel1.Controls.Add(this.checkBox_Pass);
            this.panel1.Controls.Add(this.textBox_RecCode);
            this.panel1.Controls.Add(this.label_Info2);
            this.panel1.Controls.Add(this.label_Info1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 516);
            this.panel1.TabIndex = 1;
            // 
            // link_Login
            // 
            this.link_Login.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.link_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_Login.AutoSize = true;
            this.link_Login.BackColor = System.Drawing.Color.Transparent;
            this.link_Login.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Login.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_Login.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.link_Login.Location = new System.Drawing.Point(124, 433);
            this.link_Login.Name = "link_Login";
            this.link_Login.Size = new System.Drawing.Size(56, 19);
            this.link_Login.TabIndex = 16;
            this.link_Login.TabStop = true;
            this.link_Login.Text = "Login";
            this.link_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Login_LinkClicked);
            // 
            // Link_CodeRec
            // 
            this.Link_CodeRec.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Link_CodeRec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Link_CodeRec.AutoSize = true;
            this.Link_CodeRec.BackColor = System.Drawing.Color.Transparent;
            this.Link_CodeRec.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_CodeRec.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Link_CodeRec.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Link_CodeRec.Location = new System.Drawing.Point(52, 409);
            this.Link_CodeRec.Name = "Link_CodeRec";
            this.Link_CodeRec.Size = new System.Drawing.Size(200, 19);
            this.Link_CodeRec.TabIndex = 16;
            this.Link_CodeRec.TabStop = true;
            this.Link_CodeRec.Text = "Esqueci-me do código!";
            this.Link_CodeRec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_CodeRec_LinkClicked);
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
            this.label_Login.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_Login.Location = new System.Drawing.Point(44, 56);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(216, 29);
            this.label_Login.TabIndex = 9;
            this.label_Login.Text = "Recuperar senha";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Verificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Verificar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Verificar.BorderRadius = 15;
            this.btn_Verificar.BorderSize = 0;
            this.btn_Verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Verificar.FlatAppearance.BorderSize = 0;
            this.btn_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verificar.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verificar.ForeColor = System.Drawing.Color.White;
            this.btn_Verificar.Location = new System.Drawing.Point(36, 339);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(232, 61);
            this.btn_Verificar.TabIndex = 17;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.TextColor = System.Drawing.Color.White;
            this.btn_Verificar.UseVisualStyleBackColor = false;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // checkBox_Pass
            // 
            this.checkBox_Pass.AutoSize = true;
            this.checkBox_Pass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Pass.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkBox_Pass.Location = new System.Drawing.Point(144, 243);
            this.checkBox_Pass.Name = "checkBox_Pass";
            this.checkBox_Pass.Size = new System.Drawing.Size(133, 21);
            this.checkBox_Pass.TabIndex = 15;
            this.checkBox_Pass.Text = "Mostrar código";
            this.checkBox_Pass.UseVisualStyleBackColor = false;
            this.checkBox_Pass.CheckedChanged += new System.EventHandler(this.checkBox_Pass_CheckedChanged);
            // 
            // textBox_RecCode
            // 
            this.textBox_RecCode.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RecCode.Location = new System.Drawing.Point(36, 210);
            this.textBox_RecCode.Name = "textBox_RecCode";
            this.textBox_RecCode.Size = new System.Drawing.Size(232, 27);
            this.textBox_RecCode.TabIndex = 13;
            this.textBox_RecCode.UseSystemPasswordChar = true;
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
            // PassRecForm
            // 
            this.AcceptButton = this.btn_Verificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 555);
            this.MinimumSize = new System.Drawing.Size(320, 555);
            this.Name = "PassRecForm";
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
        private System.Windows.Forms.LinkLabel Link_CodeRec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Login;
        private Controls.Buttons btn_Verificar;
        private System.Windows.Forms.CheckBox checkBox_Pass;
        private System.Windows.Forms.TextBox textBox_RecCode;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.Label label_Info1;
        private System.Windows.Forms.LinkLabel link_Login;
    }
}