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
    public partial class frm2Tec : Form
    {
        private C_Tecnico tecnico = new C_Tecnico();
        private int posicion = 0;
        private int maximo = 0;
        private bool nuevo = false;
        private DataTable registros;

        public frm2Tec()
        {
            InitializeComponent();
        }

        private void CargarRegistros()
        {

            {
                try
                {
                    registros = new DataTable();
                    registros = tecnico.GetTecnicos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar registros: " + ex.Message);
                }
            }
        }

        private void frm2Tec_Load(object sender, EventArgs e)
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
            int resp = 0;
            try
            {
                DataRow fila = registros.Rows[indice];
                if (fila[0] != null && fila[0] != DBNull.Value && !string.IsNullOrWhiteSpace(fila[0].ToString()))
                {
                    var ctec = tecnico.GetTecnico(fila[0].ToString());
                    // Carga datos 
                    txtcod.Text = ctec.Id;
                    txtnom.Text = ctec.Nombre;
                    txtced.Text = ctec.Cedula;
                    txtdir.Text = ctec.Direccion;
                    txttel.Text = ctec.Telefono;
                    txtcor.Text = ctec.Correo;
                    resp = 1;
                }
                else
                {
                    MessageBox.Show("El identificador del técnico es nulo o vacío.");
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
                    tecnico.EliminaTecnico(txtcod.Text);
                    MessageBox.Show("Tecnico eliminado");
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
                C_Tecnico tec = new C_Tecnico();

                tec.Cedula = txtced.Text;
                tec.Nombre = txtnom.Text;
                tec.Direccion = txtdir.Text;
                tec.Telefono = txttel.Text;
                tec.Correo = txtcor.Text;

                if (nuevo)
                {
                    tecnico.CreaTecnico(tec);
                    MessageBox.Show("Tecnico Creado con éxito");
                    CargarRegistros();
                    maximo = registros.Rows.Count;
                    posicion = maximo - 1;
                }
                else
                {
                    tec.Id = txtcod.Text;
                    tecnico.EditaTecnico(tec);
                    MessageBox.Show("Tecnico Actualizado con éxito");
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
