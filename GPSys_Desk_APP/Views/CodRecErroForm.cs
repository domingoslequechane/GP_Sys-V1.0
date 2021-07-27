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

namespace GPSys_Desk_APP.Views
{
    public partial class CodRecErroForm : Form
    {
        Thread goToLoginForm;
        public CodRecErroForm()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
