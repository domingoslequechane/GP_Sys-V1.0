
namespace GPSys_Desk_APP.Views
{
    partial class ColaboratorsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColaboratorsUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Btn_DeleteData = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_Update = new GPSys_Desk_APP.Controls.Buttons();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Tb_EmployeePhoneNumber2 = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Tb_EmployeeNaturalness = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Tb_EmployeeSurname = new System.Windows.Forms.TextBox();
            this.Cb_EmployeeOfficePosition = new System.Windows.Forms.ComboBox();
            this.Tb_EmployeePhoneNumber1 = new System.Windows.Forms.MaskedTextBox();
            this.Tb_EmployeeNUIT = new System.Windows.Forms.MaskedTextBox();
            this.Dt_EmployeeBirthDayDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_AddEmployee = new GPSys_Desk_APP.Controls.Buttons();
            this.Cb_EmployeeSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_SaveChange = new GPSys_Desk_APP.Controls.Buttons();
            this.Btn_ClearFields = new GPSys_Desk_APP.Controls.Buttons();
            this.Tb_EmployeeCod = new System.Windows.Forms.MaskedTextBox();
            this.Tb_EmployeeAddress = new System.Windows.Forms.TextBox();
            this.Tb_EmployeeEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_EmployeeICN = new System.Windows.Forms.TextBox();
            this.Tb_EmployeeName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Btn_DeleteData);
            this.panel1.Controls.Add(this.Btn_Update);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 696);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 819);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 10);
            this.panel3.TabIndex = 91;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 829);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 10);
            this.panel2.TabIndex = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 539);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 280);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista dos Funcionários";
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
            this.DataGridView.Size = new System.Drawing.Size(817, 199);
            this.DataGridView.TabIndex = 75;
            // 
            // Btn_DeleteData
            // 
            this.Btn_DeleteData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_DeleteData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_DeleteData.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_DeleteData.BorderRadius = 10;
            this.Btn_DeleteData.BorderSize = 0;
            this.Btn_DeleteData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DeleteData.FlatAppearance.BorderSize = 0;
            this.Btn_DeleteData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_DeleteData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_DeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeleteData.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteData.ForeColor = System.Drawing.Color.White;
            this.Btn_DeleteData.Location = new System.Drawing.Point(960, 638);
            this.Btn_DeleteData.Name = "Btn_DeleteData";
            this.Btn_DeleteData.Size = new System.Drawing.Size(100, 37);
            this.Btn_DeleteData.TabIndex = 88;
            this.Btn_DeleteData.Text = "Excluir";
            this.Btn_DeleteData.TextColor = System.Drawing.Color.White;
            this.Btn_DeleteData.UseVisualStyleBackColor = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_Update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_Update.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Update.BorderRadius = 10;
            this.Btn_Update.BorderSize = 0;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(960, 592);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(100, 37);
            this.Btn_Update.TabIndex = 86;
            this.Btn_Update.Text = "Actualizar";
            this.Btn_Update.TextColor = System.Drawing.Color.White;
            this.Btn_Update.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Tb_EmployeePhoneNumber2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.Tb_EmployeeNaturalness);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Tb_EmployeeSurname);
            this.groupBox2.Controls.Add(this.Cb_EmployeeOfficePosition);
            this.groupBox2.Controls.Add(this.Tb_EmployeePhoneNumber1);
            this.groupBox2.Controls.Add(this.Tb_EmployeeNUIT);
            this.groupBox2.Controls.Add(this.Dt_EmployeeBirthDayDate);
            this.groupBox2.Controls.Add(this.Btn_AddEmployee);
            this.groupBox2.Controls.Add(this.Cb_EmployeeSex);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Btn_SaveChange);
            this.groupBox2.Controls.Add(this.Btn_ClearFields);
            this.groupBox2.Controls.Add(this.Tb_EmployeeCod);
            this.groupBox2.Controls.Add(this.Tb_EmployeeAddress);
            this.groupBox2.Controls.Add(this.Tb_EmployeeEmail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Tb_EmployeeICN);
            this.groupBox2.Controls.Add(this.Tb_EmployeeName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(71, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 450);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionário";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 19);
            this.label12.TabIndex = 92;
            this.label12.Text = "Contacto (Alternativo):";
            // 
            // Tb_EmployeePhoneNumber2
            // 
            this.Tb_EmployeePhoneNumber2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeePhoneNumber2.Location = new System.Drawing.Point(32, 328);
            this.Tb_EmployeePhoneNumber2.Mask = "(+258) 00 000 0000";
            this.Tb_EmployeePhoneNumber2.Name = "Tb_EmployeePhoneNumber2";
            this.Tb_EmployeePhoneNumber2.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeePhoneNumber2.TabIndex = 93;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(358, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 19);
            this.label16.TabIndex = 90;
            this.label16.Text = "Naturalidade: *";
            // 
            // Tb_EmployeeNaturalness
            // 
            this.Tb_EmployeeNaturalness.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeeNaturalness.Location = new System.Drawing.Point(355, 196);
            this.Tb_EmployeeNaturalness.Name = "Tb_EmployeeNaturalness";
            this.Tb_EmployeeNaturalness.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeeNaturalness.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(358, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 88;
            this.label11.Text = "Apelido: *";
            // 
            // Tb_EmployeeSurname
            // 
            this.Tb_EmployeeSurname.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeeSurname.Location = new System.Drawing.Point(355, 131);
            this.Tb_EmployeeSurname.Name = "Tb_EmployeeSurname";
            this.Tb_EmployeeSurname.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeeSurname.TabIndex = 89;
            // 
            // Cb_EmployeeOfficePosition
            // 
            this.Cb_EmployeeOfficePosition.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_EmployeeOfficePosition.FormattingEnabled = true;
            this.Cb_EmployeeOfficePosition.Items.AddRange(new object[] {
            "Editor (a)",
            "Gerente",
            "Produtor (a)",
            "Secretário (a)"});
            this.Cb_EmployeeOfficePosition.Location = new System.Drawing.Point(678, 328);
            this.Cb_EmployeeOfficePosition.Name = "Cb_EmployeeOfficePosition";
            this.Cb_EmployeeOfficePosition.Size = new System.Drawing.Size(296, 27);
            this.Cb_EmployeeOfficePosition.TabIndex = 83;
            // 
            // Tb_EmployeePhoneNumber1
            // 
            this.Tb_EmployeePhoneNumber1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeePhoneNumber1.Location = new System.Drawing.Point(678, 262);
            this.Tb_EmployeePhoneNumber1.Mask = "(+258) 00 000 0000";
            this.Tb_EmployeePhoneNumber1.Name = "Tb_EmployeePhoneNumber1";
            this.Tb_EmployeePhoneNumber1.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeePhoneNumber1.TabIndex = 82;
            // 
            // Tb_EmployeeNUIT
            // 
            this.Tb_EmployeeNUIT.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeeNUIT.Location = new System.Drawing.Point(32, 262);
            this.Tb_EmployeeNUIT.Mask = "000-000-000";
            this.Tb_EmployeeNUIT.Name = "Tb_EmployeeNUIT";
            this.Tb_EmployeeNUIT.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeeNUIT.TabIndex = 81;
            // 
            // Dt_EmployeeBirthDayDate
            // 
            this.Dt_EmployeeBirthDayDate.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_EmployeeBirthDayDate.Location = new System.Drawing.Point(32, 196);
            this.Dt_EmployeeBirthDayDate.Name = "Dt_EmployeeBirthDayDate";
            this.Dt_EmployeeBirthDayDate.Size = new System.Drawing.Size(296, 27);
            this.Dt_EmployeeBirthDayDate.TabIndex = 80;
            // 
            // Btn_AddEmployee
            // 
            this.Btn_AddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_AddEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_AddEmployee.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_AddEmployee.BorderRadius = 10;
            this.Btn_AddEmployee.BorderSize = 0;
            this.Btn_AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddEmployee.FlatAppearance.BorderSize = 0;
            this.Btn_AddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_AddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddEmployee.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddEmployee.ForeColor = System.Drawing.Color.White;
            this.Btn_AddEmployee.Location = new System.Drawing.Point(540, 385);
            this.Btn_AddEmployee.Name = "Btn_AddEmployee";
            this.Btn_AddEmployee.Size = new System.Drawing.Size(121, 37);
            this.Btn_AddEmployee.TabIndex = 87;
            this.Btn_AddEmployee.Text = "Adicionar";
            this.Btn_AddEmployee.TextColor = System.Drawing.Color.White;
            this.Btn_AddEmployee.UseVisualStyleBackColor = false;
            // 
            // Cb_EmployeeSex
            // 
            this.Cb_EmployeeSex.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_EmployeeSex.FormattingEnabled = true;
            this.Cb_EmployeeSex.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.Cb_EmployeeSex.Location = new System.Drawing.Point(678, 131);
            this.Cb_EmployeeSex.Name = "Cb_EmployeeSex";
            this.Cb_EmployeeSex.Size = new System.Drawing.Size(296, 27);
            this.Cb_EmployeeSex.TabIndex = 79;
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
            // Btn_SaveChange
            // 
            this.Btn_SaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_SaveChange.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_SaveChange.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_SaveChange.BorderRadius = 10;
            this.Btn_SaveChange.BorderSize = 0;
            this.Btn_SaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SaveChange.FlatAppearance.BorderSize = 0;
            this.Btn_SaveChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_SaveChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_SaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SaveChange.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveChange.ForeColor = System.Drawing.Color.White;
            this.Btn_SaveChange.Location = new System.Drawing.Point(681, 385);
            this.Btn_SaveChange.Name = "Btn_SaveChange";
            this.Btn_SaveChange.Size = new System.Drawing.Size(121, 37);
            this.Btn_SaveChange.TabIndex = 78;
            this.Btn_SaveChange.Text = "Salvar";
            this.Btn_SaveChange.TextColor = System.Drawing.Color.White;
            this.Btn_SaveChange.UseVisualStyleBackColor = false;
            // 
            // Btn_ClearFields
            // 
            this.Btn_ClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_ClearFields.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_ClearFields.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_ClearFields.BorderRadius = 10;
            this.Btn_ClearFields.BorderSize = 0;
            this.Btn_ClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ClearFields.FlatAppearance.BorderSize = 0;
            this.Btn_ClearFields.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Btn_ClearFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.Btn_ClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ClearFields.Font = new System.Drawing.Font("Gotham", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ClearFields.ForeColor = System.Drawing.Color.White;
            this.Btn_ClearFields.Location = new System.Drawing.Point(822, 385);
            this.Btn_ClearFields.Name = "Btn_ClearFields";
            this.Btn_ClearFields.Size = new System.Drawing.Size(152, 37);
            this.Btn_ClearFields.TabIndex = 78;
            this.Btn_ClearFields.Text = "Limpar campos";
            this.Btn_ClearFields.TextColor = System.Drawing.Color.White;
            this.Btn_ClearFields.UseVisualStyleBackColor = false;
            // 
            // Tb_EmployeeCod
            // 
            this.Tb_EmployeeCod.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeeCod.Location = new System.Drawing.Point(32, 64);
            this.Tb_EmployeeCod.Mask = "7180-6700";
            this.Tb_EmployeeCod.Name = "Tb_EmployeeCod";
            this.Tb_EmployeeCod.ReadOnly = true;
            this.Tb_EmployeeCod.Size = new System.Drawing.Size(300, 27);
            this.Tb_EmployeeCod.TabIndex = 32;
            this.Tb_EmployeeCod.Text = "0";
            // 
            // Tb_EmployeeAddress
            // 
            this.Tb_EmployeeAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Tb_EmployeeAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.Tb_EmployeeAddress.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeeAddress.Location = new System.Drawing.Point(355, 262);
            this.Tb_EmployeeAddress.Name = "Tb_EmployeeAddress";
            this.Tb_EmployeeAddress.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeeAddress.TabIndex = 34;
            // 
            // Tb_EmployeeEmail
            // 
            this.Tb_EmployeeEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Tb_EmployeeEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.Tb_EmployeeEmail.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeeEmail.Location = new System.Drawing.Point(355, 328);
            this.Tb_EmployeeEmail.Name = "Tb_EmployeeEmail";
            this.Tb_EmployeeEmail.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeeEmail.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(681, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cargo: *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Endereço: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data de nascimento: *";
            // 
            // Tb_EmployeeICN
            // 
            this.Tb_EmployeeICN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Tb_EmployeeICN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.Tb_EmployeeICN.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeeICN.Location = new System.Drawing.Point(678, 196);
            this.Tb_EmployeeICN.Name = "Tb_EmployeeICN";
            this.Tb_EmployeeICN.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeeICN.TabIndex = 34;
            // 
            // Tb_EmployeeName
            // 
            this.Tb_EmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Tb_EmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.Tb_EmployeeName.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_EmployeeName.Location = new System.Drawing.Point(32, 131);
            this.Tb_EmployeeName.Name = "Tb_EmployeeName";
            this.Tb_EmployeeName.Size = new System.Drawing.Size(296, 27);
            this.Tb_EmployeeName.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(358, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "NUIT: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(681, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sexo: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(681, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Contacto (Principal): *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(681, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "BI: *";
            // 
            // ColaboratorsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Name = "ColaboratorsUserControl";
            this.Size = new System.Drawing.Size(1135, 696);
            this.Load += new System.EventHandler(this.ColaboratorsUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Controls.Buttons Btn_ClearFields;
        private System.Windows.Forms.MaskedTextBox Tb_EmployeeCod;
        private System.Windows.Forms.TextBox Tb_EmployeeAddress;
        private System.Windows.Forms.TextBox Tb_EmployeeEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_EmployeeICN;
        private System.Windows.Forms.TextBox Tb_EmployeeName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridView;
        private Controls.Buttons Btn_DeleteData;
        private Controls.Buttons Btn_AddEmployee;
        private Controls.Buttons Btn_Update;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker Dt_EmployeeBirthDayDate;
        private System.Windows.Forms.ComboBox Cb_EmployeeSex;
        private System.Windows.Forms.MaskedTextBox Tb_EmployeeNUIT;
        private System.Windows.Forms.MaskedTextBox Tb_EmployeePhoneNumber1;
        private System.Windows.Forms.ComboBox Cb_EmployeeOfficePosition;
        private Controls.Buttons Btn_SaveChange;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Tb_EmployeeSurname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Tb_EmployeeNaturalness;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox Tb_EmployeePhoneNumber2;
    }
}
