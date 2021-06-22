
namespace GPSys_Desk_APP
{
    partial class ProgressiveForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressiveForm));
            this.pictureBox_GP = new System.Windows.Forms.PictureBox();
            this.label_GPS = new System.Windows.Forms.Label();
            this.label_Wellcome = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress_Panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_GP
            // 
            this.pictureBox_GP.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_GP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_GP.Image")));
            this.pictureBox_GP.Location = new System.Drawing.Point(47, 52);
            this.pictureBox_GP.Name = "pictureBox_GP";
            this.pictureBox_GP.Size = new System.Drawing.Size(289, 87);
            this.pictureBox_GP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_GP.TabIndex = 0;
            this.pictureBox_GP.TabStop = false;
            this.pictureBox_GP.UseWaitCursor = true;
            // 
            // label_GPS
            // 
            this.label_GPS.AutoSize = true;
            this.label_GPS.BackColor = System.Drawing.Color.Transparent;
            this.label_GPS.Font = new System.Drawing.Font("Gotham", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.label_GPS.Location = new System.Drawing.Point(36, 141);
            this.label_GPS.Name = "label_GPS";
            this.label_GPS.Size = new System.Drawing.Size(257, 52);
            this.label_GPS.TabIndex = 1;
            this.label_GPS.Text = "GP System";
            this.label_GPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_GPS.UseWaitCursor = true;
            // 
            // label_Wellcome
            // 
            this.label_Wellcome.AutoSize = true;
            this.label_Wellcome.BackColor = System.Drawing.Color.Transparent;
            this.label_Wellcome.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Wellcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_Wellcome.Location = new System.Drawing.Point(40, 198);
            this.label_Wellcome.Name = "label_Wellcome";
            this.label_Wellcome.Size = new System.Drawing.Size(146, 29);
            this.label_Wellcome.TabIndex = 2;
            this.label_Wellcome.Text = "Bem-vindo";
            this.label_Wellcome.UseWaitCursor = true;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.BackColor = System.Drawing.Color.Transparent;
            this.label_Status.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_Status.Location = new System.Drawing.Point(43, 281);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(136, 19);
            this.label_Status.TabIndex = 3;
            this.label_Status.Text = "A carregar...0%";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Status.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(44, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aguarde, estamos a preparar";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gotham", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(44, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "tudo para si!";
            this.label2.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.progress_Panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 20);
            this.panel1.TabIndex = 6;
            this.panel1.UseWaitCursor = true;
            // 
            // progress_Panel
            // 
            this.progress_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.progress_Panel.Location = new System.Drawing.Point(0, 0);
            this.progress_Panel.Name = "progress_Panel";
            this.progress_Panel.Size = new System.Drawing.Size(0, 20);
            this.progress_Panel.TabIndex = 7;
            this.progress_Panel.UseWaitCursor = true;
            this.progress_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.progress_Panel_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // processBar
            // 
            this.processBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.processBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.processBar.Location = new System.Drawing.Point(45, 12);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(277, 23);
            this.processBar.TabIndex = 4;
            this.processBar.UseWaitCursor = true;
            this.processBar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gotham", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 52);
            this.label3.TabIndex = 1;
            this.label3.Text = "1.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(591, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 124);
            this.panel2.TabIndex = 7;
            this.panel2.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Location = new System.Drawing.Point(0, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 15);
            this.panel3.TabIndex = 2;
            this.panel3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gotham", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ver.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseWaitCursor = true;
            // 
            // ProgressiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(674, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processBar);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Wellcome);
            this.Controls.Add(this.label_GPS);
            this.Controls.Add(this.pictureBox_GP);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgressiveForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregando";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.ProgressiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_GP;
        private System.Windows.Forms.Label label_GPS;
        private System.Windows.Forms.Label label_Wellcome;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel progress_Panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar processBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}

