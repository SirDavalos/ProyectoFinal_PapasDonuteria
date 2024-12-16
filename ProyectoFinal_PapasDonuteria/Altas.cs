using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal_PapasDonuteria
{
    public partial class Altas : Form
    {
        public string usuario;
        public AdminBD conexion;
        public List<Productos> elementos;
        public Altas(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.labelUsuario.Text = usuario;
            this.labelUsuario.Left = this.Width - this.labelUsuario.Width - 145;
            elementos = new List<Productos>();
            this.conexion = new AdminBD();
            elementos = conexion.consulta();

            timerFechaHora.Tick += timerFechaHora_Tick;
            timerFechaHora.Start();

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Logout salir = new Logout();
            salir.ShowDialog();
            if (Logout.flag)
            {
                this.Close();
            }
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int id;
            int tipo;
            string nombre;
            string imagen;
            double precio;
            int existencia;
            string descripcion;

            id = Convert.ToInt32(textBoxId.Text);

            for (int i = 0; i < elementos.Count; i++)
            {
                if (id == elementos[i].Id)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show("Id no disponible");
            }
            else
            {
                tipo = Convert.ToInt32(textBoxTipo.Text);
                nombre = Convert.ToString(textBoxNombre.Text);
                imagen = Convert.ToString(textBoxImagen.Text);
                precio = Convert.ToDouble(textBoxPrecio.Text);
                existencia = Convert.ToInt32(textBoxExistencia.Text);
                descripcion = Convert.ToString(textBoxDescri.Text);

                if (pictureBoxImg.Image != null)
                {
                    try
                    {
                        // Ruta personalizada dentro de la aplicación
                        string carpetaPersonalizada = Path.Combine(System.Windows.Forms.Application.StartupPath, "Imagenes");

                        if (!Directory.Exists(carpetaPersonalizada))
                        {
                            Directory.CreateDirectory(carpetaPersonalizada);
                        }

                        string rutaPersonalizada = Path.Combine(carpetaPersonalizada, imagen);

                        // Guardar imagen en la ruta personalizada
                        pictureBoxImg.Image.Save(rutaPersonalizada);

                        MessageBox.Show($"Imagen guardada en: {rutaPersonalizada}");

                        // Ruta en el directorio de salida (bin\Debug\Release)
                        string carpetaSalida = Path.Combine(System.Windows.Forms.Application.StartupPath, "..", "..", "..", "bin", "Debug", "Imagenes");

                        if (!Directory.Exists(carpetaSalida))
                        {
                            Directory.CreateDirectory(carpetaSalida);
                        }

                        string rutaImagenSalida = Path.Combine(carpetaSalida, imagen);

                        // Guardar también la imagen en el directorio de salida
                        pictureBoxImg.Image.Save(rutaImagenSalida);

                        MessageBox.Show($"Imagen guardada en la carpeta de salida: {rutaImagenSalida}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la imagen: {ex.Message}");
                    }
                }

                // Realiza la operación de la base de datos
                conexion.insertar(id, tipo, nombre, imagen, descripcion, precio, existencia);
            }
        }


        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes|*.jpg;*.png;*.bmp;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxImg.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
