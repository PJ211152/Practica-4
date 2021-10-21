using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4_Ej_1
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string sexo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
