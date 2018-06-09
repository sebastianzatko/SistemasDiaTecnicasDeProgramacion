﻿using System;
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
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {


                if (user.ingresar(usertxt.Text.ToString(), contraseñatxt.Text.ToString()))
                {

                    frm_menuPrincipal menuprincipal = new frm_menuPrincipal();
                    menuprincipal.FormClosed += new FormClosedEventHandler(menuprincipal_FormClosed);
                    menuprincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El login es incorrecto");
                }
            }
            catch (Exception ERR)
            {
                MessageBox.Show("error" + ERR);

            }
        }

        void menuprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            usertxt.Text = " ";
            contraseñatxt.Text = " ";
            
    }

       

        private void usertxt_MouseEnter(object sender, EventArgs e)
        {
            
            usertxt.ForeColor = Color.Black;
        }

        

       

        private void bunifuThinButton21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {


                    if (user.ingresar(usertxt.Text.ToString(), contraseñatxt.Text.ToString()))
                    {

                        frm_menuPrincipal menuprincipal = new frm_menuPrincipal();
                        menuprincipal.FormClosed += new FormClosedEventHandler(menuprincipal_FormClosed);
                        menuprincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El login es incorrecto");
                    }
                }
                catch (Exception ERR)
                {
                    MessageBox.Show("error" + ERR);

                }
            }
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {


                    if (user.ingresar(usertxt.Text.ToString(), contraseñatxt.Text.ToString()))
                    {

                        frm_menuPrincipal menuprincipal = new frm_menuPrincipal();
                        menuprincipal.FormClosed += new FormClosedEventHandler(menuprincipal_FormClosed);
                        menuprincipal.Show();
                        this.Hide();
                    }
                    else
                    {
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
}

