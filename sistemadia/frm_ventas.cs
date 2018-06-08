using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bControl;
namespace sistemadia
{
    public partial class frm_ventas : Form
    {
        public frm_ventas()
        {
            InitializeComponent();
        }

        private void frm_ventas_Load(object sender, EventArgs e)
        {
            VENTASDETALLE venta = new VENTASDETALLE();
            GridVw_producto.DataSource= venta.listaven();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable ds;
            VENTASDETALLE nombre = new VENTASDETALLE();
            ds = nombre.buscarventas(dateTimePicker1.Text,dateTimePicker2.Text);
            GridVw_producto.DataSource = ds;
        }
        decimal totalidad;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            totalidad = 0;
            foreach (DataGridViewRow fila in GridVw_producto.Rows)
            {
                totalidad += Convert.ToDecimal(fila.Cells[3].Value)* Convert.ToDecimal(fila.Cells[4].Value);



            }
            txtcalcular.Text = "$" + totalidad.ToString("N2");
        }
    }
}
