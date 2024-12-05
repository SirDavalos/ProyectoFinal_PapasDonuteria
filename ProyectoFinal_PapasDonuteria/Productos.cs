using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PapasDonuteria
{
    public class Productos
    {
        private int id;
        private int tipo;
        private string nombre;
        private string imagen;
        private double precio;
        private int existencia;

        public Productos() { }
        public Productos(int id, int tipo, string nombre, string imagen, double precio, int existencia)
        {
            this.id = id;
            this.tipo = tipo;
            this.nombre = nombre;
            this.imagen = imagen;
            this.precio = precio;
            this.existencia = existencia;
        }

        public int Id { get => id; set => id = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencia { get => existencia; set => existencia = value; }
    }
}
