using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using bControl;

namespace sistemadia
{
    public partial class frm_Proveedores : Form
    {
        public frm_Proveedores()
        {
            InitializeComponent();
        }

        bControl.Proveedor proveedor = new bControl.Proveedor();
        public static void solonumero(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("solo numero","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //.Text trae el contenido y .ToString() lo transforma en string
            string telefono;
            string mail;
            string nombre;
            string direcion;

            nombre = txtbox_Nombre.Text;
            telefono = txtbox_Telefono.Text;
            direcion = txtbox_Direccion.Text;
            mail = txtbox_Email.Text;
            if (nombre == "" && telefono == "" && mail == "" && direcion == "")
            {
                MessageBox.Show("ERROR  TEXTOS VACIOS", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
            else
            {

                proveedor.agregar_Proveedor(txtbox_Nombre.Text.ToString(), txtbox_Telefono.Text.ToString(), txtbox_Direccion.Text.ToString(), txtbox_Email.Text.ToString());

                MessageBox.Show("Proveedor fue creado correctamente"); //MessageBox es un objeto (formulario chiquitito)
                dtView_proveedores.DataSource = proveedor.obtener_Proveedores();

            }




        }

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            dtView_proveedores.DataSource = proveedor.obtener_Proveedores();
            txtbox_Nombre.Focus();

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_Email_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtbox_Email_Leave(object sender, EventArgs e)
        {
            string mail = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))";
            if (Regex.IsMatch(txtbox_Email.Text, mail))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtbox_Email, "error mail");
                return;
            }
        }

        private void txtbox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumero(e);
        }

        private void txtbox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}

