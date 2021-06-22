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
        Thread goToPassRecForm, goToWorkspaceForm;
        public LoginForm()
        {
            InitializeComponent();
            textBox_Pass.UseSystemPasswordChar = true;
        }

        private void checkBox_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Pass.Checked)
            {
                textBox_Pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Pass.UseSystemPasswordChar = true;
            }
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

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            this.Close();
            goToWorkspaceForm = new Thread(WorkspaceForm);
            goToWorkspaceForm.SetApartmentState(ApartmentState.STA);
            goToWorkspaceForm.Start();
        }

        private void WorkspaceForm(object obj)
        {
            Application.Run(new WorkspaceForm());
        }
    }
}
