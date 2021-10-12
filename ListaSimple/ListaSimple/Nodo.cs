using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    class Nodo
    {
        protected int numero;
        protected string matricula;
        protected string nombre;
        protected string aPaterno;
        protected string aMaterno;
        protected string carrera;
        protected int calificacion;
        protected Nodo siguiente;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string APaterno
        {
            get { return aPaterno; }
            set { aPaterno = value; }
        }


        public string AMaterno
        {
            get { return aMaterno; }
            set { aMaterno = value; }
        }


        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo()
        {
            numero = 0;
            matricula = "";
            nombre = "";
            aPaterno = "";
            aMaterno = "";
            carrera = "";
            calificacion = 0;
            siguiente = null;
        }
        public Nodo(int num, string mat, string nom, string app, string apm, string car, int cal)
        {
            numero = num;
            matricula = mat;
            nombre = nom;
            aPaterno = app;
            aMaterno = apm;
            carrera = car;
            calificacion = cal;
            siguiente = null;
        }
        public override string ToString()
        {
            return numero + " - " + matricula + " - " + nombre + " - " + aPaterno + " - " + AMaterno + " - " + carrera + " - " + calificacion;
        }
    }
}
