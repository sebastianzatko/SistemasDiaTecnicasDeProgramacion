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
using System.Data.SqlClient;
namespace sistemadia
{
    public partial class frm_Producto : Form
    {
        public frm_Producto()
        {
            InitializeComponent();
        }
        
        private void Producto_Load(object sender, EventArgs e)
        {

            DataTable ds;
            Listaprod nombre = new Listaprod();
            ds = nombre.productolist();
            GridVw_producto.DataSource = ds;

        }
        SqlConnection con = new SqlConnection("Data Source=TCL;Initial Catalog=pruebasistema;Integrated Security=True");

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                bControl.Listaprod pro = new bControl.Listaprod();

                pro.Agregar(nombreproductotxt.Text, disponibilidadtxt.Text, preciotxt.Text, tipotxt.Text);
                

                    MessageBox.Show("Se ha creado un nuevo producto");
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("No se a podido crear producto"+erro);
            }
        }

        private void GridVw_producto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.GridVw_producto.Columns[e.ColumnIndex].Name == "DISPONIBILIDAD")
            {
                if (Convert.ToInt32(e.Value) <= 400)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Green;
                    if (Convert.ToInt32(e.Value) <= 100)
                    {
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.BackColor = Color.Yellow;
                        if (Convert.ToInt32(e.Value) <= 50)
                        {
                            e.CellStyle.ForeColor = Color.Black;
                            e.CellStyle.BackColor = Color.Red;

                        }

                    }
                }
            }
        }
    }
}
