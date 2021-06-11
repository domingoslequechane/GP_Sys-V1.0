using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GPSys_Desk.View
{
    public partial class NewPassForm : Form
    {
        Thread goToConfirmationForm;
        Thread goToLoginForm;

        public NewPassForm()
        {
            InitializeComponent();
            textBox_NewPass1.UseSystemPasswordChar = true;
            textBox_NewPass2.UseSystemPasswordChar = true;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            this.Close();
            goToConfirmationForm = new Thread(goConfirmationForm);
            goToConfirmationForm.SetApartmentState(ApartmentState.STA);
            goToConfirmationForm.Start();
        }

        private void goConfirmationForm(object obj)
        {
            Application.Run(new ConfirmedNewPassForm());
        }

        private void link_GoToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            goToLoginForm = new Thread(goToLogin);
            goToLoginForm.SetApartmentState(ApartmentState.STA);
            goToLoginForm.Start();
        }

        private void goToLogin(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void checkBox_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Pass.Checked)
            {
                textBox_NewPass1.UseSystemPasswordChar = false;
                textBox_NewPass2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_NewPass1.UseSystemPasswordChar = true;
                textBox_NewPass2.UseSystemPasswordChar = true;
            }
        }
    }
}
