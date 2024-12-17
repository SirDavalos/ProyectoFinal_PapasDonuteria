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
    public partial class Logout : Form
    {
        public static bool flag;
        public Logout()
        {
            InitializeComponent();
            flag = false;
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }
    }
}
