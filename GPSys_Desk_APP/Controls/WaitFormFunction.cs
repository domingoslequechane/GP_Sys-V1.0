using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GPSys_Desk_APP.Views;
using GPSys_Desk_APP.Controls;
using System.Windows.Forms;

namespace GPSys_Desk_APP.Controls
{
    public class WaitFormFunction
    {
        WaitForm wait;
        Thread loadingtread;

        public void Show()
        {
            loadingtread = new Thread(new ThreadStart(LoadingPorcess));
            loadingtread.Start();
        }
        
        public void Show(Form parent)
        {
            loadingtread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadingtread.Start(parent);
        }
        public void Close()
        {
            if (wait != null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWaitForm));
                wait = null;
                loadingtread = null;
            }
        }

        private void LoadingPorcess()
        {
            wait = new WaitForm();
            wait.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new WaitForm(parent1);
            wait.ShowDialog();
        }
    }
}
