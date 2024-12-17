using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            string cuenta = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            if (VerificarCredenciales(cuenta, contraseña))
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

        private bool VerificarCredenciales(string cuenta, string contraseña)
        {
            string connectionString = "Server=localhost;Database=papasdonuteria;Uid=root;Pwd=tu_contraseña;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM usuarios WHERE cuenta = @usuario AND contraseña = @contraseña";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", cuenta);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        int rol = Convert.ToInt32(reader["admin"]);

                        if (rol == 1)
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
