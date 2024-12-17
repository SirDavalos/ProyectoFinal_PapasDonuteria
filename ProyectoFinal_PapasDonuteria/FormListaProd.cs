using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
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
    public partial class FormListaProd : Form
    {
        public string usuario;
        public AdminBD conexion;
        Productos item = new Productos();
        public List<Productos> elementos;
        bool flag = false;
        public FormListaProd()
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

        private void FormListaProd_Load(object sender, EventArgs e)
        {
            dataGridViewLista.DataSource = conexion.CrearDataTable();
        }
    }
}
