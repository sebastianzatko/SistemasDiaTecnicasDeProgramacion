using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDatos;
using System.Data;

namespace bControl
{
   public class VENTASDETALLE
    {
        cDatos.Ventaspro conxeventas = new cDatos.Ventaspro();
        private int int_ventas;
        public int Int_ventas
        {
            get { return int_ventas; }
            set { int_ventas = value; }
        }

       
       public void Agregarventa(string vendedor, string cliente, string fecha)
        {

            conxeventas.ventas(vendedor,cliente,fecha);



        }
        public void ventapro(string idventa, string producto, string cantidad)
        {

            conxeventas.ventasPRO(idventa,producto,cantidad);



        }

       
        public DataTable listaven()
        {
            DataTable tablaven = conxeventas.listaventas();
            return tablaven;
        }
        public DataTable buscarventas(string textb,string boxt)
        {
            DataTable tablaproducto = conxeventas.BUSCAR(textb,boxt);
            return tablaproducto;

        }
    }
}
