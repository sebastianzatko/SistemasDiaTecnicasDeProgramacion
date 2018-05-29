using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using bControl;

namespace sistemadia
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        

        public static bControl.Usuario user = new bControl.Usuario();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (user.ingresar(txtbox_dni.Text.ToString(), txtbox_pass.Text.ToString()))
                {

                    frm_menuPrincipal men = new frm_menuPrincipal();
                    men.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("El login es incorrecto");
                }
            }
            catch (Exception ERR)
            {
                MessageBox.Show("error" + ERR);

            }

        }

        
    }
}

