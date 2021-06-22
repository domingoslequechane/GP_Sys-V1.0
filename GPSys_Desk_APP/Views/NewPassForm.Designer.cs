
namespace GPSys_Desk_APP.Views
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Login = new System.Windows.Forms.Label();
            this.Link_Login = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Atualizar = new GPSys_Desk_APP.Controls.Buttons();
            this.checkBox_Pass12 = new System.Windows.Forms.CheckBox();
            this.textBox_NewPass2 = new System.Windows.Forms.TextBox();
            this.textBox_NewPass1 = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.label_Login);
            this.panel1.Controls.Add(this.Link_Login);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_Atualizar);
            this.panel1.Controls.Add(this.checkBox_Pass12);
            this.panel1.Controls.Add(this.textBox_NewPass2);
            this.panel1.Controls.Add(this.textBox_NewPass1);
            this.panel1.Controls.Add(this.label_Info2);
            this.panel1.Controls.Add(this.label_Info1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 516);
            this.panel1.TabIndex = 1;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_Login.Location = new System.Drawing.Point(50, 47);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(204, 38);
            this.label_Login.TabIndex = 18;
            this.label_Login.Text = "Nova senha";
            // 
            // Link_Login
            // 
            this.Link_Login.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Link_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Link_Login.AutoSize = true;
            this.Link_Login.BackColor = System.Drawing.Color.Transparent;
            this.Link_Login.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Login.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Link_Login.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Link_Login.Location = new System.Drawing.Point(124, 409);
            this.Link_Login.Name = "Link_Login";
            this.Link_Login.Size = new System.Drawing.Size(56, 19);
            this.Link_Login.TabIndex = 16;
            this.Link_Login.TabStop = true;
            this.Link_Login.Text = "Login";
            this.Link_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Login_LinkClicked);
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
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Atualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Atualizar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Atualizar.BorderRadius = 15;
            this.btn_Atualizar.BorderSize = 0;
            this.btn_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atualizar.FlatAppearance.BorderSize = 0;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Atualizar.Location = new System.Drawing.Point(36, 339);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(232, 61);
            this.btn_Atualizar.TabIndex = 17;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.TextColor = System.Drawing.Color.White;
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // checkBox_Pass12
            // 
            this.checkBox_Pass12.AutoSize = true;
            this.checkBox_Pass12.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Pass12.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Pass12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkBox_Pass12.Location = new System.Drawing.Point(150, 281);
            this.checkBox_Pass12.Name = "checkBox_Pass12";
            this.checkBox_Pass12.Size = new System.Drawing.Size(126, 21);
            this.checkBox_Pass12.TabIndex = 15;
            this.checkBox_Pass12.Text = "Mostrar senha";
            this.checkBox_Pass12.UseVisualStyleBackColor = false;
            this.checkBox_Pass12.CheckedChanged += new System.EventHandler(this.checkBox_Pass12_CheckedChanged);
            // 
            // textBox_NewPass2
            // 
            this.textBox_NewPass2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPass2.Location = new System.Drawing.Point(36, 248);
            this.textBox_NewPass2.Name = "textBox_NewPass2";
            this.textBox_NewPass2.Size = new System.Drawing.Size(232, 27);
            this.textBox_NewPass2.TabIndex = 14;
            // 
            // textBox_NewPass1
            // 
            this.textBox_NewPass1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPass1.Location = new System.Drawing.Point(36, 210);
            this.textBox_NewPass1.Name = "textBox_NewPass1";
            this.textBox_NewPass1.Size = new System.Drawing.Size(232, 27);
            this.textBox_NewPass1.TabIndex = 13;
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
            // NewPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 516);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 555);
            this.MinimumSize = new System.Drawing.Size(320, 555);
            this.Name = "NewPassForm";
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
        private System.Windows.Forms.LinkLabel Link_Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Controls.Buttons btn_Atualizar;
        private System.Windows.Forms.CheckBox checkBox_Pass12;
        private System.Windows.Forms.TextBox textBox_NewPass2;
        private System.Windows.Forms.TextBox textBox_NewPass1;
        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.Label label_Info1;
        private System.Windows.Forms.Label label_Login;
    }
}