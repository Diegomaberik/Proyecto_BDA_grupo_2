using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNego;
using CData;

namespace CView
{
    public partial class frm1Ord : Form
    {
        private C_Orden orden = new C_Orden();
        private C_Cliente cliente = new C_Cliente();
        private C_Tecnico tecnico = new C_Tecnico();
        private C_OrdDet orddet = new C_OrdDet();
        private int posicion = 0;
        private int maximo = 0;
        private DataTable registros;

        public frm1Ord()
        {
            InitializeComponent();
        }

        private void CargarRegistros()
        {

            {
                try
                {
                    registros = new DataTable();
                    registros = orden.GetOrdenes("T");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar registros: " + ex.Message);
                }
            }
        }

        private void frm1Ord_Load(object sender, EventArgs e)
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
                var cord = orden.GetOrden(Convert.ToInt32(fila[0]));

                // Carga datos 
                txtid.Text = Convert.ToString(cord.Id);
                txtmar.Text = cord.Marca;
                txtser.Text = cord.Imei;
                txtmod.Text = cord.Modelo;
                txtobs.Text = cord.Observ;
                dtfecing.Value = cord.Fecing;

                //Cliente                
                var ccli = cliente.GetCliente(cord.Id_cli);
                txtcliced.Text = ccli.Cedula;
                txtclinom.Text = ccli.Nombre;
                txtclidir.Text = ccli.Direccion;
                txtclitel.Text = ccli.Telefono;

                //Tecnico
                var ctec = tecnico.GetTecnico(cord.Id_tec);
                txttecced.Text = ctec.Cedula;
                txttecnom.Text = ctec.Nombre;

                //Detalles
                dgdet.DataSource = orddet.GetDetalles(cord.Id);

                if (cord.Estado == "0")
                {
                    lbinfo.Text = "ACTIVO";
                    lbfac.Visible = false;
                    dtfecfac.Visible = false;

                }
                else
                {
                    lbinfo.Text = "FACTURADO";
                    lbfac.Visible = true;
                    dtfecfac.Visible = true;
                    if (cord.Fecfac.HasValue)
                    {
                        dtfecfac.Value = cord.Fecfac.Value;
                    }
                    else
                    {
                        dtfecfac.Value = DateTime.Now;
                    }

                }
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

        private void frm1Ord_Shown(object sender, EventArgs e)
        {
            if (maximo == 0)
            {
                MessageBox.Show("No hay ordenes");
                this.Close();
            }
        }
    }
}
