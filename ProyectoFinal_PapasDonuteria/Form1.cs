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
            
          
            Label universidadLabel = new Label();
            universidadLabel.Text = "Universidad Autónoma de Aguascalientes";
            universidadLabel.Font = new Font("Arial", 18, FontStyle.Bold);
            universidadLabel.TextAlign = ContentAlignment.MiddleCenter;
            universidadLabel.Dock = DockStyle.Top;
            universidadLabel.Height = 50;
            this.Controls.Add(universidadLabel);

  
            Label nombresLabel = new Label();
            nombresLabel.Text = "- Héctor Guerrero Villa\n- Angel Oziel Carrillo Díaz de León\n- Fernando Dávalos Gutiérrez\n- A. E. Domínguez Estrada\n- Diego Emilio Venegas Flores";
            nombresLabel.Font = new Font("Arial", 14);
            nombresLabel.Location = new Point(50, 300);
            nombresLabel.Size = new Size(this.ClientSize.Width - 100, 150);
            this.Controls.Add(nombresLabel);


            Button iniciarButton = new Button();
            iniciarButton.Text = "Iniciar";
            iniciarButton.Font = new Font("Arial", 12);
            iniciarButton.Size = new Size(100, 40);
            iniciarButton.Location = new Point((this.ClientSize.Width - iniciarButton.Width) / 2, 470);
            iniciarButton.Click += (sender, e) =>
            {
                Form form2 = new Form2(); 
                this.Hide();
                form2.ShowDialog();
                this.Show();
            };
            this.Controls.Add(iniciarButton);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este botón lleva al menú.");
        }
    }
}

