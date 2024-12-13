using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PapasDonuteria
{
    public class Dona
    {
        private string forma;
        private string masa;
        private string glaseado;
        private double precio;
        private int cantidad;

        public Dona() { }
        public Dona(string forma, string masa, string glaseado, double precio, int cantidad)
        {
            this.Forma = forma;
            this.Masa = masa;
            this.Glaseado = glaseado;
            this.Precio = precio;
            this.cantidad = cantidad;
        }

        public string Forma { get => forma; set => forma = value; }
        public string Masa { get => masa; set => masa = value; }
        public string Glaseado { get => glaseado; set => glaseado = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
