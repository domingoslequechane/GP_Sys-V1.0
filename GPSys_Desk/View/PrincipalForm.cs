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
    }
}
