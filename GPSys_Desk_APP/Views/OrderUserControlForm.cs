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

using CamadaDeEntidades;
using CamadaDeNegocio;

namespace GPSys_Desk_APP.Views
{
    public partial class OrderUserControlForm : UserControl
    {
        ClassNegocio objneg = new ClassNegocio();
        ClassEntidade objent = new ClassEntidade();

        Thread addOrder, editOrder;
        public OrderUserControlForm()
        {
            InitializeComponent();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            TextBox_Search.Focus();
            TextBox_Search.SelectAll();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            editOrder = new Thread(UpdateOder);
            editOrder.SetApartmentState(ApartmentState.STA);
            editOrder.Start();
        }

        private void UpdateOder(object obj)
        {
            Application.Run(new OrderUpdateForm());
        }

        private void OrderUserControlForm_Load(object sender, EventArgs e)
        {
            TextBox_Search.Focus();
            DataGridView.DataSource = objneg.N_listar_ordens();
        }

        private void AddOrder_btn_Click(object sender, EventArgs e)
        {
            addOrder = new Thread(NewOder);
            addOrder.SetApartmentState(ApartmentState.STA);
            addOrder.Start();
        }

        private void NewOder(object obj)
        {
            Application.Run(new NewOrderForm());
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Search.Text != "")
                {
                    objent.Id_Ord = TextBox_Search.Text;
                    DataTable dt = new DataTable();
                    dt = objneg.N_buscar_ordens(objent);
                    DataGridView.DataSource = dt;
                }
                else
                {
                    DataGridView.DataSource = objneg.N_listar_ordens();
                }
            }
            catch
            {
                DataGridView.DataSource = objneg.N_listar_ordens();
            }
        }




        void manutencao(string action)
        {
            objent.Acao = action;
            String men = objneg.N_manutencao_clientes(objent);
            MessageBox.Show(men, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpar()
        {
            ID.Text = "";
            comboBox1.Text = "";

            DataGridView.DataSource = objneg.N_listar_pedidos();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            manutencao("delete");
            limpar();
        }
    }
}
