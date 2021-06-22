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
    public partial class ClientsUserControlForm : UserControl
    {
        Thread editClient;

        ClassNegocio objneg = new ClassNegocio();
        ClassEntidade objent = new ClassEntidade();

        public ClientsUserControlForm()
        {
            InitializeComponent();
        }

        // COMPONENTES
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            TextBox_Search.Focus();
            TextBox_Search.SelectAll();
        }
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            editClient = new Thread(UpdateClient);
            editClient.SetApartmentState(ApartmentState.STA);
            editClient.Start();
        }
        private void UpdateClient(object obj)
        {
            Application.Run(new ClientsUpdateForm());
        }



        void manutencao(String action)
        {
            //objent.Id_cli = 
        }

        private void ClientsUserControlForm_Load(object sender, EventArgs e)
        {
            TextBox_Search.Focus();
            DataGridView.DataSource = objneg.N_listar_clientes();
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Search.Text != "")
                {
                    objent.Nome_do_Cliente = TextBox_Search.Text;
                    DataTable dt = new DataTable();
                    dt = objneg.N_buscar_clientes(objent);
                    DataGridView.DataSource = dt;
                }
                else
                {
                    DataGridView.DataSource = objneg.N_listar_clientes();
                }
            }
            catch
            {
                DataGridView.DataSource = objneg.N_listar_clientes();
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    objent.Nome_do_Cliente = TextBox_Search.Text;
            //    DataTable dt = new DataTable();
            //    dt = objneg.N_buscar_clientes(objent);
            //    DataGridView.DataSource = dt;

            //    DataGridView.DataSource = objneg.N_listar_clientes();
            //}
            //catch
            //{
            //DataGridView.DataSource = objneg.N_apagar_cliente();
            DataGridView.DataSource = objneg.N_listar_clientes();
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
