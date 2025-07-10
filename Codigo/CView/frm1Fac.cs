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
    public partial class frm1Fac : Form
    {
        private C_Cliente cliente = new C_Cliente();
        private C_Tecnico tecnico = new C_Tecnico();
        private C_Factura factura = new C_Factura();
        private C_Orden orden = new C_Orden();
        private C_OrdDet orddet = new C_OrdDet();
        private C_FacDet facdet = new C_FacDet();
        private int posicion = 0;
        private int maximo = 0;
        private DataTable registros;

        public frm1Fac()
        {
            InitializeComponent();
        }

        private void CargarRegistros()
        {

            {
                try
                {
                    registros = new DataTable();
                    registros = factura.GetFacturas();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar registros: " + ex.Message);
                }
            }
        }

        private void frm1Fac_Load(object sender, EventArgs e)
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
                var cfac = factura.GetFactura(Convert.ToInt32(fila[0]));
                var cord = orden.GetOrden(cfac.Id_ord);

                // Carga datos 
                txtobsini.Text = cfac.Obsini;
                txtobsfin.Text = cfac.Obsfin;
                dtfecfac.Value = cfac.Fecfac;


                txtmar.Text = cord.Marca;
                txtser.Text = cord.Imei;
                txtmod.Text = cord.Modelo;                
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

                txtsubtot.Text = cfac.Totbru.ToString("C2", new System.Globalization.CultureInfo("es-EC"));
                txttotimp.Text = cfac.Totiva.ToString("C2", new System.Globalization.CultureInfo("es-EC"));
                txttotal.Text = cfac.Totnet.ToString("C2", new System.Globalization.CultureInfo("es-EC"));
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

        private void frm1Fac_Shown(object sender, EventArgs e)
        {
                if (maximo == 0)
                {
                    MessageBox.Show("No hay facturas");
                    this.Close();
                }
           
        }
    }
}
