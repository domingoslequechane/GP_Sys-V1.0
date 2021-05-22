
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.buttons1 = new GPSys_Desk.Controls.Buttons();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Show_Pass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(71, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 54);
            this.panel1.TabIndex = 1;
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
            this.pictureBox2.Location = new System.Drawing.Point(111, 2);
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
            this.textBox_User.Location = new System.Drawing.Point(30, 205);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.PlaceholderText = "Usuário";
            this.textBox_User.Size = new System.Drawing.Size(244, 27);
            this.textBox_User.TabIndex = 1;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_Pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox_Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Pass.Location = new System.Drawing.Point(30, 245);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.PasswordChar = '*';
            this.textBox_Pass.PlaceholderText = "Senha";
            this.textBox_Pass.Size = new System.Drawing.Size(244, 29);
            this.textBox_Pass.TabIndex = 2;
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.buttons1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.buttons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttons1.BorderRadius = 10;
            this.buttons1.BorderSize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttons1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttons1.ForeColor = System.Drawing.Color.White;
            this.buttons1.Location = new System.Drawing.Point(30, 341);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(244, 54);
            this.buttons1.TabIndex = 4;
            this.buttons1.Text = "Entrar";
            this.buttons1.TextColor = System.Drawing.Color.White;
            this.buttons1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Gotham Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.linkLabel1.Location = new System.Drawing.Point(61, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueci-me da senha!";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parra logar, digite o seu nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "de Usuário e Senha!";
            // 
            // checkBox_Show_Pass
            // 
            this.checkBox_Show_Pass.AutoSize = true;
            this.checkBox_Show_Pass.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Show_Pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox_Show_Pass.Location = new System.Drawing.Point(158, 279);
            this.checkBox_Show_Pass.Name = "checkBox_Show_Pass";
            this.checkBox_Show_Pass.Size = new System.Drawing.Size(116, 20);
            this.checkBox_Show_Pass.TabIndex = 3;
            this.checkBox_Show_Pass.Text = "Mostrar senha";
            this.checkBox_Show_Pass.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 496);
            this.Controls.Add(this.checkBox_Show_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttons1);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 535);
            this.MinimumSize = new System.Drawing.Size(320, 535);
            this.Name = "LoginForm";
            this.Text = "GP_Sys";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Pass;
        private Controls.Buttons buttons1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Show_Pass;
    }
}

