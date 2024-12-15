using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PapasDonuteria
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string cuenta;
        private string password;
        private double monto;
        private bool admin;
        
        public Usuario() { }
        public Usuario(int id, string nombre, string cuenta, string password, double monto, bool admin)
        {
            this.id = id;
            this.nombre = nombre;
            this.cuenta = cuenta;
            this.password = password;
            this.monto = monto;
            this.admin = admin;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Password { get => password; set => password = value; }
        public double Monto { get => monto; set => monto = value; }
        public bool Admin { get => admin; set => admin = value; }
    }
}
