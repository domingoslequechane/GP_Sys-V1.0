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
using GPSys_Desk_APP.Controls;

namespace GPSys_Desk_APP.Views
{
    public partial class EmployeeForm : Form
    {
        Thread goToLoginForm;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        WaitFormFunction waitForm = new WaitFormFunction();

        private void buttons1_Click(object sender, EventArgs e)
        {
            waitForm.Show(this);
            Thread.Sleep(1500);
            this.Close();
            goToLoginForm = new Thread(ToLogin);
            goToLoginForm.SetApartmentState(ApartmentState.STA);
            goToLoginForm.Start();
            waitForm.Close();
        }

        private void ToLogin(object obj)
        {
            Application.Run(new LoginForm());
        }
    }
}
