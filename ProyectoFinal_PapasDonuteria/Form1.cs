using ProyectoFinal_PapasDonuteria;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_PapasDonuteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}