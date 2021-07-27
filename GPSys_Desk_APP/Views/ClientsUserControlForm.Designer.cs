
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
            this.Tb_ID = new GPSys_Desk_APP.Controls.OnlyInt();
            this.Btn_DeleteClient = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_EditClient = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_SearchClear = new GPSys_Desk_APP.Controls.Buttons();
            this.Cb_DataOrder = new System.Windows.Forms.ComboBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Tb_ID);
            this.panel1.Controls.Add(this.Btn_DeleteClient);
            this.panel1.Controls.Add(this.Btn_EditClient);
            this.panel1.Controls.Add(this.Btn_SearchClear);
            this.panel1.Controls.Add(this.Cb_DataOrder);
            this.panel1.Controls.Add(this.DataGridView);
            this.panel1.Controls.Add(this.Tb_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 618);
            this.panel1.TabIndex = 1;
            // 
            // Tb_ID
            // 
            this.Tb_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_ID.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ID.Location = new System.Drawing.Point(868, 25);
            this.Tb_ID.Name = "Tb_ID";
            this.Tb_ID.Size = new System.Drawing.Size(63, 28);
            this.Tb_ID.TabIndex = 4;
            this.Tb_ID.Text = "ID";
            this.Tb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_DeleteClient
            // 
            this.Btn_DeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_DeleteClient.AutoSize = true;
            this.Btn_DeleteClient.BackColor = System.Drawing.Color.Gray;
            this.Btn_DeleteClient.BackgroundColor = System.Drawing.Color.Gray;
            this.Btn_DeleteClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_DeleteClient.BackgroundImage")));
            this.Btn_DeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_DeleteClient.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_DeleteClient.BorderRadius = 7;
            this.Btn_DeleteClient.BorderSize = 0;
            this.Btn_DeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DeleteClient.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_DeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_DeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteClient.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteClient.Location = new System.Drawing.Point(941, 21);
            this.Btn_DeleteClient.Name = "Btn_DeleteClient";
            this.Btn_DeleteClient.Size = new System.Drawing.Size(37, 37);
            this.Btn_DeleteClient.TabIndex = 5;
            this.Btn_DeleteClient.TextColor = System.Drawing.Color.White;
            this.Btn_DeleteClient.UseVisualStyleBackColor = false;
            // 
            // Btn_EditClient
            // 
            this.Btn_EditClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_EditClient.AutoSize = true;
            this.Btn_EditClient.BackColor = System.Drawing.Color.Gray;
            this.Btn_EditClient.BackgroundColor = System.Drawing.Color.Gray;
            this.Btn_EditClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_EditClient.BackgroundImage")));
            this.Btn_EditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EditClient.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_EditClient.BorderRadius = 7;
            this.Btn_EditClient.BorderSize = 0;
            this.Btn_EditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EditClient.FlatAppearance.BorderSize = 0;
            this.Btn_EditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_EditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_EditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditClient.ForeColor = System.Drawing.Color.White;
            this.Btn_EditClient.Location = new System.Drawing.Point(1013, 21);
            this.Btn_EditClient.Name = "Btn_EditClient";
            this.Btn_EditClient.Size = new System.Drawing.Size(37, 37);
            this.Btn_EditClient.TabIndex = 6;
            this.Btn_EditClient.TabStop = false;
            this.Btn_EditClient.TextColor = System.Drawing.Color.White;
            this.Btn_EditClient.UseVisualStyleBackColor = false;
            this.Btn_EditClient.Click += new System.EventHandler(this.Btn_EditClient_Click);
            // 
            // Btn_SearchClear
            // 
            this.Btn_SearchClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_SearchClear.BackColor = System.Drawing.Color.White;
            this.Btn_SearchClear.BackgroundColor = System.Drawing.Color.White;
            this.Btn_SearchClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_SearchClear.BackgroundImage")));
            this.Btn_SearchClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_SearchClear.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_SearchClear.BorderRadius = 0;
            this.Btn_SearchClear.BorderSize = 0;
            this.Btn_SearchClear.FlatAppearance.BorderSize = 0;
            this.Btn_SearchClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_SearchClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_SearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SearchClear.ForeColor = System.Drawing.Color.White;
            this.Btn_SearchClear.Location = new System.Drawing.Point(313, 29);
            this.Btn_SearchClear.Name = "Btn_SearchClear";
            this.Btn_SearchClear.Size = new System.Drawing.Size(18, 18);
            this.Btn_SearchClear.TabIndex = 2;
            this.Btn_SearchClear.TabStop = false;
            this.Btn_SearchClear.TextColor = System.Drawing.Color.White;
            this.Btn_SearchClear.UseVisualStyleBackColor = false;
            this.Btn_SearchClear.Click += new System.EventHandler(this.Btn_SearchClear_Click);
            // 
            // Cb_DataOrder
            // 
            this.Cb_DataOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_DataOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cb_DataOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cb_DataOrder.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_DataOrder.FormattingEnabled = true;
            this.Cb_DataOrder.Items.AddRange(new object[] {
            "Aguardando",
            "Em andamento",
            "Em pausa",
            "Concluidos"});
            this.Cb_DataOrder.Location = new System.Drawing.Point(423, 25);
            this.Cb_DataOrder.Name = "Cb_DataOrder";
            this.Cb_DataOrder.Size = new System.Drawing.Size(175, 28);
            this.Cb_DataOrder.TabIndex = 3;
            this.Cb_DataOrder.TabStop = false;
            this.Cb_DataOrder.Text = "Ordenar por";
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
            // Tb_Search
            // 
            this.Tb_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_Search.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Search.Location = new System.Drawing.Point(8, 25);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(329, 28);
            this.Tb_Search.TabIndex = 1;
            this.Tb_Search.Text = "Buscar cliente...";
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
        private Controls.Buttons Btn_EditClient;
        private Controls.Buttons Btn_SearchClear;
        private System.Windows.Forms.ComboBox Cb_DataOrder;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox Tb_Search;
        private Controls.OnlyInt Tb_ID;
        private Controls.Buttons Btn_DeleteClient;
    }
}
