using GPSys_Desk_APP.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GPSys_Desk_APP.Views;
using System.Data.SqlClient;

namespace GPSys_Desk_APP.Views
{
    public partial class DBConnectionSettingForm : Form
    {
        Thread goToLoginForm, goToEmployeeForm;

        public DBConnectionSettingForm()
        {
            InitializeComponent();
            Tb_DBPassword.UseSystemPasswordChar = true;

            ShowData();
            Cb_ServerName.Focus();
        }

        WaitFormFunction waitForm = new WaitFormFunction();

        private void ShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowHidePassword.Checked)
            {
                Tb_DBPassword.UseSystemPasswordChar = false;
            }
            else
            {
                Tb_DBPassword.UseSystemPasswordChar = true;
            }
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            Thread.Sleep(2500);
            this.Close();
            goToEmployeeForm = new Thread(ToEmployeeForm);
            goToEmployeeForm.SetApartmentState(ApartmentState.STA);
            goToEmployeeForm.Start();
            Thread.Sleep(1500);
            waitForm.Close();
        }

        private void ToEmployeeForm(object obj)
        {
            Application.Run(new EmployeeForm());
        }

        private void ShowData()
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt = LocalDB.ShowData();

                DataGridView.DataSource = Dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void ClearField()
        {
            Cb_ServerName.Text = "";
            Cb_DBName.Text = "";
            Cb_DBUserName.Text = "";
            Tb_DBPassword.Text = "";
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(Tb_ID.Text) || string.IsNullOrEmpty(Cb_ServerName.Text) || string.IsNullOrEmpty(Cb_DBName.Text) || string.IsNullOrEmpty(Cb_DBUserName.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView.Rows[e.RowIndex];
                Tb_ID.Text = row.Cells["ID"].Value.ToString();
                Cb_ServerName.Text = row.Cells["Servidor"].Value.ToString();
                Cb_DBName.Text = row.Cells["Banco"].Value.ToString();
                Cb_DBUserName.Text = row.Cells["Usuario"].Value.ToString();
                Tb_DBPassword.Text = row.Cells["Senha"].Value.ToString();
            }
        }

        private void Btn_ClearFields_Click(object sender, EventArgs e)
        {
            ClearField();
            Cb_ServerName.Focus();
        }

        private void DBConnectionSettingForm_Load(object sender, EventArgs e)
        {
            Cb_ServerName.Focus();

            Cb_ServerName.Items.Add("");
            Cb_ServerName.Items.Add(".");
            Cb_ServerName.Items.Add("local");
            Cb_ServerName.Items.Add(@".\SQLEXPRESS");
            Cb_ServerName.Items.Add("127.0.0.1");
            Cb_ServerName.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));

            Cb_ServerName.SelectedIndex = 0;
        }

        private void Btn_DataInsert_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                MessageBox.Show("Para incerir, é necessario preencher todos os campos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBSetGet add = new DBSetGet();
                add.ID = Convert.ToInt32(Tb_ID.Text);
                add.ServerName = Cb_ServerName.Text;
                add.DBName = Cb_DBName.Text;
                add.DBUser = Cb_DBUserName.Text;
                add.DBPassword = Tb_DBPassword.Text;

                LocalDB.Add(add);
                ClearField();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_DataUpdate_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                MessageBox.Show("Preencha todos os campos pedidos ou selecione o registro que pretende Editar!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBSetGet update = new DBSetGet();
                update.ID = Convert.ToInt32(Tb_ID.Text);
                update.ServerName = Cb_ServerName.Text;
                update.DBName = Cb_DBName.Text;
                update.DBUser = Cb_DBUserName.Text;
                update.DBPassword = Tb_DBPassword.Text;

                LocalDB.Update(update);
                ClearField();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_DataDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tb_ID.Text))
            {
                MessageBox.Show("Por favor informe o ID do registro a ser excluido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if(MessageBox.Show("O registro com o 'Id' informado sera elimidado. Pretende continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int cod = Convert.ToInt32(Tb_ID.Text);
                    LocalDB.Delete(cod);
                    ShowData();
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_UseConnection_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};", Cb_ServerName.Text, Cb_DBName.Text, Cb_DBUserName.Text, Tb_DBPassword.Text);

            try
            {
                SqlHelper helperconnection = new SqlHelper(connectionString);
                if (helperconnection.IsConnection)
                {
                    AppConnectionSetting setting = new AppConnectionSetting();
                    setting.SaveConnectionString("con", connectionString);
                    MessageBox.Show("Sua conexão foi salva com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_TestConnection_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};", Cb_ServerName.Text, Cb_DBName.Text, Cb_DBUserName.Text, Tb_DBPassword.Text);

            try
            {
                SqlHelper helperconnection = new SqlHelper(connectionString);
                if (helperconnection.IsConnection)
                {
                    MessageBox.Show("Teste de conexao bem sucedida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
