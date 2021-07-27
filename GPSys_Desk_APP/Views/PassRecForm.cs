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
    public partial class PassRecForm : Form
    {
        Thread goToCodeRecErroForm, goToNewPassForm, goToLogin;
        public PassRecForm()
        {
            InitializeComponent();
            Tb_RecoveryCode.UseSystemPasswordChar = true;
        }

        private void Cb_ShowHideCode_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ShowHideCode.Checked)
            {
                Tb_RecoveryCode.UseSystemPasswordChar = false;
            }
            else
            {
                Tb_RecoveryCode.UseSystemPasswordChar = true;
            }
        }

        private void Link_ReturnToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            goToLogin = new Thread(LoginForm);
            goToLogin.SetApartmentState(ApartmentState.STA);
            goToLogin.Start();
        }

        private void LoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void Link_RetrieveCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            goToCodeRecErroForm = new Thread(CodeRecErroForm);
            goToCodeRecErroForm.SetApartmentState(ApartmentState.STA);
            goToCodeRecErroForm.Start();
        }

        private void Btn_VerifyCode_Click(object sender, EventArgs e)
        {
            this.Close();
            goToNewPassForm = new Thread(NewPassForm);
            goToNewPassForm.SetApartmentState(ApartmentState.STA);
            goToNewPassForm.Start();
        }

        private void CodeRecErroForm(object obj)
        {
            Application.Run(new CodRecErroForm());
        }

        private void NewPassForm(object obj)
        {
            Application.Run(new NewPassForm());
        }
    }
}
