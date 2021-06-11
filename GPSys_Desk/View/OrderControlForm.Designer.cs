﻿
namespace GPSys_Desk.View
{
    partial class OrderControlForm
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderControlForm));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttons1 = new GPSys_Desk.Controls.Buttons();
            this.buttons2 = new GPSys_Desk.Controls.Buttons();
            this.buttons3 = new GPSys_Desk.Controls.Buttons();
            this.buttons4 = new GPSys_Desk.Controls.Buttons();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.btn_Search = new GPSys_Desk.Controls.Buttons();
            this.btn_Clear = new GPSys_Desk.Controls.Buttons();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(76, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Em andamento";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(76, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Concluido";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(0, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(920, 346);
            this.dataGridView1.TabIndex = 17;
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.Gray;
            this.buttons1.BackgroundColor = System.Drawing.Color.Gray;
            this.buttons1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttons1.BackgroundImage")));
            this.buttons1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttons1.BorderRadius = 10;
            this.buttons1.BorderSize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttons1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.ForeColor = System.Drawing.Color.White;
            this.buttons1.Location = new System.Drawing.Point(837, 58);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(35, 35);
            this.buttons1.TabIndex = 19;
            this.buttons1.TextColor = System.Drawing.Color.White;
            this.buttons1.UseVisualStyleBackColor = false;
            // 
            // buttons2
            // 
            this.buttons2.BackColor = System.Drawing.Color.Gray;
            this.buttons2.BackgroundColor = System.Drawing.Color.Gray;
            this.buttons2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttons2.BackgroundImage")));
            this.buttons2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttons2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttons2.BorderRadius = 10;
            this.buttons2.BorderSize = 0;
            this.buttons2.FlatAppearance.BorderSize = 0;
            this.buttons2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttons2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.buttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons2.ForeColor = System.Drawing.Color.White;
            this.buttons2.Location = new System.Drawing.Point(885, 58);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(35, 35);
            this.buttons2.TabIndex = 18;
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            // 
            // buttons3
            // 
            this.buttons3.BackColor = System.Drawing.Color.Gray;
            this.buttons3.BackgroundColor = System.Drawing.Color.Gray;
            this.buttons3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttons3.BackgroundImage")));
            this.buttons3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttons3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttons3.BorderRadius = 10;
            this.buttons3.BorderSize = 0;
            this.buttons3.FlatAppearance.BorderSize = 0;
            this.buttons3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttons3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.buttons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons3.ForeColor = System.Drawing.Color.White;
            this.buttons3.Location = new System.Drawing.Point(741, 58);
            this.buttons3.Name = "buttons3";
            this.buttons3.Size = new System.Drawing.Size(35, 35);
            this.buttons3.TabIndex = 19;
            this.buttons3.TextColor = System.Drawing.Color.White;
            this.buttons3.UseVisualStyleBackColor = false;
            // 
            // buttons4
            // 
            this.buttons4.BackColor = System.Drawing.Color.Gray;
            this.buttons4.BackgroundColor = System.Drawing.Color.Gray;
            this.buttons4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttons4.BackgroundImage")));
            this.buttons4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttons4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttons4.BorderRadius = 10;
            this.buttons4.BorderSize = 0;
            this.buttons4.FlatAppearance.BorderSize = 0;
            this.buttons4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttons4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.buttons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons4.ForeColor = System.Drawing.Color.White;
            this.buttons4.Location = new System.Drawing.Point(789, 58);
            this.buttons4.Name = "buttons4";
            this.buttons4.Size = new System.Drawing.Size(35, 35);
            this.buttons4.TabIndex = 18;
            this.buttons4.TextColor = System.Drawing.Color.White;
            this.buttons4.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Location = new System.Drawing.Point(659, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(176, 37);
            this.panel8.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "Órdens",
            "Clientes"});
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Gotham", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Órdens",
            "Clientes"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 31);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Ordenar por";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBox_Category);
            this.panel6.Controls.Add(this.btn_Search);
            this.panel6.Controls.Add(this.btn_Clear);
            this.panel6.Controls.Add(this.textBox_Search);
            this.panel6.Location = new System.Drawing.Point(86, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(524, 37);
            this.panel6.TabIndex = 31;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "Órdens",
            "Clientes"});
            this.comboBox_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Category.Font = new System.Drawing.Font("Gotham", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {
            "Todos",
            "Órdens",
            "Clientes"});
            this.comboBox_Category.Location = new System.Drawing.Point(3, 4);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(107, 31);
            this.comboBox_Category.TabIndex = 5;
            this.comboBox_Category.Text = "Todos";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderRadius = 0;
            this.btn_Search.BorderSize = 0;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(490, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(30, 30);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.TextColor = System.Drawing.Color.White;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.BackgroundColor = System.Drawing.Color.White;
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Clear.BorderRadius = 0;
            this.btn_Clear.BorderSize = 0;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(465, 10);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(18, 18);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.TextColor = System.Drawing.Color.White;
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Gotham", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Search.Location = new System.Drawing.Point(111, 4);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PlaceholderText = "Buscar por...";
            this.textBox_Search.Size = new System.Drawing.Size(378, 30);
            this.textBox_Search.TabIndex = 11;
            // 
            // OrderControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.buttons2);
            this.Controls.Add(this.buttons4);
            this.Controls.Add(this.buttons1);
            this.Controls.Add(this.buttons3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "OrderControlForm";
            this.Size = new System.Drawing.Size(920, 456);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controls.Buttons buttons1;
        private Controls.Buttons buttons2;
        private Controls.Buttons buttons3;
        private Controls.Buttons buttons4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private Controls.Buttons btn_Search;
        private Controls.Buttons btn_Clear;
        private System.Windows.Forms.TextBox textBox_Search;
    }
}