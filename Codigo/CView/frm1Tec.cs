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
    public partial class frm1Tec : Form
    {
        private C_Tecnico tecnico = new C_Tecnico();
        private int posicion = 0;
        private int maximo = 0;
        private DataTable registros;

        public frm1Tec()
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

        private void frm1Tec_Load(object sender, EventArgs e)
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

        private int cargaDatos(int indice)
        {
            Console.WriteLine(indice);
            int resp = 0;
            try
            {
                DataRow fila = registros.Rows[indice];
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (cargadatos) : " + ex.Message);
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

        private void frm1Tec_Shown(object sender, EventArgs e)
        {
            if (maximo == 0)
            {
                MessageBox.Show("No hay tecnicos");
                this.Close();
            }
        }
    }
}
