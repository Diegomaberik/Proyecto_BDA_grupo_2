using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CView
{
    public partial class frm2Cli : Form
    {
        private C_Cliente cliente = new C_Cliente();
        private int posicion = 0;
        private int maximo = 0;
        private bool nuevo = false;
        private DataTable registros;

        public frm2Cli()
        {
            InitializeComponent();
        }

        private void CargarRegistros()
        {

            {
                try
                {
                    registros = new DataTable();
                    registros = cliente.GetClientes();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar registros: " + ex.Message);
                }
            }
        }

        private void frm2Cli_Load(object sender, EventArgs e)
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
                MessageBox.Show("Ha ocurrido un error (load): " + ex.Message);
            }

        }

        private int cargaDatos(int indice)
        {
            Console.WriteLine(indice);
            int resp = 0;
            try
            {
                DataRow fila = registros.Rows[indice];
                if (fila[0] != null && fila[0] != DBNull.Value)
                {
                    var ccli = cliente.GetCliente(fila[0].ToString());
                    if (ccli != null)
                    {
                        // Carga datos 
                        txtcod.Text = ccli.Id;
                        txtnom.Text = ccli.Nombre;
                        txtced.Text = ccli.Cedula;
                        txtdir.Text = ccli.Direccion;
                        txttel.Text = ccli.Telefono;
                        txtcor.Text = ccli.Correo;
                        resp = 1;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente con el ID proporcionado.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del cliente es nulo o inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (cargadatos) : " + ex.Message);
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
            txtnom.Text = string.Empty;
            txtced.Text = string.Empty;
            txtdir.Text = string.Empty;
            txttel.Text = string.Empty;
            txtcor.Text = string.Empty;
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
                MessageBox.Show("Ha ocurrido un error (back): " + ex.Message);
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
                MessageBox.Show("Ha ocurrido un error (next): " + ex.Message);
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
                    string id = txtcod.Text;
                    cliente.EliminaCliente(id);
                    MessageBox.Show("Cliente eliminado");
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
                C_Cliente cli = new C_Cliente();

                cli.Cedula = txtced.Text;
                cli.Nombre = txtnom.Text;
                cli.Direccion = txtdir.Text;
                cli.Telefono = txttel.Text;
                cli.Correo = txtcor.Text;

                if (nuevo)
                {
                    cliente.CreaCliente(cli);
                    MessageBox.Show("Cliente Creado con éxito");
                    CargarRegistros();
                    maximo = registros.Rows.Count;
                    posicion = maximo - 1;
                }
                else
                {
                    cli.Id = txtcod.Text;
                    cliente.EditaCliente(cli);
                    MessageBox.Show("Cliente Actualizado con éxito");
                }

                btnexit_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (save) : " + ex.Message);
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
            if (txtced.Text.Length == 0) return false;
            if (txtnom.Text.Length == 0) return false;
            if (txtdir.Text.Length == 0) return false;
            if (txttel.Text.Length == 0) return false;
            if (txtcor.Text.Length == 0) return false;
            return true;
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // 8 es el código para la tecla Backspace
            {
                e.Handled = true; // Cancela la entrada si no es un número
            }
        }

        private void txtced_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // 8 es el código para la tecla Backspace
            {
                e.Handled = true; // Cancela la entrada si no es un número
            }
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


        private void txtdir_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, números, tildes, la ñ y la tecla de retroceso
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8 &&
               !("áéíóúÁÉÍÓÚñÑ".Contains(e.KeyChar.ToString())) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada si no es un carácter permitido
            }
        }
        private void txtcor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números, caracteres especiales de correo y tecla de retroceso
            string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";

            if (!caracteresPermitidos.Contains(e.KeyChar) && e.KeyChar != (char)8) // (char)8 es tecla de retroceso
            {
                e.Handled = true; // Cancela la entrada si no es un carácter permitido
            }

        }
    }
}
