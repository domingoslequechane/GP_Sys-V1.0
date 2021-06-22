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
    public partial class OrderUpdateForm : Form
    {
        ClassEntidade objent = new ClassEntidade();
        ClassNegocio objneg = new ClassNegocio();

        public OrderUpdateForm()
        {
            InitializeComponent();
        }

        void manutencao(string action)
        {
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
            DateTimePicker_In.Text = "";
            DateTimePicker_Out.Text = "";
            TextBox_Quantity.Text = "";
            Label_UnpaidAmount.Text = "";
            TextBox_PaidAmount.Text = "0000";
            TextBox_Note.Text = "";

            DataGridView.DataSource = objneg.N_listar_pedidos();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            manutencao("insert");
            limpar();
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            manutencao("update");
            limpar();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView.DataSource = objneg.N_listar_pedidos();

            int fila = DataGridView.CurrentCell.RowIndex;

            DateTimePicker_In.Text = DataGridView[0,fila].Value.ToString();
            DateTimePicker_Out.Text = DataGridView[1, fila].Value.ToString();
            TextBox_Quantity.Text = DataGridView[2, fila].Value.ToString();
            Label_UnpaidAmount.Text = DataGridView[3, fila].Value.ToString();
            TextBox_PaidAmount.Text = DataGridView[4, fila].Value.ToString();
            TextBox_Note.Text = DataGridView[5, fila].Value.ToString();
        }

        private void OrderUpdateForm_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = objneg.N_listar_pedidos();
        }
    }
}
