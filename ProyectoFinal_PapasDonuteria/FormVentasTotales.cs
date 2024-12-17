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
    public partial class FormVentasTotales : Form
    {
        public FormVentasTotales()
        {
            InitializeComponent();

            timerFechaHora.Tick += timerFechaHora_Tick;
            timerFechaHora.Start();

        }
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

    }
}
