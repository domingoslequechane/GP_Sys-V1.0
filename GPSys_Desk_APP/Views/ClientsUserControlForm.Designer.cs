
namespace GPSys_Desk_APP.Views
{
    partial class ClientsUserControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsUserControlForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new GPSys_Desk_APP.Controls.OnlyInt();
            this.Delete_btn = new GPSys_Desk_APP.Controls.Buttons();
            this.Edit_btn = new GPSys_Desk_APP.Controls.Buttons();
            this.Clear_btn = new GPSys_Desk_APP.Controls.Buttons();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.TextBox_Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.Edit_btn);
            this.panel1.Controls.Add(this.Clear_btn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.DataGridView);
            this.panel1.Controls.Add(this.TextBox_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 618);
            this.panel1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(868, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(63, 28);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
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
            this.Delete_btn.Location = new System.Drawing.Point(941, 21);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(37, 37);
            this.Delete_btn.TabIndex = 8;
            this.Delete_btn.TextColor = System.Drawing.Color.White;
            this.Delete_btn.UseVisualStyleBackColor = false;
            // 
            // Edit_btn
            // 
            this.Edit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit_btn.AutoSize = true;
            this.Edit_btn.BackColor = System.Drawing.Color.Gray;
            this.Edit_btn.BackgroundColor = System.Drawing.Color.Gray;
            this.Edit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_btn.BackgroundImage")));
            this.Edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit_btn.BorderColor = System.Drawing.Color.Transparent;
            this.Edit_btn.BorderRadius = 7;
            this.Edit_btn.BorderSize = 0;
            this.Edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Edit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn.ForeColor = System.Drawing.Color.White;
            this.Edit_btn.Location = new System.Drawing.Point(1013, 21);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(37, 37);
            this.Edit_btn.TabIndex = 5;
            this.Edit_btn.TabStop = false;
            this.Edit_btn.TextColor = System.Drawing.Color.White;
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
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
            this.Clear_btn.Location = new System.Drawing.Point(313, 29);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(18, 18);
            this.Clear_btn.TabIndex = 4;
            this.Clear_btn.TabStop = false;
            this.Clear_btn.TextColor = System.Drawing.Color.White;
            this.Clear_btn.UseVisualStyleBackColor = false;
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
            this.comboBox1.Location = new System.Drawing.Point(423, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "Ordenar por";
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
            // TextBox_Search
            // 
            this.TextBox_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Search.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Search.Location = new System.Drawing.Point(8, 25);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(329, 28);
            this.TextBox_Search.TabIndex = 6;
            this.TextBox_Search.Text = "Buscar cliente...";
            this.TextBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // ClientsUserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ClientsUserControlForm";
            this.Size = new System.Drawing.Size(1058, 618);
            this.Load += new System.EventHandler(this.ClientsUserControlForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Controls.Buttons Edit_btn;
        private Controls.Buttons Clear_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox TextBox_Search;
        private Controls.OnlyInt ID;
        private Controls.Buttons Delete_btn;
    }
}
