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
using GPSys_Desk_APP.Views;

namespace GPSys_Desk_APP.Views
{
    public partial class WorkspaceForm : Form
    {
        Thread goToLoginForm;
        public WorkspaceForm()
        {
            InitializeComponent();

            // Side panel configuration
            side_Panel.Height = Home_btn.Height;
            side_Panel.Top = Home_btn.Top;

            // BTN color presentation
            Home_btn.BackColor = Color.Firebrick;
            Order_btn.BackColor = Color.Transparent;
            Clients_btn.BackColor = Color.Transparent;
            Calendar_btn.BackColor = Color.Transparent;

            // Window presentation
            orderUserControlForm3.Hide();
            clientsUserControlForm3.Hide();
            calendarUserControlForm1.Hide();

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            // Side panel configuration
            side_Panel.Height = Home_btn.Height;
            side_Panel.Top = Home_btn.Top;

            // BTN color presentation
            Home_btn.BackColor = Color.Firebrick;
            Order_btn.BackColor = Color.Transparent;
            Clients_btn.BackColor = Color.Transparent;
            Calendar_btn.BackColor = Color.Transparent;

            // Window presentation
            orderUserControlForm3.Hide();
            clientsUserControlForm3.Hide();
            calendarUserControlForm1.Hide();
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            // Side panel configuration
            side_Panel.Height = Order_btn.Height;
            side_Panel.Top = Order_btn.Top;

            // BTN color presentation
            Home_btn.BackColor = Color.Transparent;
            Order_btn.BackColor = Color.Firebrick;
            Clients_btn.BackColor = Color.Transparent;
            Calendar_btn.BackColor = Color.Transparent;

            // Window presentation
            orderUserControlForm3.Show();
            clientsUserControlForm3.Hide();
            calendarUserControlForm1.Hide();
        }

        private void Calendar_btn_Click(object sender, EventArgs e)
        {
            
            // Side panel configuration
            side_Panel.Height = Calendar_btn.Height;
            side_Panel.Top = Calendar_btn.Top;

            // BTN color presentation
            Home_btn.BackColor = Color.Transparent;
            Order_btn.BackColor = Color.Transparent;
            Clients_btn.BackColor = Color.Transparent;
            Calendar_btn.BackColor = Color.Firebrick;

            // Window presentation
            orderUserControlForm3.Hide();
            clientsUserControlForm3.Hide();
            calendarUserControlForm1.Show();
        }

        private void Clients_btn_Click(object sender, EventArgs e)
        {
            // Side panel configuration
            side_Panel.Height = Clients_btn.Height;
            side_Panel.Top = Clients_btn.Top;

            // BTN color presentation
            Home_btn.BackColor = Color.Transparent;
            Order_btn.BackColor = Color.Transparent;
            Clients_btn.BackColor = Color.Firebrick;
            Calendar_btn.BackColor = Color.Transparent;

            // Window presentation
            orderUserControlForm3.Hide();
            clientsUserControlForm3.Show();
            calendarUserControlForm1.Hide();
        }


        private void Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                goToLoginForm = new Thread(ToLogin);
                goToLoginForm.SetApartmentState(ApartmentState.STA);
                goToLoginForm.Start();
            }
        }
        private void ToLogin(object obj)
        {
            Application.Run(new LoginForm());
        }
    }
}
