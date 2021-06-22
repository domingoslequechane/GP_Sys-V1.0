using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CamadaDeEntidades;
using CamadaDeNegocio;

namespace GPSys_Desk_APP.Views
{
    public partial class NewOrderForm : Form
    {
        ClassEntidade objent = new ClassEntidade();
        ClassNegocio objneg = new ClassNegocio();
        public NewOrderForm()
        {
            InitializeComponent();
            TextBox_ClientName.Focus();
        }

        void manutencao(string action)
        {
            objent.Nome_do_Cliente = TextBox_ClientName.Text;
            objent.Nuit = TextBox_ClientNuitNumber.Text;
            objent.Morada = TextBox_ClientAddress.Text;
            objent.Cell = TextBox_ClientContactNumber.Text;
            objent.Email = TextBox_ClientEmail.Text;
            objent.Cidade = ComboBox_ClientCity.Text;

            objent.Data_entrada = DateTimePicker_In.Text;
            objent.Cod_Serv = DateTimePicker_Out.Text;
            objent.Quantidade = TextBox_Quantity.Text;
            objent.Total_a_pagar = Label_UnpaidAmount.Text;
            objent.Total_pago = TextBox_PaidAmount.Text;
            objent.Nota = TextBox_Note.Text;
            objent.Acao = action;
            String men = objneg.N_manutencao_clientes(objent);
            MessageBox.Show(men, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpar()
        {
            TextBox_ClientName.Text = "";
            TextBox_ClientNuitNumber.Text = "";
            TextBox_ClientAddress.Text = "";
            TextBox_ClientContactNumber.Text = "";
            TextBox_ClientEmail.Text = "";
            objent.Cidade = ComboBox_ClientCity.Text = "";

            DateTimePicker_In.Text = "";
            DateTimePicker_Out.Text = "";
            TextBox_Quantity.Text = "";
            Label_UnpaidAmount.Text = "";
            TextBox_PaidAmount.Text = "0000";
            TextBox_Note.Text = "";

            DataGridView.DataSource = objneg.N_listar_pedidos();
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = objneg.N_listar_pedidos();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            manutencao("insert");
            limpar();
        }
    }
}
