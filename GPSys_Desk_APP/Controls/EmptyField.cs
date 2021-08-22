using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSys_Desk_APP.Controls
{
    public class EmptyField
    {
        public bool Field(Control controller, string field)
        {
            if(controller.Text == "")
            {
                MessageBox.Show("Por favor, informe o " + field, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controller.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
