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
using Microsoft.Win32;

namespace CView
{
    public partial class frm1Ser : Form
    {
        private C_Servicio servicio = new C_Servicio();
        private int posicion = 0;
        private int maximo = 0;
        private DataTable registros;

        public frm1Ser()
        {
            InitializeComponent();
        }

        private void CargarRegistros()
        {

            {
                try
                {
                    registros = new DataTable();
                    registros = servicio.GetServicios();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar registros: " + ex.Message);
                }
            }
        }

        private void frm1Ser_Load(object sender, EventArgs e)
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
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private int cargaDatos(int indice)
        {
            int resp = 0;
            try
            {
                DataRow fila = registros.Rows[indice];
                var cser = servicio.GetServicio(Convert.ToInt32(fila[0]));
                // Carga datos 
                txtcod.Text = Convert.ToString(cser.Id);
                txtnom.Text = cser.Descri;
                txtref.Text = cser.Refere;
                nmvalor.Value = cser.Prcvta;
                resp = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
            return resp;
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

        private void frm1Ser_Shown(object sender, EventArgs e)
        {
            if (maximo == 0)
            {
                MessageBox.Show("No hay servicios");
                this.Close();
            }
        }
    }
}
