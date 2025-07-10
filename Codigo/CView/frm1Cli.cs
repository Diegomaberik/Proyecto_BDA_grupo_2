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
    public partial class frm1Cli : Form
    {
        private C_Cliente cliente = new C_Cliente();
        private int posicion = 0;
        private int maximo = 0;
        private DataTable registros = new DataTable();

        public frm1Cli()
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

        private void frm1Cli_Load(object sender, EventArgs e)
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
                }
                else
                {
                    btnbck.Enabled = false;
                    btnnxt.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (load): " + ex.Message);
            }

        }

        private void cargaDatos(int indice)
        {
            try
            {
                DataRow fila = registros.Rows[indice];
                string id = fila[0] != DBNull.Value ? fila[0].ToString() : string.Empty;
                var ccli = cliente.GetCliente(id);
                // Carga datos 
                txtcod.Text = ccli.Id;
                txtnom.Text = ccli?.Nombre ?? string.Empty;
                txtced.Text = ccli?.Cedula ?? string.Empty;
                txtdir.Text = ccli?.Direccion ?? string.Empty;
                txttel.Text = ccli?.Telefono ?? string.Empty;
                txtcor.Text = ccli?.Correo ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (cargadatos) : " + ex.Message);
            }
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

        private void frm1Cli_Shown(object sender, EventArgs e)
        {
            if (maximo == 0)
            {
                MessageBox.Show("No hay clientes");
                this.Close();
            }
        }
    }
}
