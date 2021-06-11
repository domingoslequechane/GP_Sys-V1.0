using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GPSys_Desk.View
{
    public partial class WorkspaceForm : Form
    {
        public WorkspaceForm()
        {
            InitializeComponent();

            // Side panel configuration
            side_Pnel.Height = btn_Home.Height;
            side_Pnel.Top = btn_Home.Top;

            // BTN color presentation
            btn_Home.BackColor = Color.Firebrick;
            btn_Order.BackColor = Color.Transparent;
            btn_Clients.BackColor = Color.Transparent;
            btn_Calendar.BackColor = Color.Transparent;

            // Window presentation
            calendarControlForm1.Hide();
            clientsControlForm1.Hide();
            orderControlForm1.Hide();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            // Side panel configuration
            side_Pnel.Height = btn_Home.Height;
            side_Pnel.Top = btn_Home.Top;

            // BTN color presentation
            btn_Home.BackColor = Color.Firebrick;
            btn_Order.BackColor = Color.Transparent;
            btn_Clients.BackColor = Color.Transparent;
            btn_Calendar.BackColor = Color.Transparent;

            // Window presentation
            orderControlForm1.Hide();
            clientsControlForm1.Hide();
            calendarControlForm1.Hide();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            // Side panel configuration
            side_Pnel.Height = btn_Order.Height;
            side_Pnel.Top = btn_Order.Top;

            // BTN color presentation
            btn_Home.BackColor = Color.Transparent;
            btn_Order.BackColor = Firebrick;
            btn_Clients.BackColor = Color.Transparent;
            btn_Calendar.BackColor = Color.Transparent;

            // Window presentation
            orderControlForm1.Show();
            clientsControlForm1.Hide();
            calendarControlForm1.Hide();
        }

        private void btn_Clients_Click(object sender, EventArgs e)
        {
            
            orderControlForm1.Hide();
            clientsControlForm1.Show();
            calendarControlForm1.Hide();

            // Side panel configuration
            side_Pnel.Height = btn_Clients.Height;
            side_Pnel.Top = btn_Clients.Top;

            // BTN color presentation
            btn_Home.BackColor = Color.Transparent;
            btn_Order.BackColor = Color.Transparent;
            btn_Clients.BackColor = Firebrick;
            btn_Calendar.BackColor = Color.Transparent;

            // Window presentation
            orderControlForm1.Hide();
            clientsControlForm1.Show();
            calendarControlForm1.Hide();
        }

        private void btn_Calendar_Click(object sender, EventArgs e)
        {
            // Side panel configuration
            side_Pnel.Height = btn_Calendar.Height;
            side_Pnel.Top = btn_Calendar.Top;

            // BTN color presentation
            btn_Home.BackColor = Color.Transparent;
            btn_Order.BackColor = Color.Transparent;
            btn_Clients.BackColor = Color.Transparent;
            btn_Calendar.BackColor = Color.Firebrick;

            // Window presentation
            orderControlForm1.Hide();
            clientsControlForm1.Hide();
            calendarControlForm1.Show();
        }
    }
}
