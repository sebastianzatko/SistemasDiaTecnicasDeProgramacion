﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDatos
{
    public class DALCliente
    {
        cDatos.Conexion conexion = new cDatos.Conexion();

        public DataTable listar_Clientes()
        {
            string consulta = "SELECT ID_CLIENTE,NOMBRE,APELLIDO,EMAIL,TIPO FROM CLIENTE WHERE HABILITADO=1";
            DataTable clientes = conexion.LeerPorComando(consulta);
            return clientes;
        }
        public void guardar_Cliente(string nombre,string apellido,string email,string tipo)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0]= conexion.crearParametro("@NOMBRE",nombre);
            parametros[1]= conexion.crearParametro("@APELLIDO",apellido);
            parametros[2]= conexion.crearParametro("@EMAIL",email);
            parametros[3]= conexion.crearParametro("@TIPO",tipo);
            conexion.EscribirPorStoreProcedure("CREAR_CLIENTE",parametros);
        }
        public void modificar_Cliente(int id_cliente,string nombre,string apellido,string email,string tipo)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0]= conexion.crearParametro("@ID_CLIENTE",id_cliente);
            parametros[1]= conexion.crearParametro("@NOMBRE",nombre);
            parametros[2]= conexion.crearParametro("@APELLIDO",apellido);
            parametros[3]= conexion.crearParametro("@EMAIL",email);
            parametros[4]= conexion.crearParametro("@TIPO",tipo);
            conexion.EscribirPorStoreProcedure("MODIFICAR_CLIENTE",parametros);
        }
        public void eliminar_Cliente(int id_cliente)
        {
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = conexion.crearParametro("@ID_CLIENTE",id_cliente);
            conexion.EscribirPorStoreProcedure("ELIMINAR_CLIENTE",parametro);
        }
    }
}
