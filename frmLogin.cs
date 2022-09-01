﻿using Proyecto.Modelo;
using ProyectoVenta.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ouo.io/RK1tRH");
        }

        

        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            this.Show();
            txtusuario.Focus();
        }

        

        private void btningresar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            bool encontrado = false;

            if (txtusuario.Text == "administrador" && txtclave.Text == "13579123")
            {
                int respuesta = UsuarioLogica.Instancia.resetear();
                if (respuesta > 0)
                {
                    MessageBox.Show("La cuenta fue restablecida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                List<Usuario> ouser = UsuarioLogica.Instancia.Listar(out mensaje);
                encontrado = ouser.Any(u => u.NombreUsuario == txtusuario.Text && u.Clave == txtclave.Text);

                if (encontrado)
                {
                    Usuario objuser = ouser.Where(u => u.NombreUsuario == txtusuario.Text && u.Clave == txtclave.Text).FirstOrDefault();

                    Inicio frm = new Inicio();
                    frm.NombreUsuario = objuser.NombreUsuario;
                    frm.Clave = objuser.Clave;
                    frm.NombreCompleto = objuser.NombreCompleto;
                    frm.FechaHora = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    frm.oPermisos = PermisosLogica.Instancia.Obtener(objuser.IdPermisos);
                    frm.Show();
                    this.Hide();
                    frm.FormClosing += Frm_Closing;
                }
                else
                {
                    if (string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show("No se encontraron coincidencias del usuario", "Mensaje C.E.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}