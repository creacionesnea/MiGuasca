using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Accedo_a_BD_MySQL {
    class Listados {
        private String _error = "";
        MySqlConnection connection = new MySqlConnection();

        public String getError() {
            return _error ;
        }

        private void inicarConexion() {
            try {
                connection.ConnectionString = "Server=10.0.0.7; Database=mercadito; Uid=root; Pwd=Gabrielus84";
                connection.Open();
            } catch (MySqlException e) {
                _error = "(iniciarSesion) No se logró conectar a la base de datos.";
            }
        }
        private void cerrarConexion() {
            try {
                connection.Close();
            } catch (MySqlException e) {
                _error = "(cerrarSesion) Conexión cerrada.";
            }
        }

        public List<cProducto> listaProductos(){
            inicarConexion();
            try {
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "SELECT * FROM productos";
                MySqlDataReader lector = instruccion.ExecuteReader();
                cProducto producto = new cProducto();
                List<cProducto> productos = new List<cProducto>();
                while (lector.Read()) {
                    producto = new cProducto();
                    producto.Pk_Id_Prod = (int)lector["PK_ID_PROD"];
                    producto.Fk_Id_Cat = (int)lector["FK_ID_CAT"];
                    producto.Cod_Barra = lector["COD_BARRA"].ToString();
                    producto.Desc = lector["DESCR"].ToString();
                    producto.Precio = (Decimal)lector["PRECIO"];
                    producto.PrecioMay   = (Decimal)lector["PREMAY"];
                    producto.PrecioMin  = (Decimal)lector["PREMIN"];
                    producto.Stock = (int)lector["STOCK"];
                    producto.Activo = (int)lector["ACTIVO"];
                    productos.Add(producto);
                    _error = "(Listados.listaProductos) un producto al menos." + productos.Count;
                }
                cerrarConexion();
                return productos;
            } catch (MySqlException e) {
                _error = "(Listados.listaProductos) Error al recuperar Productos de la BD.\n" + e.Message ;
                return null;
            }
        }

    }
}
