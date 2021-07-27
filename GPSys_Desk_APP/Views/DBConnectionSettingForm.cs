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

namespace GPSys_Desk_APP.Views
{
    public partial class DBConnectionSettingForm : Form
    {
        Thread goToLoginForm;

        public DBConnectionSettingForm()
        {
            InitializeComponent();
            Tb_DBPassword.UseSystemPasswordChar = true;
            Cb_ServerName.Focus();
        }

        private void ConnectionSettingForm_Load(object sender, EventArgs e)
        {

        }

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

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Dados guardados com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
                goToLoginForm = new Thread(ToLogin);
                goToLoginForm.SetApartmentState(ApartmentState.STA);
                goToLoginForm.Start();
            }
        }

        private void ToLogin(object obj)
        {
            Application.Run(new LoginForm());
        }
    }
}
