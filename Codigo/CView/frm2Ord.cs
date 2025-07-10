using CNego;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CView
{
    public partial class frm2Ord : Form
    {
        private C_Cliente cliente = new C_Cliente();
        private C_Tecnico tecnico = new C_Tecnico();
        private C_Orden orden = new C_Orden();
        public frm2Ord()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm2Ord_Load(object sender, EventArgs e)
        {
            try
            {
                CargaClientes();
                CargaTecnicos();
                dtfecing.Value = DateTime.Now;
                txtmar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void CargaClientes()
        {
            try
            {
                cbCli.SelectedIndexChanged -= cbCli_SelectedIndexChanged;

                DataTable dtCli = cliente.GetClientes();
                cbCli.DataSource = dtCli;
                cbCli.DisplayMember = "nombre";
                cbCli.ValueMember = "id";

                if (cbCli.Items.Count > 0)
                {
                    cbCli.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cbCli.SelectedIndexChanged += cbCli_SelectedIndexChanged;
                // Invoca manualmente si quieres cargar el primero:
                cbCli_SelectedIndexChanged(cbCli, EventArgs.Empty);
            }
        }

        private void cbCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCli.SelectedValue == null || cbCli.SelectedValue == DBNull.Value)
                return;

            string idCli = cbCli.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(idCli))
            {
                var cli = cliente.GetCliente(idCli);
                txtclicod.Text = cli.Id;
                txtcliced.Text = cli.Cedula;
                txtclidir.Text = cli.Direccion;
                txtclitel.Text = cli.Telefono;
            }
        }
        private void CargaTecnicos()
        {
            try
            {
                cbTec.SelectedIndexChanged -= cbTec_SelectedIndexChanged;

                DataTable dtTec = tecnico.GetTecnicos();
                cbTec.DataSource = dtTec;
                cbTec.DisplayMember = "nombre";
                cbTec.ValueMember = "id";
                if (cbTec.Items.Count > 0)
                {
                    cbTec.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tecnicos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cbTec.SelectedIndexChanged += cbTec_SelectedIndexChanged;
                // Invoca manualmente si quieres cargar el primero:
                cbTec_SelectedIndexChanged(cbTec, EventArgs.Empty);
            }
        }

        private void cbTec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTec.SelectedValue == null || cbTec.SelectedValue == DBNull.Value)
                    return;
            
            string idTec = cbTec.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(idTec))
            {
                var tec = tecnico.GetTecnico(idTec);
                txtteccod.Text = tec.Id;
                txttecced.Text = tec.Cedula;

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
                var ord = new C_Orden();
                ord.Id_cli = txtclicod.Text;
                ord.Id_tec = txtteccod.Text;
                ord.Marca = txtmar.Text;
                ord.Modelo = txtmod.Text;
                ord.Imei = txtser.Text;
                ord.Observ = txtobs.Text;
                ord.Fecing = dtfecing.Value;
                orden.GrabaOrden(ord);
                MessageBox.Show("Orden Creada con éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (save) : " + ex.Message);
            }
        }
        private bool ValidarDatos()
        {
            if (txtmar.Text.Length == 0) return false;
            if (txtmod.Text.Length == 0) return false;
            if (txtser.Text.Length == 0) return false;
            if (txtobs.Text.Length == 0) return false;
            return true;
        }

        private void txtser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // 8 es el código para la tecla Backspace
            {
                e.Handled = true; // Cancela la entrada si no es un número
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
        private void txtmod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, números, tildes, la ñ y la tecla de retroceso
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8 &&
               !("áéíóúÁÉÍÓÚñÑ".Contains(e.KeyChar.ToString())) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada si no es un carácter permitido
            }
        }
        private void txtobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, números, tildes, la ñ y la tecla de retroceso
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8 &&
               !("áéíóúÁÉÍÓÚñÑ".Contains(e.KeyChar.ToString())) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela la entrada si no es un carácter permitido
            }
        }

        private void frm2Ord_Shown(object sender, EventArgs e)
        {
            if (cbCli.Items.Count == 0 || cbTec.Items.Count == 0)
            {

                MessageBox.Show("No hay datos de clientes o tecnicos");
                this.Close();
            }
            cbTec.SelectedIndex = 0;
            cbCli.SelectedIndex = 0;
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }
    }
}
