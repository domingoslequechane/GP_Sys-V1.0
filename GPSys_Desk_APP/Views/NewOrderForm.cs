using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSys_Desk_APP.Views
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();

            Tb_ClientName.Focus();

            Cb_ClientCity.SelectedIndex = 0;
            Cb_Service.SelectedIndex = 0;
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_AddSave_Click(object sender, EventArgs e)
        {

        }
    }
}
