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
    public partial class PriceUserControlForm : UserControl
    {
        public PriceUserControlForm()
        {
            InitializeComponent();
        }

        private void PriceUserControlForm_Load(object sender, EventArgs e)
        {
            Tb_ClientName.Focus();
        }

        private void Btn_AddService_Click(object sender, EventArgs e)
        {

        }
    }
}
