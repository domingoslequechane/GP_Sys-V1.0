
namespace GPSys_Desk_APP.Views
{
    partial class ServiceUserControlForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceUserControlForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Btn_DeleteService = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_AddSaveService = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_UpdateService = new GPSys_Desk_APP.Controls.Buttons();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ClearCamps = new GPSys_Desk_APP.Controls.Buttons();
            this.Tb_ServicePrice = new GPSys_Desk_APP.Controls.OnlyInt();
            this.Tb_ServiceCode = new System.Windows.Forms.MaskedTextBox();
            this.Tb_ServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_ServiceDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Btn_DeleteService);
            this.panel1.Controls.Add(this.Btn_UpdateService);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 696);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 280);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Serviços";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeight = 30;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.GridColor = System.Drawing.Color.White;
            this.DataGridView.Location = new System.Drawing.Point(32, 53);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(810, 199);
            this.DataGridView.TabIndex = 75;
            // 
            // Btn_DeleteService
            // 
            this.Btn_DeleteService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_DeleteService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_DeleteService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_DeleteService.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_DeleteService.BorderRadius = 10;
            this.Btn_DeleteService.BorderSize = 0;
            this.Btn_DeleteService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DeleteService.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_DeleteService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_DeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteService.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteService.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteService.Location = new System.Drawing.Point(956, 437);
            this.Btn_DeleteService.Name = "Btn_DeleteService";
            this.Btn_DeleteService.Size = new System.Drawing.Size(104, 37);
            this.Btn_DeleteService.TabIndex = 8;
            this.Btn_DeleteService.Text = "Excluir";
            this.Btn_DeleteService.TextColor = System.Drawing.Color.White;
            this.Btn_DeleteService.UseVisualStyleBackColor = false;
            this.Btn_DeleteService.Click += new System.EventHandler(this.Btn_DeleteService_Click);
            // 
            // Btn_AddSaveService
            // 
            this.Btn_AddSaveService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_AddSaveService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_AddSaveService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_AddSaveService.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_AddSaveService.BorderRadius = 10;
            this.Btn_AddSaveService.BorderSize = 0;
            this.Btn_AddSaveService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddSaveService.FlatAppearance.BorderSize = 0;
            this.Btn_AddSaveService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_AddSaveService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_AddSaveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddSaveService.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddSaveService.ForeColor = System.Drawing.Color.White;
            this.Btn_AddSaveService.Location = new System.Drawing.Point(641, 189);
            this.Btn_AddSaveService.Name = "Btn_AddSaveService";
            this.Btn_AddSaveService.Size = new System.Drawing.Size(161, 37);
            this.Btn_AddSaveService.TabIndex = 5;
            this.Btn_AddSaveService.Text = "Adicionar / Salvar";
            this.Btn_AddSaveService.TextColor = System.Drawing.Color.White;
            this.Btn_AddSaveService.UseVisualStyleBackColor = false;
            // 
            // Btn_UpdateService
            // 
            this.Btn_UpdateService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_UpdateService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_UpdateService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_UpdateService.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_UpdateService.BorderRadius = 10;
            this.Btn_UpdateService.BorderSize = 0;
            this.Btn_UpdateService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_UpdateService.FlatAppearance.BorderSize = 0;
            this.Btn_UpdateService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_UpdateService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_UpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpdateService.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpdateService.ForeColor = System.Drawing.Color.White;
            this.Btn_UpdateService.Location = new System.Drawing.Point(956, 390);
            this.Btn_UpdateService.Name = "Btn_UpdateService";
            this.Btn_UpdateService.Size = new System.Drawing.Size(104, 37);
            this.Btn_UpdateService.TabIndex = 7;
            this.Btn_UpdateService.Text = "Actualizar";
            this.Btn_UpdateService.TextColor = System.Drawing.Color.White;
            this.Btn_UpdateService.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Btn_ClearCamps);
            this.groupBox2.Controls.Add(this.Btn_AddSaveService);
            this.groupBox2.Controls.Add(this.Tb_ServicePrice);
            this.groupBox2.Controls.Add(this.Tb_ServiceCode);
            this.groupBox2.Controls.Add(this.Tb_ServiceName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Tb_ServiceDescription);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(71, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 251);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código de serviço:";
            // 
            // Btn_ClearCamps
            // 
            this.Btn_ClearCamps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_ClearCamps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_ClearCamps.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_ClearCamps.BorderRadius = 10;
            this.Btn_ClearCamps.BorderSize = 0;
            this.Btn_ClearCamps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ClearCamps.FlatAppearance.BorderSize = 0;
            this.Btn_ClearCamps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_ClearCamps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_ClearCamps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ClearCamps.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ClearCamps.ForeColor = System.Drawing.Color.White;
            this.Btn_ClearCamps.Location = new System.Drawing.Point(818, 189);
            this.Btn_ClearCamps.Name = "Btn_ClearCamps";
            this.Btn_ClearCamps.Size = new System.Drawing.Size(161, 37);
            this.Btn_ClearCamps.TabIndex = 6;
            this.Btn_ClearCamps.Text = "Limpar campos";
            this.Btn_ClearCamps.TextColor = System.Drawing.Color.White;
            this.Btn_ClearCamps.UseVisualStyleBackColor = false;
            // 
            // Tb_ServicePrice
            // 
            this.Tb_ServicePrice.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ServicePrice.Location = new System.Drawing.Point(32, 196);
            this.Tb_ServicePrice.Name = "Tb_ServicePrice";
            this.Tb_ServicePrice.Size = new System.Drawing.Size(280, 27);
            this.Tb_ServicePrice.TabIndex = 3;
            this.Tb_ServicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Tb_ServiceCode
            // 
            this.Tb_ServiceCode.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ServiceCode.Location = new System.Drawing.Point(32, 64);
            this.Tb_ServiceCode.Mask = "GP-S000";
            this.Tb_ServiceCode.Name = "Tb_ServiceCode";
            this.Tb_ServiceCode.Size = new System.Drawing.Size(315, 27);
            this.Tb_ServiceCode.TabIndex = 1;
            // 
            // Tb_ServiceName
            // 
            this.Tb_ServiceName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Tb_ServiceName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.Tb_ServiceName.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ServiceName.Location = new System.Drawing.Point(32, 131);
            this.Tb_ServiceName.Name = "Tb_ServiceName";
            this.Tb_ServiceName.Size = new System.Drawing.Size(315, 27);
            this.Tb_ServiceName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descrição:";
            // 
            // Tb_ServiceDescription
            // 
            this.Tb_ServiceDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Tb_ServiceDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.Tb_ServiceDescription.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_ServiceDescription.Location = new System.Drawing.Point(373, 64);
            this.Tb_ServiceDescription.Multiline = true;
            this.Tb_ServiceDescription.Name = "Tb_ServiceDescription";
            this.Tb_ServiceDescription.Size = new System.Drawing.Size(606, 94);
            this.Tb_ServiceDescription.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Mt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Preço:";
            // 
            // ServiceUserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Name = "ServiceUserControlForm";
            this.Size = new System.Drawing.Size(1135, 696);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridView;
        private Controls.Buttons Btn_DeleteService;
        private Controls.Buttons Btn_AddSaveService;
        private Controls.Buttons Btn_UpdateService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Controls.Buttons Btn_ClearCamps;
        private Controls.OnlyInt Tb_ServicePrice;
        private System.Windows.Forms.MaskedTextBox Tb_ServiceCode;
        private System.Windows.Forms.TextBox Tb_ServiceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_ServiceDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
