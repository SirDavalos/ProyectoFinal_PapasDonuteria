using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_PapasDonuteria
{
    public partial class FormAdmin : Form
    {
        public string usuario;
        public AdminBD conexion;
        public List<Productos> elementos;
        public List<Productos> formas;
        public List<Productos> masas;
        public List<Productos> glaseados;
        public int indiceF;
        public int indiceM;
        public int indiceG;
        public List<Dona> pedido;
        DateTime fechaSeleccionada;
        public FormAdmin(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblNombreAdmin.Text = "Admin: " + usuario;
            elementos = new List<Productos>();
            formas = new List<Productos>();
            masas = new List<Productos>();
            glaseados = new List<Productos>();
            pedido = new List<Dona>();
            indiceF = 0;
            indiceG = 0;
            indiceM = 0;
            this.conexion = new AdminBD();
            elementos = conexion.consulta();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
