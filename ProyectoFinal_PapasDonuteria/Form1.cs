using System;
using System.Drawing;
using System.Windows.Forms;

namespace PortadaApp
{
    public class PortadaForm : Form
    {
        public PortadaForm()
        {

            this.Text = "Portada";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

 
            Label universidadLabel = new Label();
            universidadLabel.Text = "Universidad Autónoma de Aguascalientes";
            universidadLabel.Font = new Font("Arial", 18, FontStyle.Bold);
            universidadLabel.TextAlign = ContentAlignment.MiddleCenter;
            universidadLabel.Dock = DockStyle.Top;
            universidadLabel.Height = 50;
            this.Controls.Add(universidadLabel);


            PictureBox logoPictureBox = new PictureBox();
            logoPictureBox.Image = Image.FromFile("ruta_del_logo.png"); 
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.Size = new Size(200, 200);
            logoPictureBox.Location = new Point((this.ClientSize.Width - logoPictureBox.Width) / 2, 70);
            logoPictureBox.Anchor = AnchorStyles.Top;
            this.Controls.Add(logoPictureBox);


            Label nombresLabel = new Label();
            nombresLabel.Text = "- Héctor Guerrero Villa\n- Angel Oziel Carrillo Díaz de León\n- Fernando Dávalos Gutiérrez\n- A. E. Domínguez Estrada\n- Diego Emilio Venegas Flores"; 
            nombresLabel.Font = new Font("Arial", 14);
            nombresLabel.TextAlign = ContentAlignment.TopLeft;
            nombresLabel.Location = new Point(50, 300);
            nombresLabel.Size = new Size(this.ClientSize.Width - 100, 150);
            nombresLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Controls.Add(nombresLabel);

  
            Button iniciarButton = new Button();
            iniciarButton.Text = "Iniciar";
            iniciarButton.Font = new Font("Arial", 12);
            iniciarButton.Size = new Size(100, 40);
            iniciarButton.Location = new Point((this.ClientSize.Width - iniciarButton.Width) / 2, 470);
            iniciarButton.Anchor = AnchorStyles.Top;
            iniciarButton.Click += (sender, e) =>
            {
                Form siguienteFormulario = new Form2(); 
                this.Hide();
                siguienteFormulario.ShowDialog();
                this.Show();
            };
            this.Controls.Add(iniciarButton);

     
            Button salirButton = new Button();
            salirButton.Text = "Salir";
            salirButton.Font = new Font("Arial", 12);
            salirButton.Size = new Size(100, 40);
            salirButton.Location = new Point(20, this.ClientSize.Height - 60);
            salirButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            salirButton.Click += (sender, e) => this.Close();
            this.Controls.Add(salirButton);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PortadaForm());
        }
    }
}
