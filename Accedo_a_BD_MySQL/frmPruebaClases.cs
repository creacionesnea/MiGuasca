using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accedo_a_BD_MySQL {
    public partial class frmPruebaClases : Form {
        public frmPruebaClases() {
            InitializeComponent();
        }

        private void cmdClientes_Click(object sender, EventArgs e) {

        }

        private void cmdProductos_Click(object sender, EventArgs e) {
            Listados lstProductos = new Listados();
            List<cProducto> productos = new List<cProducto>();
            productos = lstProductos.listaProductos();
            if (productos != null ) {
                dataGridView1.DataSource = productos;
                /* dataGridView1.Columns[0].HeaderText  = "ID";
                dataGridView1.Columns[1].HeaderText = "CATEGORIA";
                dataGridView1.Columns[1].HeaderText = "COD BARRA";
                dataGridView1.Columns[2].HeaderText = "DESCRIPCION";
                dataGridView1.Columns[3].HeaderText = "PRECIO";
                dataGridView1.Columns[4].HeaderText = "ID";
                dataGridView1.Columns[5].HeaderText = "ID"; */
                lblTitulo.Text = "Se encontraron " + productos.Count + " productos";
            } else {
                MessageBox.Show(lstProductos.getError());
            }
        }
    }
}
