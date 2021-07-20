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

            TB_ClientName.Focus();

            CB_ClientCity.SelectedIndex = 0;
        }

        void manutencao(string action)
        {
            objent.Nome_do_Cliente = TB_ClientName.Text;
            objent.Morada = TB_ClientAddress.Text;
            objent.Cell = TB_ClientContactNumber.Text;
            objent.Email = TB_ClientEmail.Text;
            objent.Cidade = CB_ClientCity.Text;

            objent.Data_entrada = DT_In.Text;
            objent.Cod_Serv = DT_Out.Text;
            objent.Nota = TextBox_Note.Text;
            objent.Acao = action;
            String men = objneg.N_manutencao_clientes(objent);
            MessageBox.Show(men, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpar()
        {
            TB_ClientName.Text = "";
            TB_ClientAddress.Text = "";
            TB_ClientContactNumber.Text = "";
            TB_ClientEmail.Text = "";
            objent.Cidade = CB_ClientCity.Text = "";

            DT_In.Text = "";
            DT_Out.Text = "";
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
