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
    public partial class PrincipalForm : Form
    {
        Thread newForm;
        Thread goToLoginForm;
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void btn_Ordem_Click(object sender, EventArgs e)
        {
            this.Close();
            newForm = new Thread(Workspace);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void Workspace(object obj)
        {
            Application.Run(new WorkspaceForm());
        }

        private void link_Sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                goToLoginForm = new Thread(goToLogin);
                goToLoginForm.SetApartmentState(ApartmentState.STA);
                goToLoginForm.Start();
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                goToLoginForm = new Thread(goToLogin);
                goToLoginForm.SetApartmentState(ApartmentState.STA);
                goToLoginForm.Start();
            }
        }

        private void btn_Sair2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                goToLoginForm = new Thread(goToLogin);
                goToLoginForm.SetApartmentState(ApartmentState.STA);
                goToLoginForm.Start();
            }
        }

        private void goToLogin(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox_Search.Focus();
            textBox_Search.SelectAll();
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            */
        }
    }
}
