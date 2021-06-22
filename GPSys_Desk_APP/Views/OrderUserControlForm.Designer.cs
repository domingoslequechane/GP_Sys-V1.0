
namespace GPSys_Desk_APP.Views
{
    partial class OrderUserControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUserControlForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBox_OrdenarPor = new System.Windows.Forms.ComboBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Export_btn = new GPSys_Desk_APP.Controls.Buttons();
            this.Delete_btn = new GPSys_Desk_APP.Controls.Buttons();
            this.Clear_btn = new GPSys_Desk_APP.Controls.Buttons();
            this.TextBox_Search = new GPSys_Desk_APP.Controls.OnlyInt();
            this.ID = new GPSys_Desk_APP.Controls.OnlyInt();
            this.buttons1 = new GPSys_Desk_APP.Controls.Buttons();
            this.buttons2 = new GPSys_Desk_APP.Controls.Buttons();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Export_btn);
            this.panel1.Controls.Add(this.buttons1);
            this.panel1.Controls.Add(this.Clear_btn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.ComboBox_OrdenarPor);
            this.panel1.Controls.Add(this.DataGridView);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.TextBox_Search);
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.buttons2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 618);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aguardando",
            "Em andamento",
            "Em pausa",
            "Concluidos"});
            this.comboBox1.Location = new System.Drawing.Point(363, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "Ordenar por";
            // 
            // ComboBox_OrdenarPor
            // 
            this.ComboBox_OrdenarPor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_OrdenarPor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox_OrdenarPor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_OrdenarPor.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_OrdenarPor.FormattingEnabled = true;
            this.ComboBox_OrdenarPor.Items.AddRange(new object[] {
            "Aguardando",
            "Em andamento",
            "Em pausa",
            "Concluido"});
            this.ComboBox_OrdenarPor.Location = new System.Drawing.Point(561, 25);
            this.ComboBox_OrdenarPor.Name = "ComboBox_OrdenarPor";
            this.ComboBox_OrdenarPor.Size = new System.Drawing.Size(175, 28);
            this.ComboBox_OrdenarPor.TabIndex = 1;
            this.ComboBox_OrdenarPor.TabStop = false;
            this.ComboBox_OrdenarPor.Text = "Definir estado";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(8, 83);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(1042, 528);
            this.DataGridView.TabIndex = 0;
            // 
            // Export_btn
            // 
            this.Export_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Export_btn.AutoSize = true;
            this.Export_btn.BackColor = System.Drawing.Color.Gray;
            this.Export_btn.BackgroundColor = System.Drawing.Color.Gray;
            this.Export_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export_btn.BackgroundImage")));
            this.Export_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Export_btn.BorderColor = System.Drawing.Color.Transparent;
            this.Export_btn.BorderRadius = 7;
            this.Export_btn.BorderSize = 0;
            this.Export_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Export_btn.FlatAppearance.BorderSize = 0;
            this.Export_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Export_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_btn.ForeColor = System.Drawing.Color.White;
            this.Export_btn.Location = new System.Drawing.Point(1013, 21);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(37, 37);
            this.Export_btn.TabIndex = 5;
            this.Export_btn.TextColor = System.Drawing.Color.White;
            this.Export_btn.UseVisualStyleBackColor = false;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete_btn.AutoSize = true;
            this.Delete_btn.BackColor = System.Drawing.Color.Gray;
            this.Delete_btn.BackgroundColor = System.Drawing.Color.Gray;
            this.Delete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_btn.BackgroundImage")));
            this.Delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_btn.BorderColor = System.Drawing.Color.Transparent;
            this.Delete_btn.BorderRadius = 7;
            this.Delete_btn.BorderSize = 0;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(849, 21);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(37, 37);
            this.Delete_btn.TabIndex = 5;
            this.Delete_btn.TextColor = System.Drawing.Color.White;
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_btn.BackColor = System.Drawing.Color.White;
            this.Clear_btn.BackgroundColor = System.Drawing.Color.White;
            this.Clear_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear_btn.BackgroundImage")));
            this.Clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear_btn.BorderColor = System.Drawing.Color.Transparent;
            this.Clear_btn.BorderRadius = 0;
            this.Clear_btn.BorderSize = 0;
            this.Clear_btn.FlatAppearance.BorderSize = 0;
            this.Clear_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.Location = new System.Drawing.Point(313, 30);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(18, 18);
            this.Clear_btn.TabIndex = 4;
            this.Clear_btn.TabStop = false;
            this.Clear_btn.TextColor = System.Drawing.Color.White;
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Search.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Search.Location = new System.Drawing.Point(8, 25);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(329, 28);
            this.TextBox_Search.TabIndex = 7;
            this.TextBox_Search.Text = "Buscar ordem...";
            this.TextBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(776, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(63, 28);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            this.ID.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // buttons1
            // 
            this.buttons1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttons1.AutoSize = true;
            this.buttons1.BackColor = System.Drawing.Color.Gray;
            this.buttons1.BackgroundColor = System.Drawing.Color.Gray;
            this.buttons1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttons1.BackgroundImage")));
            this.buttons1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttons1.BorderColor = System.Drawing.Color.Transparent;
            this.buttons1.BorderRadius = 7;
            this.buttons1.BorderSize = 0;
            this.buttons1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttons1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.ForeColor = System.Drawing.Color.White;
            this.buttons1.Location = new System.Drawing.Point(921, 21);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(37, 37);
            this.buttons1.TabIndex = 5;
            this.buttons1.TextColor = System.Drawing.Color.White;
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.AddOrder_btn_Click);
            // 
            // buttons2
            // 
            this.buttons2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttons2.AutoSize = true;
            this.buttons2.BackColor = System.Drawing.Color.Gray;
            this.buttons2.BackgroundColor = System.Drawing.Color.Gray;
            this.buttons2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttons2.BackgroundImage")));
            this.buttons2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttons2.BorderColor = System.Drawing.Color.Transparent;
            this.buttons2.BorderRadius = 7;
            this.buttons2.BorderSize = 0;
            this.buttons2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttons2.FlatAppearance.BorderSize = 0;
            this.buttons2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttons2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.buttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons2.ForeColor = System.Drawing.Color.White;
            this.buttons2.Location = new System.Drawing.Point(967, 21);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(37, 37);
            this.buttons2.TabIndex = 5;
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // OrderUserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "OrderUserControlForm";
            this.Size = new System.Drawing.Size(1058, 618);
            this.Load += new System.EventHandler(this.OrderUserControlForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView;
        private Controls.Buttons Clear_btn;
        private System.Windows.Forms.ComboBox ComboBox_OrdenarPor;
        private Controls.Buttons Export_btn;
        private Controls.Buttons Delete_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private Controls.OnlyInt TextBox_Search;
        private Controls.OnlyInt ID;
        private Controls.Buttons buttons1;
        private Controls.Buttons buttons2;
    }
}
