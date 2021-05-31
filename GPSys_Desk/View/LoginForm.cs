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
using GPSys_Desk.View;

namespace GPSys_Desk
{
    public partial class LoginForm : Form
    {
        Thread newForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBox_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Show_Pass.Checked)
            {
                textBox_Pass.PasswordChar = '.';
            }
            else
            {
                textBox_Pass.PasswordChar = '*';
            }
        }

        private void link_PassRecForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            newForm = new Thread(novoFormulario);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void novoFormulario(object obj)
        {
            Application.Run(new PassRecForm());
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            // Validação de Campos
            if (textBox_User.Text == "User")
            {
                this.Close();
                newForm = new Thread(HomeForm);
                newForm.SetApartmentState(ApartmentState.STA);
                newForm.Start();
            }
            else
            {
                label_IncoerenciaInfo1.Text = "Usuário ou senha invalido (a).";
            }
        }

        private void HomeForm(object obj)
        {
            Application.Run(new PrincipalForm());
        }
    }
}
