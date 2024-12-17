using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient; 

namespace ProyectoLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
          
            string nombre = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

          
            if (VerificarCredenciales(nombre, contraseña))
            {
             
                Form siguienteForm = new Form3();
                this.Hide();
                siguienteForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarCredenciales(string nombre, string contraseña)
        {
           
            string connectionString = " ? "; // HACE FALTA AGREGAR LA BASE DE DATOS AQUIIIIII
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", nombre);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string rol = reader["Rol"].ToString(); 
                        if (rol == "admin")
                        {
                            MessageBox.Show("Bienvenido Administrador", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bienvenido Usuario", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
