using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Accedo_a_BD_MySQL {
    public partial class frmPrueba : Form {
        MySqlConnection connection;
        private void iniciarConexion() {
            try {
                connection = new MySqlConnection();
                connection.ConnectionString = "Server=localhost; Database=mercadito; Uid=root; Pwd=Gabrielus84";
                connection.Open();
                lblTitulo.Text = "(iniciarConexion) Se logró conectar a la base de datos.";
            } catch (MySqlException e) {
                lblTitulo.Text = "(iniciarConexion) No se logró conectar a la base de datos.";
                MessageBox.Show(e.Message);
            }
        }
        private void cerrarConexion() {
            try {
                connection.Close();
            } catch (MySqlException e) {
                lblTitulo.Text = "(cerrarConexion) Conexión cerrada.";
                MessageBox.Show(e.Message);
            }
        }
        public frmPrueba() {
            InitializeComponent();
            iniciarConexion();
        }

        private void frmPrueba_Load(object sender, EventArgs e) {
            //
        }

        private void cmdClientes_Click(object sender, EventArgs e) {
          
            try {
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText  = "SELECT * FROM clientes";
                MySqlDataReader lector = instruccion.ExecuteReader();
                lstDatos.Items.Clear();
                while (lector.Read()) {
                    lstDatos.Items.Add(lector["NOMBRE"].ToString());
                }
                lblTitulo.Text = "(cmdCliente.Click) Se recuperaron Clientes de la BD.";
                lector.Dispose();
            } catch {
                lblTitulo.Text = "(cmdClientes.Click) Error al recuperar Clientes de la BD.";
            }
        }

        private void frmPrueba_FormClosing(object sender, FormClosingEventArgs e) {
            cerrarConexion();
        }

        private void cmdProductos_Click(object sender, EventArgs e) {
            try {
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "SELECT * FROM productos";
                MySqlDataReader lector = instruccion.ExecuteReader();
                lstDatos.Items.Clear();
                while (lector.Read())
                {
                    lstDatos.Items.Add(lector["DESCR"].ToString());
                }
                lblTitulo.Text = "(cmdProductos.Click) Se recuperaron Productos de la BD.";
                lector.Dispose();
            }
            catch {
                lblTitulo.Text = "(cmdProductos.Click) Error al recuperar Productos de la BD.";
            }
        }

        private void btnNuevaVentana_Click(object sender, EventArgs e) {
            frmPruebaClases ventana = new frmPruebaClases();
            ventana.ShowDialog();
        }
    }
}
