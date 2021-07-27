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
    public partial class NewPassForm : Form
    {
        Thread goToLoginForm, goToConfitmationNewPassForm;
        public NewPassForm()
        {
            InitializeComponent();
            Tb_NewPassword1.UseSystemPasswordChar = true;
            Tb_NewPassword2.UseSystemPasswordChar = true;
        }

        private void Link_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            goToLoginForm = new Thread(LoginForm);
            goToLoginForm.SetApartmentState(ApartmentState.STA);
            goToLoginForm.Start();
        }

        private void LoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void Btn_UpdatePassword_Click(object sender, EventArgs e)
        {
            this.Close();
            goToConfitmationNewPassForm = new Thread(ConfitmationNewPassForm);
            goToConfitmationNewPassForm.SetApartmentState(ApartmentState.STA);
            goToConfitmationNewPassForm.Start();
        }

        private void Cb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ShowPassword.Checked)
            {
                Tb_NewPassword1.UseSystemPasswordChar = false;
                Tb_NewPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                Tb_NewPassword1.UseSystemPasswordChar = true;
                Tb_NewPassword2.UseSystemPasswordChar = true;
            }
        }

        private void ConfitmationNewPassForm(object obj)
        {
            Application.Run(new ConfirmationNewPassForm());
        }
    }
}
