using Microsoft.VisualBasic.Devices;
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
    public partial class FormEliminar : Form
    {
        ErrorProvider err = new ErrorProvider();
        public string usuario;
        public AdminBD conexion;
        Productos item = new Productos();
        public List<Productos> elementos;
        bool flag = false;
        public FormEliminar(string usuario)
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
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
        private void buttonCaragr_Click(object sender, EventArgs e)
        {
            if (error(textBoxId.Text)){
                err.SetError(textBoxId, "Ingrese un id valido!");
                return;
            }
            int id = int.Parse(textBoxId.Text);
            string imagen;
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
                item = conexion.consultaUnRegistro(id);
                textBoxNombre.Text = item.Nombre.ToString();
                textBoxDescri.Text = item.Descripcion.ToString();
                textBoxPrecio.Text = item.Precio.ToString();
                textBoxTipo.Text = item.Tipo.ToString();
                textBoxImagen.Text = item.Imagen.ToString();
                textBoxExistencia.Text = item.Existencia.ToString();
                imagen = item.Imagen.ToString();

                this.pictureBoxImg.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", imagen));

            }
            else
            {
                MessageBox.Show("El producto no existe en la base de datos");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (error(textBoxId.Text))
            {
                err.SetError(buttonEliminar, "Por favor, cargue un elemento!");
                return;
            }
            int id = int.Parse(textBoxId.Text);
            if (flag && id >= 0)
            {
                if(MessageBox.Show("¿Esta seguro que quiere eliminar el elemento? Los cambios seran permanentes","Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (elementos.Count < 6)
                    {
                        MessageBox.Show("No se pueden eliminiar mas elementos!. \nRazon: deben de haber minimo 6 elementos");

                    }
                    else
                    {
                        conexion.eliminar(id);
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor: cargue un elemento valido");
            }

            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxDescri.Text = "";
            textBoxPrecio.Text = "";
            textBoxTipo.Text = "";
            textBoxImagen.Text = "";
            textBoxExistencia.Text = "";

            flag = false;
        }

        private bool error(string str)
        {
            if (str == "")
            {
                return true;
            }
            return false;
        }
    }
}
