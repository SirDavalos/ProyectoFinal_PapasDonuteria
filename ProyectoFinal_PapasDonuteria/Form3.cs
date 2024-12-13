﻿using System;
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
    public partial class Form3 : Form
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
        public Form3(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.labelUsuario.Text = usuario;
            this.labelUsuario.Left = this.Width - this.labelUsuario.Width - 35;
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
            this.listaElementos();

            pictureBoxForma.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", formas[indiceF].Imagen));
            pictureBoxMasa.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", masas[indiceM].Imagen));
            pictureBoxGlas.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", glaseados[indiceG].Imagen));
        }

        public void listaElementos()
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                switch (elementos[i].Tipo)
                {
                    case 0:
                        formas.Add(elementos[i]);
                        break;
                    case 1:
                        masas.Add(elementos[i]);
                        break;
                    case 2:
                        glaseados.Add(elementos[i]);
                        break;
                }
            }
        }

        private void buttonFormaL_Click(object sender, EventArgs e)
        {
            this.indiceF -= 1;
            if (indiceF < 0)
            {
                indiceF = formas.Count - 1;
            }
            if (formas[indiceF].Existencia > 0)
            {
                this.pictureBoxForma.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", formas[indiceF].Imagen));
            }
            else
            {
                this.pictureBoxForma.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }

            this.richTextBoxForma.Text = formas[indiceF].Descripcion;
        }

        private void buttonFormaR_Click(object sender, EventArgs e)
        {
            this.indiceF += 1;
            if (indiceF > formas.Count - 1)
            {
                indiceF = 0;
            }
            if (formas[indiceF].Existencia > 0)
            {
                this.pictureBoxForma.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", formas[indiceF].Imagen));
            }
            else
            {
                this.pictureBoxForma.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }

            this.richTextBoxForma.Text = formas[indiceF].Descripcion;
        }

        private void buttonMasaL_Click(object sender, EventArgs e)
        {
            this.indiceM -= 1;
            if (indiceM < 0)
            {
                indiceM = masas.Count - 1;
            }
            if (masas[indiceM].Existencia > 0)
            {
                this.pictureBoxMasa.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", masas[indiceM].Imagen));
            }
            else
            {
                this.pictureBoxMasa.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }

            this.richTextBoxMasa.Text = masas[indiceM].Descripcion;
        }

        private void buttonMasaR_Click(object sender, EventArgs e)
        {
            this.indiceM += 1;
            if (indiceM > masas.Count - 1)
            {
                indiceM = 0;
            }
            if (masas[indiceM].Existencia > 0)
            {
                this.pictureBoxMasa.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", masas[indiceM].Imagen));
            }
            else
            {
                this.pictureBoxMasa.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }

            this.richTextBoxMasa.Text = masas[indiceM].Descripcion;
        }

        private void buttonGlasL_Click(object sender, EventArgs e)
        {
            this.indiceG -= 1;
            if (indiceG < 0)
            {
                indiceG = glaseados.Count - 1;
            }
            if (glaseados[indiceG].Existencia > 0)
            {
                this.pictureBoxGlas.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", glaseados[indiceG].Imagen));
            }
            else
            {
                this.pictureBoxGlas.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }

            this.richTextBoxGlas.Text = glaseados[indiceG].Descripcion;
        }

        private void buttonGlasR_Click(object sender, EventArgs e)
        {
            this.indiceG += 1;
            if (indiceG > glaseados.Count - 1)
            {
                indiceG = 0;
            }
            if (glaseados[indiceG].Existencia > 0)
            {
                this.pictureBoxGlas.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", glaseados[indiceG].Imagen));
            }
            else
            {
                this.pictureBoxGlas.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }

            this.richTextBoxGlas.Text = glaseados[indiceG].Descripcion;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double precio;
            int cantidad = Convert.ToInt32(this.numUDCantidad.Value);
            precio = formas[indiceF].Precio + masas[indiceM].Precio + glaseados[indiceG].Precio;
            formas[indiceF].Existencia = formas[indiceF].Existencia - cantidad;
            masas[indiceM].Existencia = masas[indiceM].Existencia - cantidad;
            glaseados[indiceG].Existencia = glaseados[indiceG].Existencia - cantidad;
            pedido.Add(new Dona(formas[indiceF].Nombre, masas[indiceM].Nombre, glaseados[indiceG].Nombre, precio, cantidad));
            MessageBox.Show("Dona/s añadida/s al pedido");
            reiniciarImagenes();
        }

        private void buttonVPedido_Click(object sender, EventArgs e)
        {
            fechaSeleccionada = dateTimePickerEntrega.Value;
            string datosPedido = $"Fecha de Entrega: {fechaSeleccionada.ToString("dd/MM/yyyy")}\n\n";
            for (int i = 0; i < pedido.Count; i++)
            {
                datosPedido = datosPedido + $"Forma: {pedido[i].Forma}  Masa: {pedido[i].Masa}  Glaseado: {pedido[i].Glaseado}  ×{pedido[i].Cantidad} ... {pedido[i].Precio}\n";
            }
            MessageBox.Show(datosPedido);
        }

        public void reiniciarImagenes()
        {
            if (formas[indiceF].Existencia > 0)
            {
                this.pictureBoxForma.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", formas[indiceF].Imagen));
            }
            else
            {
                this.pictureBoxForma.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }
            if (masas[indiceM].Existencia > 0)
            {
                this.pictureBoxMasa.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", masas[indiceM].Imagen));
            }
            else
            {
                this.pictureBoxMasa.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }
            if (glaseados[indiceG].Existencia > 0)
            {
                this.pictureBoxGlas.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", glaseados[indiceG].Imagen));
            }
            else
            {
                this.pictureBoxGlas.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "Agotado.png"));
            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            fechaSeleccionada = dateTimePickerEntrega.Value;
            for (int i=0; i<formas.Count-1; i++)
                conexion.actualizar(formas[i].Id, formas[i].Tipo, formas[i].Nombre, formas[i].Imagen, formas[i].Precio, formas[i].Existencia);
            for (int i = 0; i < masas.Count - 1; i++)
                conexion.actualizar(masas[i].Id, masas[i].Tipo, masas[i].Nombre, masas[i].Imagen, masas[i].Precio, masas[i].Existencia);
            for (int i = 0; i < glaseados.Count - 1; i++)
                conexion.actualizar(glaseados[i].Id, glaseados[i].Tipo, glaseados[i].Nombre, glaseados[i].Imagen, glaseados[i].Precio, glaseados[i].Existencia);

        }
    }
}