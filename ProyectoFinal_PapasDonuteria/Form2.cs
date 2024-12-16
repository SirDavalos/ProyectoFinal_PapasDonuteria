using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal_PapasDonuteria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            //NECESITO QUE COMPRUEBEN EL USUARIO Y LO MANDEN AQUI
            string usuario = textBoxUsuario.Text;
            if(usuario != "admin")
            {
                Form3 form3 = new Form3(usuario);
                this.Hide();
                form3.ShowDialog();
                this.Show();
            }
            else
            {
                FormAdmin formAdmin = new FormAdmin(usuario);
                this.Hide();
                formAdmin.ShowDialog();
                this.Show();
            }
        }
    }
}
