﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bControl
{
    public class autocompletar
    {
        
        SqlCommand dr;
        SqlDataReader cnr;


        SqlConnection cmm = new SqlConnection("Data Source=TCL;Initial Catalog=pruebasistema;Integrated Security=True");
          



        
        public void AutoCompletar(TextBox cajaTexto)
        {
            try
            {
                dr = new SqlCommand("select NOMBRE from PRODUCTO", cmm);
                cmm.Open();
                cnr = dr.ExecuteReader();
                while (cnr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(cnr["NOMBRE"].ToString());
                }
                cmm.Close();
            }
            catch (Exception con)
            {
                MessageBox.Show("no se pudo autocompletar" + con.ToString());
            }
        }

    }
}
