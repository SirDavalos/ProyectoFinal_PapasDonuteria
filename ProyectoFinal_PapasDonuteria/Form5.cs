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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            labelfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void buttonEfec_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
            this.Show();
        }

        private void buttonTarj_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.ShowDialog();
            this.Show();
        }
    }
}
