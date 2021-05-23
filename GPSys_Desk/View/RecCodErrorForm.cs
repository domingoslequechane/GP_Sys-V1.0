using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSys_Desk.View
{
    public partial class RecCodErrorForm : Form
    {
        public RecCodErrorForm()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
