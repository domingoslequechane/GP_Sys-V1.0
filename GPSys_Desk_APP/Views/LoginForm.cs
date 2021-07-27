using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPSys_Desk_APP.Views;
using System.Threading;

namespace GPSys_Desk_APP.Views
{
    public partial class LoginForm : Form
    {
        Thread goToPassRecForm, goToWorkspaceForm, goToConnectionSettingForm;
        public LoginForm()
        {
            InitializeComponent();
            Tb_LoginPassword.UseSystemPasswordChar = true;
        }

        private void Link_PassRec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            goToPassRecForm = new Thread(PassRecForm);
            goToPassRecForm.SetApartmentState(ApartmentState.STA);
            goToPassRecForm.Start();
        }

        private void PassRecForm(object obj)
        {
            Application.Run(new PassRecForm());
        }

        private void WorkspaceForm(object obj)
        {
            Application.Run(new WorkspaceForm());
        }

        private void Cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ShowPass.Checked)
            {
                Tb_LoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                Tb_LoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            goToWorkspaceForm = new Thread(WorkspaceForm);
            goToWorkspaceForm.SetApartmentState(ApartmentState.STA);
            goToWorkspaceForm.Start();
        }

        private void Btn_DBSetting_Click(object sender, EventArgs e)
        {
            goToConnectionSettingForm = new Thread(ToConnectionSettingForm);
            goToConnectionSettingForm.SetApartmentState(ApartmentState.STA);
            goToConnectionSettingForm.Start();
        }

        private void ToConnectionSettingForm(object obj)
        {
            Application.Run(new DBConnectionSettingForm());
        }
    }
}
