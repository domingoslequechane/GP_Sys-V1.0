using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CamadaDeDados;
using CamadaDeEntidades;

namespace CamadaDeNegocio
{
    public class ClassNegocio
    {
        ClassDados objd = new ClassDados();

        // LISTAR
        public DataTable N_listar_clientes()
        {
            return objd.D_listar_clientes();
        }

        public DataTable N_listar_pedidos()
        {
            return objd.D_listar_pedidos();
        }

        public DataTable N_listar_ordens()
        {
            return objd.D_listar_ordens();
        }

        // BUSCAR
        public DataTable N_buscar_clientes(ClassEntidade obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        public DataTable N_buscar_ordens(ClassEntidade obje)
        {
            return objd.D_buscar_ordens(obje);
        }

        // APAGAR
        public String N_manutencao_clientes(ClassEntidade obje)
        {
            return objd.D_manutencao_clientes(obje);
        }



        /*

        

        public String GPmanutencao_Cliente(ClassEntidade obje)
        {
            return objd.D_manutencao_clientes(obje);
        }


        // tbl_Cliente
        public DataTable GPmostrar_Cliente()
        {
            return objd.D_listar_clientes();
        }

        public DataTable GPbuscar_Cliente(ClassEntidade obje)
        {
            return objd.D_buscar_clientes(obje);
        }

        public String GPmanutencao_Cliente(ClassEntidade obje)
        {
            return objd.D_manutencao_clientes(obje);
        }

        */
    }
}
