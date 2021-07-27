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
    public partial class OrderUpdateForm : Form
    {
        public OrderUpdateForm()
        {
            InitializeComponent();
            Cb_Service.Focus();
            Cb_Service.SelectedIndex = 0;
        }

        private void OrderUpdateForm_Load(object sender, EventArgs e)
        {
            Cb_Service.Focus();
            Cb_Service.SelectedIndex = 0;
        }
    }
}
