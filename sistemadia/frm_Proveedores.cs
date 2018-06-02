using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemadia
{
    public partial class frm_Proveedores : Form
    {
        public frm_Proveedores()
        {
            InitializeComponent();
        }

        bControl.Proveedor proveedor = new bControl.Proveedor();

        private void btn_Guardar_Click(object sender, EventArgs e)
        {                                                 //.Text trae el contenido y .ToString() lo transforma en string
            if (proveedor.agregar_Proveedor(txtbox_Nombre.Text.ToString(),txtbox_Telefono.Text.ToString(),txtbox_Direccion.Text.ToString(),txtbox_Email.Text.ToString()))
            {
                MessageBox.Show("Proveedor fue creado correctamente"); //MessageBox es un objeto (formulario chiquitito)
                dtView_proveedores.DataSource = proveedor.obtener_Proveedores();
            }
            else
            {
                MessageBox.Show("Proveedor no fue creado");
            }



        }

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            dtView_proveedores.DataSource = proveedor.obtener_Proveedores();

        }
    }
}
