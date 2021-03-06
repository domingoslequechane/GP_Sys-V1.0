using GPSys_Desk_APP.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GPSys_Desk_APP.Views;

namespace GPSys_Desk_APP
{
    public partial class ProgressiveForm : Form
    {
        Thread goToLogin, goToDBConnectionSettings;
        public ProgressiveForm()
        {
            InitializeComponent();
        }

        // Progressive
        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() => {
                for(int i=0;i<totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10); //used to simulate length of operation 
                }
            });
        }

        private async void ProgressiveForm_Load(object sender, EventArgs e)
        {
            // Progressive
            List<string> list = new List<string>();
            for (int i = 0; i < 500; i++)
                list.Add(i.ToString());
            label_Status.Text = "A processar...";
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                label_Status.Text = string.Format("A carregar...{0}%", report.PercentComplete);
            };

            // Criação da Base de dados
            try
            {
                LocalDB.CreateSQLiteDirAndDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            // Criação da tabela
            try
            {
                LocalDB.CreateSQLiteTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            await ProcessData(list, progress);
            label_Status.Text = "Tudo pronto!";
        }

        // Timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            progress_Panel.Width += 2;
            if(progress_Panel.Width >= 800)
            {
                Timer1.Stop();

                int RowsLine = LocalDB.SizeRowsDB();

                if (RowsLine == 0)
                {
                    goToLogin = new Thread(ControlAcessForm);
                    goToLogin.SetApartmentState(ApartmentState.STA);
                    goToLogin.Start();

                    this.Close();
                }
                else
                {
                    goToDBConnectionSettings = new Thread(ToDBConnectionSettingsForm);
                    goToDBConnectionSettings.SetApartmentState(ApartmentState.STA);
                    goToDBConnectionSettings.Start();

                    this.Close();
                }
            }
        }

        private void ControlAcessForm(object obj)
        {
            Application.Run(new DBConnectionSettingForm());
        }

        private void ToDBConnectionSettingsForm(object obj)
        {
            Application.Run(new LoginForm());
        }
    }
}
