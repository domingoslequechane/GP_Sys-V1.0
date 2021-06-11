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
        Thread OpenHomeForm;
        Thread OpenPasswordRecForm;

        public LoginForm()
        {
            InitializeComponent();
            textBox_Pass.UseSystemPasswordChar = true;
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            OpenHomeForm = new Thread(HomeForm);
            OpenHomeForm.SetApartmentState(ApartmentState.STA);
            OpenHomeForm.Start();
        }

        private void HomeForm(object obj)
        {
            Application.Run(new WorkspaceForm());
        }

        private void link_PassRecForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            OpenPasswordRecForm = new Thread(PasswordRecForm);
            OpenPasswordRecForm.SetApartmentState(ApartmentState.STA);
            OpenPasswordRecForm.Start();
        }
        private void PasswordRecForm(object obj)
        {
            Application.Run(new PassRecForm());
        }

        private void checkBox_Show_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Show_Pass.Checked)
            {
                textBox_Pass.UseSystemPasswordChar = false;
            } else
            {
                textBox_Pass.UseSystemPasswordChar = true;
            }

        }
    }
}
