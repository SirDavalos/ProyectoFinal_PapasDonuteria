using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PapasDonuteria
{
    public class AdminBD
    {
        private MySqlConnection connection;

        public AdminBD()
        {
            this.Connect();
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=papasdonuteria; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public List<Productos> consulta()
        {
            List<Productos> data = new List<Productos>();
            Productos item;
            int id;
            int tipo;
            string nombre;
            string imagen;
            string descripcion;
            double precio;
            int existencia;

            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    tipo = Convert.ToInt32(reader["tipo"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToDouble(reader["precio"]);
                    existencia = Convert.ToInt32(reader["existencia"]);

                    item = new Productos(id, tipo, nombre, imagen, descripcion, precio, existencia);
                    data.Add(item);

                }
                reader.Close();
                data.ForEach((p) =>
                {
                    //MessageBox.Show(p.Id + "," + p.Producto + "," + p.Imagen + "," + p.Precio);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
        }

        public void insertar(int idp, int tipo, string prod, string img, string descr, double price, int exist)
        {
            string query = "";
            try
            {
                query = "INSERT INTO preductos (id,tipo,nombre,imagen,precio,existencia) VALUES ("
               + "'" + idp + "',"
               + "'" + tipo + "',"
               + "'" + prod + "',"
               + "'" + img + "', "
               + "'" + descr + "',"
               + "'" + price + "',"
               + "'" + exist + "')";



                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query+"\nRegistro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query +  "\nClave duplicada"+ex.Message);
                this.Disconnect();
            }


        }

        public Productos consultaUnRegistro(int idp)
        {
            Productos item = null;
            int id;
            int tipo;
            string nombre;
            string imagen;
            string descripcion;
            double precio;
            int existencia;
            try
            {
                string query = "SELECT * FROM productos where id=" + idp + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  //solo encontrara un registro da una vuelta
                {
                    id = Convert.ToInt32(reader["id"]);
                    tipo = Convert.ToInt32(reader["tipo"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToDouble(reader["precio"]);
                    existencia = Convert.ToInt32(reader["existencia"]);

                    item = new Productos(id, tipo, nombre, imagen, descripcion, precio, existencia);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }


        public void eliminar(int idp)
        {
            string query = "";
            try
            {
                query = "DELETE FROM productos WHERE id=" + idp + ";";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }


        public void actualizar(int idp, int tipo, string prod, string img, string descr, double price, int exist)
        {
            try
            {
                string query = "UPDATE producto SET id=" + "'" + idp + "'" + ",tipo=" + "'" + tipo + "'" + ",nombre=" + "'" + prod + "'" + ",imagen=" + "'" + img + "'" + ",descripcion=" + "'" + descr + "'" + ",precio=" + "'" + price + "'" + ",existencia=" + "'" + exist + "'" + "where id=" + idp + ";";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);
                this.Disconnect();
            }
        }

        public bool inicioSesion(string user, string passu)
        {
            bool flagAcceso = false;
            bool flagEncontrado = false;
            int id;
            string nombre;
            string cuenta;
            string password;
            double monto;
            bool admin;

            try
            {
                string query = "SELECT * FROM usuarios where cuenta=" + user + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    flagEncontrado = true;
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    password = Convert.ToString(reader["contraseña"]) ?? "";
                    monto = Convert.ToDouble(reader["monto"]);
                    admin = Convert.ToBoolean(reader["admin"]);

                    if (password != passu)
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                    else
                    {
                        flagAcceso = true;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            if (!flagEncontrado)
            {
                MessageBox.Show("Usuario Inexistente");
            }
            return flagAcceso;
        }

        /* datosUser se encarga de recuperar los datos del usuario cuando ya hicieron login para mostrarse en pantalla, aún hay detalles
           porque ocupo encontrar una forma de pasar el flag de acceso y/o encontrar una manera que no acceda incluso con los datos incorrectos
           para poder pasar simplemente la id, o talves también pudera acceder con el nombre pero ahí chéquenle
         */
        public Usuario datosUser(string acc)
        {
            Usuario user = null;
            int id;
            string nombre;
            string cuenta;
            string password;
            double monto;
            bool admin;

            try
            {
                string query = "SELECT * FROM usuarios where cuenta=" + acc + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    password = Convert.ToString(reader["contraseña"]) ?? "";
                    monto = Convert.ToDouble(reader["monto"]);
                    admin = Convert.ToBoolean(reader["admin"]);
                    user = new Usuario(id, nombre, cuenta, password, monto, admin);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return user;
        }

        public void actualizarMonto(string acc, double monto)
        {
            Usuario user = datosUser(acc);
            double montoT = monto + user.Monto;
            try
            {
                string query = "UPDATE usuarios SET id=" + "'" + user.Id + "'" + ",nombre=" + "'" + user.Nombre + "'" + ",cuenta=" + "'" + user.Cuenta + "'" + ",contraseña=" + "'" + user.Password + "'" + ",monto=" + "'" + montoT + "'" + ",admin=" + "'" + user.Admin + "'" + "where id=" + user.Id + ";";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);
                this.Disconnect();
            }
        }
    }
}
