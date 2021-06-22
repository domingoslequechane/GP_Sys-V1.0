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
    public partial class ConfitmationNewPassForm : Form
    {
        Thread goToLoginForm;
        public ConfitmationNewPassForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
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
