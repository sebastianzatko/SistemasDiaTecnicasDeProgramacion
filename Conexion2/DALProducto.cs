﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cDatos
{
    public class DALProducto
    {
        cDatos.Conexion conexionpro = new cDatos.Conexion();
        public bool comprobarexistente1(string producto)
        {
            string comprobarexistente = String.Format("SELECT NOMBRE FROM PRODUCTO WHERE NOMBRE='{0}' AND HABILITADO=1", producto);
            DataTable tabladeexistentes = conexionpro.LeerPorComando(comprobarexistente);
            int numeroDeExistentes = tabladeexistentes.Rows.Count;
            if (numeroDeExistentes == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        public DataTable obtenerproducto()
        {
            string consulta = "SELECT NOMBRE,DISPONIBILIDAD,PRECIO,TIPO FROM PRODUCTO WHERE HABILITADO=1";
            DataTable resultado = conexionpro.LeerPorComando(consulta);
            return resultado;
        }
        public void insertarproducto(string NOMBRE,string DISPONIBILIDAD, string PRECIO, string TIPO)
        {
            Int64 dni;
            Int64.TryParse(DISPONIBILIDAD, out dni);
            Decimal pre;
            Decimal.TryParse(PRECIO, out pre);

            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = conexionpro.crearParametro("@NOMBRE", NOMBRE);
            parametros[1] = conexionpro.crearParametro("@DISPONIBILIDAD", DISPONIBILIDAD);
            parametros[2] = conexionpro.crearParametro("@PRECIO", PRECIO);
            parametros[3] = conexionpro.crearParametro("@TIPO", TIPO);

            conexionpro.EscribirPorStoreProcedure("CARGAPRODUCTO", parametros);
            
        }
    }
}
