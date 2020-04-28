using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP2_Dominguez
{
    public partial class VentanaInicio : Form
    {
        private List<Articulo> lista;
        public VentanaInicio()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            try
            {
                lista = articulo.Listar();

                dgvListadoArticulos.DataSource = lista;
                dgvListadoArticulos.Columns[0].Visible = false;
                dgvListadoArticulos.Columns[1].MinimumWidth = 50;
                dgvListadoArticulos.Columns[2].MinimumWidth = 100;
                dgvListadoArticulos.Columns[7].MinimumWidth = 50;
                dgvListadoArticulos.Columns[4].MinimumWidth = 75;
                dgvListadoArticulos.Columns[3].Visible = false;
                dgvListadoArticulos.Columns[5].MinimumWidth = 50;
                dgvListadoArticulos.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaAMArticulo ventanaAM = new VentanaAMArticulo();
            ventanaAM.ShowDialog();
            CargarDatos();
            
        }

        private void dgvListadoArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VentanaDetalles VD = new VentanaDetalles();

                Articulo articulo = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;

                VD.txtVDNombre.Text = articulo.Nombre.ToString();
                VD.txtVDMarca.Text = articulo.Marca.Descripcion.ToString();
                VD.txtVDCategoria.Text = articulo.Categoria.Descripcion.ToString();
                VD.txtVDCodArt.Text = articulo.CodArt.ToString();
                VD.txtVDDescripcion.Text = articulo.Descripcion.ToString();
                VD.txtVDPrecio.Text = articulo.Precio.ToString("F2");
                if (articulo.ImagenURL != "")
                    VD.picVDImagenURL.Load(articulo.ImagenURL);
                VD.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

            private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificar;

            modificar = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;

            VentanaAMArticulo ventanaAM = new VentanaAMArticulo(modificar);
            ventanaAM.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                int id = ((Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem).Id;
                if (MessageBox.Show("¿Seguro que desea eliminar?", "Eliminar articulo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    negocio.eliminar(id);
                    CargarDatos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            try
            {
                if (txtFiltrarNombre.Text == "")
                {
                    listafiltrada = lista;
                }
                else
                {
                listafiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(txtFiltrarNombre.Text.ToLower()));
                }
                dgvListadoArticulos.DataSource = listafiltrada;
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltrarMarca_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            try
            {
                if (txtFiltrarMarca.Text == "")
                {
                    listafiltrada = lista;
                }
                else
                {
                    listafiltrada = lista.FindAll(k => k.Marca.Descripcion.ToLower().Contains(txtFiltrarMarca.Text.ToLower()));
                }
                dgvListadoArticulos.DataSource = listafiltrada;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltrarCategoria_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            try
            {
                if (txtFiltrarCategoria.Text == "")
                {
                    listafiltrada = lista;
                }
                else
                {
                    listafiltrada = lista.FindAll(k => k.Categoria.Descripcion.ToLower().Contains(txtFiltrarCategoria.Text.ToLower()));
                }
                dgvListadoArticulos.DataSource = listafiltrada;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                VentanaDetalles VD = new VentanaDetalles();

                Articulo articulo = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;

                VD.txtVDNombre.Text = articulo.Nombre.ToString();
                VD.txtVDMarca.Text = articulo.Marca.Descripcion.ToString();
                VD.txtVDCategoria.Text = articulo.Categoria.Descripcion.ToString();
                VD.txtVDCodArt.Text = articulo.CodArt.ToString();
                VD.txtVDDescripcion.Text = articulo.Descripcion.ToString();
                VD.txtVDPrecio.Text = articulo.Precio.ToString("F2");
                if (articulo.ImagenURL != "")
                    VD.picVDImagenURL.Load(articulo.ImagenURL);
                VD.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
