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
    public partial class ConfirmedNewPassForm : Form
    {
        Thread newForm;
        public ConfirmedNewPassForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            newForm = new Thread(novoFormulario);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void novoFormulario(object obj)
        {
            Application.Run(new LoginForm());
        }
    }
}
