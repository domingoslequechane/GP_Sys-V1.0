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
    public partial class OrderUserControlForm : UserControl
    {
        Thread addOrder, editOrder;
        public OrderUserControlForm()
        {
            InitializeComponent();
        }

        private void UpdateOder(object obj)
        {
            Application.Run(new OrderUpdateForm());
        }

        private void OrderUserControlForm_Load(object sender, EventArgs e)
        {
            Tb_Search.Focus();
            Tb_Search.SelectAll();
        }

        private void Btn_ClearSearchCamp_Click(object sender, EventArgs e)
        {
            Tb_Search.Focus();
            Tb_Search.SelectAll();
        }

        private void Btn_NewOrder_Click(object sender, EventArgs e)
        {
            addOrder = new Thread(NewOder);
            addOrder.SetApartmentState(ApartmentState.STA);
            addOrder.Start();
        }

        private void Btn_EditOrder_Click(object sender, EventArgs e)
        {
            editOrder = new Thread(UpdateOder);
            editOrder.SetApartmentState(ApartmentState.STA);
            editOrder.Start();
        }

        private void NewOder(object obj)
        {
            Application.Run(new NewOrderForm());
        }
    }
}
