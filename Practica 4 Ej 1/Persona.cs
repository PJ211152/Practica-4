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

    class Empleado : Persona 
    {
        private string cargo;
        private double salario;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }

    class Estudiante : Persona
    {
        private string numero_carnet;
        private string nivel_estudios;

        public string Numero_carnet
        {
            get { return numero_carnet; }
            set { numero_carnet = value; }
        }

        public string Nivel_estudio
        {
            get { return nivel_estudios; }
            set { nivel_estudios = value; }
        }

        public Estudio()
        {
            string nivel;

            
        }
    }


}
