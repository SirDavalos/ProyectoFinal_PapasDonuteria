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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNom.Text;
            string numTarjeta = textBoxNumTarj.Text;
            string mes = textBoxMes.Text;
            string anio = textBoxAnio.Text;
            string PIN = textBoxPin.Text;
            Form8 form8 = new Form8();
            this.Hide();
            form8.ShowDialog();
            this.Show();
        }
    }
}
