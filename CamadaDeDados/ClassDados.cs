using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CamadaDeEntidades;

namespace CamadaDeDados
{
    public class ClassDados
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        // Listar
        public DataTable D_listar_clientes()
        {
            SqlCommand cmd = new SqlCommand("GPlistar_Clientes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_listar_pedidos()
        {
            SqlCommand cmd = new SqlCommand("GPlistar_Pedidos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_listar_ordens()
        {
            SqlCommand cmd = new SqlCommand("GPlistar_Ordens", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Buscar
        public DataTable D_buscar_clientes(ClassEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("GPbuscar_Clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome_do_Cliente", obje.Nome_do_Cliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_ordens(ClassEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("GPbuscar_Ordens", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_ord", obje.Id_Ord);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Manutenção
        public String D_manutencao_clientes(ClassEntidade obje)
        {
            String action = "";
            SqlCommand cmd = new SqlCommand("GPmanutencao_Clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nome_do_Cliente", obje.Nome_do_Cliente);
            cmd.Parameters.AddWithValue("@Nuit", obje.Nuit);
            cmd.Parameters.AddWithValue("@Morada", obje.Morada);
            cmd.Parameters.AddWithValue("@Cell", obje.Cell);
            cmd.Parameters.AddWithValue("@Email", obje.Email);
            cmd.Parameters.AddWithValue("@Cidade", obje.Cidade);
            cmd.Parameters.Add("@Acao", SqlDbType.VarChar, 50).Value = obje.Acao;
            cmd.Parameters["@Acao"].Direction = ParameterDirection.InputOutput;

            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            action = cmd.Parameters["@Acao"].Value.ToString();

            cn.Close();
            return action;
        }

        /*
        

        // Actualizar
        
        */
    }
}
