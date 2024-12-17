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
            timerFechaHora.Tick += timerFechaHora_Tick;
            timerFechaHora.Start();

        }
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Altas formaltas = new Altas(usuario);
            this.Hide();
            formaltas.ShowDialog();
            this.Show();
            if (Logout.flag)
            {
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminar FE = new FormEliminar(usuario);
            this.Hide();
            FE.ShowDialog();
            this.Show();
            if (Logout.flag)
            {
                this.Close();
            }
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            FormListaProd formListaProd = new FormListaProd();
            this.Hide();
            formListaProd.ShowDialog();
            this.Show();
            if (Logout.flag)
            {
                this.Close();
            }
        }
    }
}
