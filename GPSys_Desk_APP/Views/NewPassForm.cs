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
            textBox_NewPass1.UseSystemPasswordChar = true;
            textBox_NewPass2.UseSystemPasswordChar = true;
        }

        private void checkBox_Pass12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Pass12.Checked)
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

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            this.Close();
            goToConfitmationNewPassForm = new Thread(ConfitmationNewPassForm);
            goToConfitmationNewPassForm.SetApartmentState(ApartmentState.STA);
            goToConfitmationNewPassForm.Start();
        }

        private void ConfitmationNewPassForm(object obj)
        {
            Application.Run(new ConfitmationNewPassForm());
        }
    }
}
