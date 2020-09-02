using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaestroDet_WF
{
    public partial class frmMaestroDet : Form
    {
        public frmMaestroDet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Elementos del grid
            string Producto = txtProducto.Text;
            string Precio = txtPrecio.Text;
            string Cantidad = txtCantidad.Text;
            

            dtgDetalle.Rows.Add(new object[]{
                Producto, Precio, Cantidad,"&Eliminar"
            });

            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtProducto.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                VentaDB objVenta = new VentaDB();
                objVenta.Add(txtCliente.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
