using bControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemadia
{
    public partial class frm_empleados : Form
    {
        public frm_empleados()
        {
            InitializeComponent();
            comboBox1.Items.Add("Administrativo");
            comboBox1.Items.Add("Vendedor");
            comboBox1.Items.Add("Gerente");
            comboBox1.Items.Add("Control Stock");
            comboBox1.Items.Add("Cargado de productos");
            

        }

        private void empleados_Load(object sender, EventArgs e)
        {
            DataTable ds;
            Usuario user = frm_menuPrincipal.user;
            ds = user.listarusuarios();
            GridVw_usuariosregistrados.DataSource = ds;
            txtbox_newuserdni.Focus();
            txtbox_newuserpassword.isPassword = true;
        }

        

        private void Guardar_Click(object sender, EventArgs e)
        {
            string dni;
            string contra;
            string nombre;
            string apellido;
            dni = txtbox_newuserdni.Text;
            contra = txtbox_newuserpassword.Text;
            nombre = txtbox_newusernombre.Text;
            apellido = txtbox_newuserapellido.Text;
            if (dni == "" && contra == "" && nombre == "" && apellido == "")
            {
                MessageBox.Show("ERROR  TEXTOS VACIOS", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Usuario ur = new Usuario();
                ur.crearnuevousuario(txtbox_newuserdni.Text, txtbox_newuserpassword.Text, txtbox_newusernombre.Text, txtbox_newuserapellido.Text, comboBox1.Text);
                MessageBox.Show("se creo un nuevo usuario");
                DataTable ds;
                Usuario user = frm_menuPrincipal.user;
                ds = user.listarusuarios();
                GridVw_usuariosregistrados.DataSource = ds;
                //No se como refrescar el gridview sin que sea medio tosco :(
            }
        }

        private void txtbox_newuserdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumero(e);
            
        }

        private void txtbox_newusernombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtbox_newuserapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void txtbox_newuserpassword_OnValueChanged(object sender, EventArgs e)
        {
            txtbox_newuserpassword.isPassword = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Blue;
           
        }
    }
}
