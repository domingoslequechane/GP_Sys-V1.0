
namespace GPSys_Desk.View
{
    partial class ConfirmedNewPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmedNewPassForm));
            this.label_Info2 = new System.Windows.Forms.Label();
            this.label_Info1 = new System.Windows.Forms.Label();
            this.Logo_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Error = new System.Windows.Forms.PictureBox();
            this.btn_Login = new GPSys_Desk.Controls.Buttons();
            this.label_RecuperarCodigo = new System.Windows.Forms.Label();
            this.Logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Info2
            // 
            this.label_Info2.AutoSize = true;
            this.label_Info2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info2.Location = new System.Drawing.Point(115, 267);
            this.label_Info2.Name = "label_Info2";
            this.label_Info2.Size = new System.Drawing.Size(73, 19);
            this.label_Info2.TabIndex = 28;
            this.label_Info2.Text = "Sucesso";
            // 
            // label_Info1
            // 
            this.label_Info1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Info1.AutoSize = true;
            this.label_Info1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Info1.Location = new System.Drawing.Point(56, 243);
            this.label_Info1.Name = "label_Info1";
            this.label_Info1.Size = new System.Drawing.Size(190, 19);
            this.label_Info1.TabIndex = 30;
            this.label_Info1.Text = "Senha recuperada com";
            this.label_Info1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo_panel
            // 
            this.Logo_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo_panel.Controls.Add(this.pictureBox1);
            this.Logo_panel.Controls.Add(this.pictureBox2);
            this.Logo_panel.Location = new System.Drawing.Point(70, 71);
            this.Logo_panel.Name = "Logo_panel";
            this.Logo_panel.Size = new System.Drawing.Size(162, 54);
            this.Logo_panel.TabIndex = 27;
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
            // pictureBox_Error
            // 
            this.pictureBox_Error.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Error.Image")));
            this.pictureBox_Error.Location = new System.Drawing.Point(116, 165);
            this.pictureBox_Error.Name = "pictureBox_Error";
            this.pictureBox_Error.Size = new System.Drawing.Size(71, 63);
            this.pictureBox_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Error.TabIndex = 32;
            this.pictureBox_Error.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btn_Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Login.BorderRadius = 10;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(29, 361);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(244, 61);
            this.btn_Login.TabIndex = 31;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label_RecuperarCodigo
            // 
            this.label_RecuperarCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_RecuperarCodigo.AutoSize = true;
            this.label_RecuperarCodigo.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_RecuperarCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_RecuperarCodigo.Location = new System.Drawing.Point(35, 31);
            this.label_RecuperarCodigo.Name = "label_RecuperarCodigo";
            this.label_RecuperarCodigo.Size = new System.Drawing.Size(232, 29);
            this.label_RecuperarCodigo.TabIndex = 26;
            this.label_RecuperarCodigo.Text = "Senha recuperada";
            // 
            // ConfirmedNewPass
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 496);
            this.Controls.Add(this.label_Info2);
            this.Controls.Add(this.label_Info1);
            this.Controls.Add(this.Logo_panel);
            this.Controls.Add(this.pictureBox_Error);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label_RecuperarCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 535);
            this.MinimumSize = new System.Drawing.Size(320, 535);
            this.Name = "ConfirmedNewPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GP System";
            this.Logo_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Info2;
        private System.Windows.Forms.Label label_Info1;
        private System.Windows.Forms.Panel Logo_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_Error;
        private Controls.Buttons btn_Login;
        private System.Windows.Forms.Label label_RecuperarCodigo;
    }
}