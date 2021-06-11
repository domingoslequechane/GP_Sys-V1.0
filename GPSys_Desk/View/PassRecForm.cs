using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using GPSys_Desk.View;

namespace GPSys_Desk
{
    public partial class PassRecForm : Form
    {
        Thread goToErrorForm;
        Thread goToLoginForm;
        Thread goToConfirmationForm;
        Thread goToRecCodErrorForm;

        // Abrir dentro de formulario (Inicio)
        public PassRecForm()
        {
            InitializeComponent();
            textBox_Cod.UseSystemPasswordChar = true;
        }

        private void link_RecCodErrorForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            goToErrorForm = new Thread(ErrorForm);
            goToErrorForm.SetApartmentState(ApartmentState.STA);
            goToErrorForm.Start();
        }

        private void ErrorForm(object obj)
        {
            Application.Run(new View.RecCodErrorForm());
        }

        private void novoFormularioAccept(object obj)
        {
            Application.Run(new View.NewPassForm());
        }

        private void link_goToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            goToLoginForm = new Thread(goLoginForm);
            goToLoginForm.SetApartmentState(ApartmentState.STA);
            goToLoginForm.Start();
        }

        private void goLoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            this.Close();
            goToConfirmationForm = new Thread(goConfirmationForm);
            goToConfirmationForm.SetApartmentState(ApartmentState.STA);
            goToConfirmationForm.Start();
        }

        private void goConfirmationForm(object obj)
        {
            Application.Run(new NewPassForm());
        }

        private void checkBox_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Show_Pass.Checked)
            {
                textBox_Cod.UseSystemPasswordChar = false;
            } else
            {
                textBox_Cod.UseSystemPasswordChar = true;
            }
        }

        private void link_RecCodErrorForm_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            goToRecCodErrorForm = new Thread(goRecCodErrorForm);
            goToRecCodErrorForm.SetApartmentState(ApartmentState.STA);
            goToRecCodErrorForm.Start();
        }

        private void goRecCodErrorForm(object obj)
        {
            Application.Run(new RecCodErrorForm());
        }
    }
}