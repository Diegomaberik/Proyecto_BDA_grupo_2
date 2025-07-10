using CNego;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CView
{
    public partial class frm2Fac : Form
    {
        private C_Orden orden = new C_Orden();
        private C_Cliente cliente = new C_Cliente();
        private C_Tecnico tecnico = new C_Tecnico();
        private C_OrdDet orddet = new C_OrdDet();
        private int id_orden;
        private decimal total = 0;
        private decimal subtot = 0;
        private decimal totiva = 0;
        private decimal precio = 0;
        private C_Orden cord;

        public frm2Fac()
        {
            InitializeComponent();
        }

        private void frm2Fac_Load(object sender, EventArgs e)
        {
            try
            {
                this.Width = 815;
                this.Height = 185;
                CargaOrdenes();
                dgOrd.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (load): " + ex.Message);
            }
        }
        private void CargaOrdenes()
        {
            dgOrd.DataSource = orden.GetOrdenes("A");
        }

        private void btnup_Click(object sender, EventArgs e)
        {

            btndw.Visible = true;
            btnup.Visible = false;
            this.Height = 185;
            this.Width = 815;
            panel1.Visible = false;
            gb1.Enabled = true;
        }


        private void btndw_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dgOrd.CurrentRow;

            // Obtener valores de las celdas
            id_orden = Convert.ToInt32(selectedRow.Cells[0].Value);
            btndw.Visible = false;
            btnup.Visible = true;
            this.Height = 735;
            this.Width = 815;
            panel1.Visible = true;
            gb1.Enabled = false;
            CargaDatos();
            Totales();
        }


        private void CargaDatos()
        {
            try
            {
                cord = orden.GetOrden(id_orden);

                // Carga datos 
                txtmar.Text = cord.Marca;
                txtser.Text = cord.Imei;
                txtmod.Text = cord.Modelo;
                txtobsini.Text = cord.Observ;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (cargadatos) : " + ex.Message);
            }

        }


        private void Totales()
        {
            int cantidad = 0;
            string tipo;

            foreach (DataGridViewRow row in dgdet.Rows)
            {
                tipo = Convert.ToString(row.Cells[2].Value);
                if (tipo == "1")
                {
                    // Producto
                    precio = Convert.ToDecimal(row.Cells[6].Value.ToString());
                    cantidad = Convert.ToInt32(row.Cells[7].Value.ToString());
                    subtot = subtot + Math.Round(precio * cantidad, 2);

                }

                if (tipo == "2")
                {
                    // Servicio
                    precio = Convert.ToDecimal(row.Cells[6].Value.ToString());
                    subtot = subtot + precio;
                }

            }
            totiva = (subtot * 15) / 100;
            totiva = Math.Round(totiva, 2);
            total = subtot + totiva;

            txtsubtot.Text = subtot.ToString("C2", new System.Globalization.CultureInfo("es-EC"));
            txttotimp.Text = totiva.ToString("C2", new System.Globalization.CultureInfo("es-EC"));
            txttotal.Text = total.ToString("C2", new System.Globalization.CultureInfo("es-EC"));

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //Grabar Factura
            string tipo;
            int cantidad = 0;
            try
            {

                if (!ValidarDatos())
                {
                    MessageBox.Show("Debe llenar todos los campos para poder Grabar");
                    return;
                }

                C_Factura factura = new C_Factura();

                factura.Id_ord = id_orden;
                factura.Id_cli = cord.Id_cli;
                factura.Id_tec = cord.Id_tec;
                factura.Fecfac = DateTime.Now;
                factura.Obsini = txtobsini.Text;
                factura.Obsfin = txtobsfin.Text;
                factura.Totbru = subtot;
                factura.Totiva = totiva;
                factura.Totnet = total;
                factura.Estado = "1";

                int idfac = factura.GrabaFactura(factura);


                C_FacDet facdet = new C_FacDet();

                foreach (DataGridViewRow row in dgdet.Rows)
                {
                    facdet.Id_fac = idfac;


                    tipo = Convert.ToString(row.Cells[3].Value);
                    if (tipo == "1")
                    {
                        // Producto
                        facdet.Tipdet = 1;
                        facdet.Id_ite = 0;
                        facdet.Prcvta = Convert.ToDecimal(row.Cells[5].Value.ToString());
                        facdet.Cantid = Convert.ToInt32(row.Cells[6].Value.ToString());
                        facdet.Totnet = Math.Round(facdet.Prcvta * facdet.Cantid, 2);
                        facdet.GrabaDatos(facdet);

                    }

                    if (tipo == "2")
                    {
                        // Servicio
                        facdet.Tipdet = 2;
                        facdet.Id_ite = 0;
                        facdet.Prcvta = Convert.ToDecimal(row.Cells[5].Value.ToString());
                        facdet.Cantid = 1;
                        facdet.Totnet = facdet.Prcvta;
                        facdet.GrabaDatos(facdet);

                    }

                }

                MessageBox.Show("Factura grabada con éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error (save) : " + ex.Message);
            }
        }
        private bool ValidarDatos()
        {
            if (txtobsfin.Text.Length == 0) return false;

            return true;
        }

        private void frm2Fac_Shown(object sender, EventArgs e)
        {
            if (dgOrd.RowCount == 0)
            {
                MessageBox.Show("No hay ordenes activas");
                this.Close();
            }
        }

        private void dgOrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
