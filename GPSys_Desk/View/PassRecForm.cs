using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GPSys_Desk
{
    public partial class PassRecForm : Form
    {
        Thread newFormError;
        Thread newFormAccept;

        public PassRecForm()
        {
            InitializeComponent();
        }

        private void link_RecCodErrorForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            newFormError = new Thread(novoFormularioError);
            newFormError.SetApartmentState(ApartmentState.STA);
            newFormError.Start();
        }

        private void novoFormularioError(object obj)
        {
            Application.Run(new View.RecCodErrorForm());
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            if(textBox_Pass.Text == "12345")
            {
                this.Close();
                newFormAccept = new Thread(novoFormularioAccept);
                newFormAccept.SetApartmentState(ApartmentState.STA);
                newFormAccept.Start();
            }
            else
            {
                label_CodigoIncorrecto_Info1.Text = "Código incorrecto,";
                label_CodigoIncorrecto_Info2.Text = "tente novamente!";
            }
        }

        private void novoFormularioAccept(object obj)
        {
            Application.Run(new View.NewPassForm());
        }
    }
}
