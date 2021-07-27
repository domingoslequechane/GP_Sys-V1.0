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
        Thread goToLoginForm, goToDBSetting, goToUserSetting;
        public WorkspaceForm()
        {
            InitializeComponent();

            //// Side panel configuration
            //side_Panel.Height = Home_btn.Height;
            //side_Panel.Top = Home_btn.Top;

            //// BTN color presentation
            //Home_btn.BackColor = Color.Firebrick;
            //Order_btn.BackColor = Color.Transparent;
            //Clients_btn.BackColor = Color.Transparent;
            //Calendar_btn.BackColor = Color.Transparent;

            //// Window presentation
            ////orderUserControlForm3.Hide();
            ////clientsUserControlForm3.Hide();
            //// calendarUserControlForm1.Hide();

        }

        private void ToLogin(object obj)
        {
            Application.Run(new LoginForm());
        }

        private void Btn_DBSetting_Click(object sender, EventArgs e)
        {
            goToDBSetting = new Thread(ToDBSetting);
            goToDBSetting.SetApartmentState(ApartmentState.STA);
            goToDBSetting.Start();
        }

        private void Btn_UserInfo_Click(object sender, EventArgs e)
        {
            goToUserSetting = new Thread(ToUserSetting);
            goToUserSetting.SetApartmentState(ApartmentState.STA);
            goToUserSetting.Start();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas outras janelas serão fechadas.\nTem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                goToLoginForm = new Thread(ToLogin);
                goToLoginForm.SetApartmentState(ApartmentState.STA);
                goToLoginForm.Start();
            }
        }

        private void ToUserSetting(object obj)
        {
            Application.Run(new EmployeeForm());
        }

        private void ToDBSetting(object obj)
        {
            Application.Run(new DBConnectionSettingForm());
        }
    }
}
