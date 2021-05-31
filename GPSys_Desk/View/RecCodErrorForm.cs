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
    public partial class RecCodErrorForm : Form
    {
        Thread backForm;

        public RecCodErrorForm()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
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
