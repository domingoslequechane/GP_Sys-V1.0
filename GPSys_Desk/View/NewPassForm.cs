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
        Thread newForm;
        Thread backForm;

        public NewPassForm()
        {
            InitializeComponent();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (textBox_NewPass1.Text == textBox_NewPass2.Text)
            {
                this.Close();
                newForm = new Thread(novoFormulario);
                newForm.SetApartmentState(ApartmentState.STA);
                newForm.Start();
            }
            else
            {
                label_IncoerenciaInfo1.Text = "Incoeréncia!";
                label_IncoerenciaInfo2.Text = "As duas senhas tem de ser iguais";
            }
        }

        private void novoFormulario(object obj)
        {
            Application.Run(new ConfirmedNewPassForm());
        }

        private void goToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            backForm = new Thread(voltarLogin);
            backForm.SetApartmentState(ApartmentState.STA);
            backForm.Start();
        }

        private void voltarLogin(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void link_GoToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            backForm = new Thread(goToLogin);
            backForm.SetApartmentState(ApartmentState.STA);
            backForm.Start();
        }

        private void goToLogin(object obj)
        {
            Application.Run(new LoginForm());
        }
    }
}
