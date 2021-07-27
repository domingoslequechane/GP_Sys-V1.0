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
    public partial class ConfirmationNewPassForm : Form
    {
        Thread goToLoginForm;
        public ConfirmationNewPassForm()
        {
            InitializeComponent();
        }

        private void Btn_ReturnToLogin_Click(object sender, EventArgs e)
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
