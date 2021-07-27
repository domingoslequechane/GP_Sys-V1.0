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
    public partial class ClientsUserControlForm : UserControl
    {
        Thread goToeditClient;
        public ClientsUserControlForm()
        {
            InitializeComponent();
        }

        private void ClientsUserControlForm_Load(object sender, EventArgs e)
        {
            Tb_Search.Focus();
        }

        private void Btn_SearchClear_Click(object sender, EventArgs e)
        {
            Tb_Search.Focus();
            Tb_Search.SelectAll();
        }

        private void Btn_EditClient_Click(object sender, EventArgs e)
        {
            goToeditClient = new Thread(ToEditClient);
            goToeditClient.SetApartmentState(ApartmentState.STA);
            goToeditClient.Start();
        }

        private void ToEditClient(object obj)
        {
            Application.Run(new ClientsUpdateForm());
        }
    }
}
