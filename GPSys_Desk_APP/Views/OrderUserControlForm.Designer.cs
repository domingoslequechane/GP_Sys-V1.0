
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
            this.Btn_ExportOrder = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_NewOrder = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_ClearSearchCamp = new GPSys_Desk_APP.Controls.Buttons();
            this.Cb_OrderBy = new System.Windows.Forms.ComboBox();
            this.Cb_SetOrderState = new System.Windows.Forms.ComboBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Tb_OrderIDNumber = new GPSys_Desk_APP.Controls.OnlyInt();
            this.Btn_DeleteOrder = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_EditOrder = new GPSys_Desk_APP.Controls.Buttons();
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Btn_ExportOrder);
            this.panel1.Controls.Add(this.Btn_NewOrder);
            this.panel1.Controls.Add(this.Btn_ClearSearchCamp);
            this.panel1.Controls.Add(this.Cb_OrderBy);
            this.panel1.Controls.Add(this.Cb_SetOrderState);
            this.panel1.Controls.Add(this.DataGridView);
            this.panel1.Controls.Add(this.Tb_OrderIDNumber);
            this.panel1.Controls.Add(this.Btn_DeleteOrder);
            this.panel1.Controls.Add(this.Btn_EditOrder);
            this.panel1.Controls.Add(this.Tb_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 618);
            this.panel1.TabIndex = 0;
            // 
            // Btn_ExportOrder
            // 
            this.Btn_ExportOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ExportOrder.AutoSize = true;
            this.Btn_ExportOrder.BackColor = System.Drawing.Color.Gray;
            this.Btn_ExportOrder.BackgroundColor = System.Drawing.Color.Gray;
            this.Btn_ExportOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ExportOrder.BackgroundImage")));
            this.Btn_ExportOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ExportOrder.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_ExportOrder.BorderRadius = 7;
            this.Btn_ExportOrder.BorderSize = 0;
            this.Btn_ExportOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExportOrder.FlatAppearance.BorderSize = 0;
            this.Btn_ExportOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_ExportOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_ExportOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ExportOrder.ForeColor = System.Drawing.Color.White;
            this.Btn_ExportOrder.Location = new System.Drawing.Point(1013, 21);
            this.Btn_ExportOrder.Name = "Btn_ExportOrder";
            this.Btn_ExportOrder.Size = new System.Drawing.Size(37, 37);
            this.Btn_ExportOrder.TabIndex = 5;
            this.Btn_ExportOrder.TextColor = System.Drawing.Color.White;
            this.Btn_ExportOrder.UseVisualStyleBackColor = false;
            // 
            // Btn_NewOrder
            // 
            this.Btn_NewOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_NewOrder.AutoSize = true;
            this.Btn_NewOrder.BackColor = System.Drawing.Color.Gray;
            this.Btn_NewOrder.BackgroundColor = System.Drawing.Color.Gray;
            this.Btn_NewOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_NewOrder.BackgroundImage")));
            this.Btn_NewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_NewOrder.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_NewOrder.BorderRadius = 7;
            this.Btn_NewOrder.BorderSize = 0;
            this.Btn_NewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NewOrder.FlatAppearance.BorderSize = 0;
            this.Btn_NewOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_NewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_NewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NewOrder.ForeColor = System.Drawing.Color.White;
            this.Btn_NewOrder.Location = new System.Drawing.Point(921, 21);
            this.Btn_NewOrder.Name = "Btn_NewOrder";
            this.Btn_NewOrder.Size = new System.Drawing.Size(37, 37);
            this.Btn_NewOrder.TabIndex = 5;
            this.Btn_NewOrder.TextColor = System.Drawing.Color.White;
            this.Btn_NewOrder.UseVisualStyleBackColor = false;
            this.Btn_NewOrder.Click += new System.EventHandler(this.Btn_NewOrder_Click);
            // 
            // Btn_ClearSearchCamp
            // 
            this.Btn_ClearSearchCamp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ClearSearchCamp.BackColor = System.Drawing.Color.White;
            this.Btn_ClearSearchCamp.BackgroundColor = System.Drawing.Color.White;
            this.Btn_ClearSearchCamp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ClearSearchCamp.BackgroundImage")));
            this.Btn_ClearSearchCamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ClearSearchCamp.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_ClearSearchCamp.BorderRadius = 0;
            this.Btn_ClearSearchCamp.BorderSize = 0;
            this.Btn_ClearSearchCamp.FlatAppearance.BorderSize = 0;
            this.Btn_ClearSearchCamp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_ClearSearchCamp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_ClearSearchCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ClearSearchCamp.ForeColor = System.Drawing.Color.White;
            this.Btn_ClearSearchCamp.Location = new System.Drawing.Point(313, 30);
            this.Btn_ClearSearchCamp.Name = "Btn_ClearSearchCamp";
            this.Btn_ClearSearchCamp.Size = new System.Drawing.Size(18, 18);
            this.Btn_ClearSearchCamp.TabIndex = 4;
            this.Btn_ClearSearchCamp.TabStop = false;
            this.Btn_ClearSearchCamp.TextColor = System.Drawing.Color.White;
            this.Btn_ClearSearchCamp.UseVisualStyleBackColor = false;
            this.Btn_ClearSearchCamp.Click += new System.EventHandler(this.Btn_ClearSearchCamp_Click);
            // 
            // Cb_OrderBy
            // 
            this.Cb_OrderBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_OrderBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cb_OrderBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cb_OrderBy.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_OrderBy.FormattingEnabled = true;
            this.Cb_OrderBy.Items.AddRange(new object[] {
            "Aguardando",
            "Em andamento",
            "Em pausa",
            "Concluidos"});
            this.Cb_OrderBy.Location = new System.Drawing.Point(363, 25);
            this.Cb_OrderBy.Name = "Cb_OrderBy";
            this.Cb_OrderBy.Size = new System.Drawing.Size(175, 28);
            this.Cb_OrderBy.TabIndex = 1;
            this.Cb_OrderBy.TabStop = false;
            this.Cb_OrderBy.Text = "Ordenar por";
            // 
            // Cb_SetOrderState
            // 
            this.Cb_SetOrderState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_SetOrderState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cb_SetOrderState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cb_SetOrderState.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_SetOrderState.FormattingEnabled = true;
            this.Cb_SetOrderState.Items.AddRange(new object[] {
            "Aguardando",
            "Em andamento",
            "Em pausa",
            "Concluido"});
            this.Cb_SetOrderState.Location = new System.Drawing.Point(561, 25);
            this.Cb_SetOrderState.Name = "Cb_SetOrderState";
            this.Cb_SetOrderState.Size = new System.Drawing.Size(175, 28);
            this.Cb_SetOrderState.TabIndex = 1;
            this.Cb_SetOrderState.TabStop = false;
            this.Cb_SetOrderState.Text = "Definir estado";
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
            // Tb_OrderIDNumber
            // 
            this.Tb_OrderIDNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_OrderIDNumber.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_OrderIDNumber.Location = new System.Drawing.Point(776, 25);
            this.Tb_OrderIDNumber.Name = "Tb_OrderIDNumber";
            this.Tb_OrderIDNumber.Size = new System.Drawing.Size(63, 28);
            this.Tb_OrderIDNumber.TabIndex = 7;
            this.Tb_OrderIDNumber.Text = "ID";
            this.Tb_OrderIDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_DeleteOrder
            // 
            this.Btn_DeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_DeleteOrder.AutoSize = true;
            this.Btn_DeleteOrder.BackColor = System.Drawing.Color.Gray;
            this.Btn_DeleteOrder.BackgroundColor = System.Drawing.Color.Gray;
            this.Btn_DeleteOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_DeleteOrder.BackgroundImage")));
            this.Btn_DeleteOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_DeleteOrder.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_DeleteOrder.BorderRadius = 7;
            this.Btn_DeleteOrder.BorderSize = 0;
            this.Btn_DeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DeleteOrder.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_DeleteOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_DeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteOrder.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteOrder.Location = new System.Drawing.Point(849, 21);
            this.Btn_DeleteOrder.Name = "Btn_DeleteOrder";
            this.Btn_DeleteOrder.Size = new System.Drawing.Size(37, 37);
            this.Btn_DeleteOrder.TabIndex = 5;
            this.Btn_DeleteOrder.TextColor = System.Drawing.Color.White;
            this.Btn_DeleteOrder.UseVisualStyleBackColor = false;
            // 
            // Btn_EditOrder
            // 
            this.Btn_EditOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_EditOrder.AutoSize = true;
            this.Btn_EditOrder.BackColor = System.Drawing.Color.Gray;
            this.Btn_EditOrder.BackgroundColor = System.Drawing.Color.Gray;
            this.Btn_EditOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_EditOrder.BackgroundImage")));
            this.Btn_EditOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EditOrder.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_EditOrder.BorderRadius = 7;
            this.Btn_EditOrder.BorderSize = 0;
            this.Btn_EditOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EditOrder.FlatAppearance.BorderSize = 0;
            this.Btn_EditOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_EditOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_EditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditOrder.ForeColor = System.Drawing.Color.White;
            this.Btn_EditOrder.Location = new System.Drawing.Point(967, 21);
            this.Btn_EditOrder.Name = "Btn_EditOrder";
            this.Btn_EditOrder.Size = new System.Drawing.Size(37, 37);
            this.Btn_EditOrder.TabIndex = 5;
            this.Btn_EditOrder.TextColor = System.Drawing.Color.White;
            this.Btn_EditOrder.UseVisualStyleBackColor = false;
            this.Btn_EditOrder.Click += new System.EventHandler(this.Btn_EditOrder_Click);
            // 
            // Tb_Search
            // 
            this.Tb_Search.Font = new System.Drawing.Font("Gotham", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Search.Location = new System.Drawing.Point(8, 25);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(329, 28);
            this.Tb_Search.TabIndex = 7;
            this.Tb_Search.Text = "Buscar..";
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
        private Controls.Buttons Btn_ClearSearchCamp;
        private System.Windows.Forms.ComboBox Cb_SetOrderState;
        private Controls.Buttons Btn_ExportOrder;
        private Controls.Buttons Btn_DeleteOrder;
        private System.Windows.Forms.ComboBox Cb_OrderBy;
        private Controls.OnlyInt Tb_OrderIDNumber;
        private Controls.Buttons Btn_NewOrder;
        private Controls.Buttons Btn_EditOrder;
        private System.Windows.Forms.TextBox Tb_Search;
    }
}
