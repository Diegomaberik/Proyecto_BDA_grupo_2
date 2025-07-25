﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNego;
using CData;
using Microsoft.Win32;

namespace CView
{
    public partial class frm2Pro : Form
    {
        private C_Producto producto = new C_Producto();
        private int posicion = 0;
        private int maximo = 0;
        private bool nuevo = false;
        private DataTable registros;

        public frm2Pro()
        {
            InitializeComponent();
        }

        private void CargarRegistros()
        {

            {
                try
                {
                    registros = new DataTable();
                    registros = producto.GetProductos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar registros: " + ex.Message);
                }
            }
        }

        private void frm2Pro_Load(object sender, EventArgs e)
        {

            try
            {

                CargarRegistros();

                maximo = registros.Rows.Count;

                if (maximo > 0)
                {
                    cargaDatos(0);
                    btnbck.Enabled = true;
                    btnnxt.Enabled = true;
                    btndel.Visible = true;
                    btnedit.Visible = true;
                }
                else
                {
                    btnbck.Enabled = false;
                    btnnxt.Enabled = false;
                    btndel.Visible = false;
                    btnedit.Visible = false;
                }

                btnnew.Visible = true;
                btnsave.Visible = false;
                btnexit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private int cargaDatos(int indice)
        {
            int resp = 0;
            try
            {
                DataRow fila = registros.Rows[indice];
                var cpro = producto.GetProducto(Convert.ToInt32(fila[0]));
                // Carga datos 
                txtcod.Text = Convert.ToString(cpro.Id);
                txtnom.Text = cpro.Descri;
                txtref.Text = cpro.Refere;
                txtmar.Text = cpro.Marca;
                nmcosto.Value = cpro.Prccpa;
                nmstock.Value = cpro.Cantid;
                nmvalor.Value = cpro.Prcvta;
                resp = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
            return resp;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Visible = false;
            btnsave.Visible = true;
            btnexit.Visible = true;
            btnbck.Visible = false;
            btnnxt.Visible = false;
            btndel.Visible = false;
            btnedit.Visible = false;
            gb1.Enabled = true;
            //txtcod.Text = Convert.ToString(ser_cnt.getNextCod());
            txtnom.Text = string.Empty;
            txtref.Text = string.Empty;
            txtmar.Text = string.Empty;
            nmvalor.Value = 1;
            nmcosto.Value = 1;
            nmstock.Value = 0;
            txtnom.Focus();
            nuevo = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            //Editar
            btnedit.Visible = false;
            btndel.Visible = false;
            btnnew.Visible = false;
            btnbck.Visible = false;
            btnnxt.Visible = false;
            btnsave.Visible = true;
            btnexit.Visible = true;
            gb1.Enabled = true;
            txtnom.Focus();

        }

        private void btnbck_Click(object sender, EventArgs e)
        {
            try
            {
                //Retrocede
                posicion--;
                if (posicion < 0)
                {
                    posicion = 0;
                    return;
                }
                cargaDatos(posicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnnxt_Click(object sender, EventArgs e)
        {
            try
            {
                //Avanza
                posicion++;
                if (posicion >= maximo)
                {
                    posicion = maximo - 1;
                    return;
                }
                cargaDatos(posicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (cargadatos): " + ex.Message);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            //Elimina
            DialogResult result = MessageBox.Show("¿Está seguro de que desea continuar?", "Confirmar Acción", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(txtcod.Text);
                    producto.EliminaProducto(id); 
                    MessageBox.Show("Producto eliminado");
                    maximo--;
                    if (maximo >= 0)
                    {
                        posicion = 0;
                    }

                    btnexit_Click(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error(btndel): " + ex.Message);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatos())
                {
                    MessageBox.Show("Debe llenar todos los campos para poder Grabar");
                    return;
                }

                //Graba
                C_Producto pro = new C_Producto();

                pro.Descri = txtnom.Text;
                pro.Refere = txtref.Text;
                pro.Marca = txtmar.Text;
                pro.Prccpa = nmcosto.Value;
                pro.Cantid = Convert.ToInt32(nmstock.Value);
                pro.Prcvta = nmvalor.Value;

                if (nuevo)
                {
                    producto.CreaProducto(pro);
                    MessageBox.Show("Producto Creado con éxito");
                    CargarRegistros();
                    maximo = registros.Rows.Count;
                    posicion = maximo - 1;
                }
                else
                { 
                    pro.Id = int.Parse(txtcod.Text);               
                    producto.EditaProducto(pro);
                    MessageBox.Show("Producto Actualizado con éxito");
                }

                btnexit_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error(btnsave): " + ex.Message);
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            //Salida
            btnexit.Visible = false;
            btnsave.Visible = false;
            btnnew.Visible = true;
            btnbck.Visible = true;
            btnnxt.Visible = true;
            gb1.Enabled = false;
            nuevo = false;
            if (maximo >= 0)
            {
                btnedit.Visible = true;
                btndel.Visible = true;
                cargaDatos(posicion);
            }


        }

        private bool ValidarDatos()
        {
            //if (txtcod.Text.Length == 0) return false;
            if (txtnom.Text.Length == 0) return false;
            if (txtref.Text.Length == 0) return false;
            if (txtmar.Text.Length == 0) return false;
            if (nmvalor.Value == 0) return false;
            if (nmcosto.Value == 0) return false;
            if (nmcosto.Value > nmvalor.Value) return false;
            return true;
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, números, tildes, la ñ y la tecla de retroceso
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8 &&
                !("áéíóúÁÉÍÓÚñÑ".Contains(e.KeyChar.ToString())) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada si no es un carácter permitido
            }
        }

        private void txtref_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, números, tildes, la ñ y la tecla de retroceso
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8 &&
                !("áéíóúÁÉÍÓÚñÑ".Contains(e.KeyChar.ToString())) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada si no es un carácter permitido
            }
        }
        private void txtmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, números, tildes, la ñ y la tecla de retroceso
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8 &&
                !("áéíóúÁÉÍÓÚñÑ".Contains(e.KeyChar.ToString())) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada si no es un carácter permitido
            }
        }

    }
}
