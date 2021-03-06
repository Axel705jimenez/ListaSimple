using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListaSimple
{
    class ListaSimple
    {
        private Nodo head;

        public Nodo Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        public ListaSimple()
        {
            head = null;
        }

        public void Agregar(Nodo n)
        {
            if (head == null)
            {
                head = n;
                head.Siguiente = head;
                return;
            }
            Nodo h = head;
            //Insertar al inicio
            if (n.Numero < head.Numero)
            {
                n.Siguiente = head;
                //recorrer la lista y buscar el ultimo nodo

                while (h.Siguiente != head)
                {
                    h = h.Siguiente;
                }
                h.Siguiente = n;
                //Al encontrarlo hacer que el sig de ese nodo sea n
                head = n;
                return;
            }
            //Insertar en medio o al final
            while (h.Siguiente != head)
            {
                if (n.Numero < h.Siguiente.Numero)
                {
                    break;
                }
                h = h.Siguiente;
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;

            //
        }
        public void Eliminar(int d)
        {
            if (head == null)
            {
                return;
            }
            Nodo h = head;
            if (head.Numero == d)
            {
                if (head.Siguiente == head)
                {
                    head = null;
                    return;
                }
                while (h.Siguiente != head)
                {
                    h = h.Siguiente;
                }
                h.Siguiente = head.Siguiente;
                head = head.Siguiente;
                return;
            }

            while (h.Siguiente != head)
            {
                if (h.Siguiente.Numero == d)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != head)
            {
                h.Siguiente = h.Siguiente.Siguiente;
            }
        }

        public void Guardar(string nombreArchivo)
        {
            Nodo h = head;
            if (head == null)
            {
                return;
            }
            nombreArchivo = "TestListaCircular";
            string path = @"c:\" + nombreArchivo + ".txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                do
                {
                    sw.WriteLine(h.Numero + " - " + h.Nombre + "\n ");
                    h = h.Siguiente;
                } while (h != head);
            }
            return;
        }
        public void Mostrar(string nombreArchivo)
        {
            nombreArchivo = "TestListaCircular";
            string[] lineas = File.ReadAllLines(@"c:\" + nombreArchivo + ".txt");
            foreach (string linea in lineas)
            {
                if (linea.Length == 0)
                {
                    continue;
                }
                String[] datos = linea.Split('-');
                int numero = int.Parse(datos[0]);
                string matricula = datos[0];
                string nombre = datos[0];
                string aPaterno = datos[0];
                string aMaterno = datos[0];
                string carrera = datos[0];
                int calificacion = int.Parse(datos[0]);
                Nodo n = new Nodo(numero, matricula, nombre, aPaterno, aMaterno, carrera, calificacion);
                Agregar(n);
            }

        }

        public override string ToString()
        {
            string lista = "Nodos:\n ";
            Nodo h = head;
            if (head == null)
            {
                return lista;
            }
            do
            {
                lista += h.Numero + " - " + h.Nombre + "\n ";
                h = h.Siguiente;
            } while (h != head);
            return lista;
        }
    }
}
