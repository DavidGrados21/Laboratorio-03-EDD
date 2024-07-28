using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    internal class listaDoble
    {
        public nodo inicio;


        public listaDoble()
        {
            inicio = null;
        }
        public bool vacia()
        {
            if (inicio == null) return true;
            else return false;
        }

        public void insertarAlFinal(nodoPersona valor)
        {
            nodo nuevo = new nodo(valor);

            if (inicio == null)
                inicio = nuevo;
            else
            {
                nodo actual = inicio;
                while (actual.sgte != null)
                {
                    actual = actual.sgte;
                }
                nuevo.ant = actual;
                actual.sgte = nuevo;
            }
        }
        public void mostrar(ListBox lst)
        {
            nodo actual = inicio;

            while (actual.sgte != null)
            {
                actual = actual.sgte;
            }

            while (actual != null)
            {

                lst.Items.Add(actual.info.nombre);
                lst.Items.Add(actual.info.edad);
                lst.Items.Add(actual.info.estatura);
                lst.Items.Add("------------------------");

                actual = actual.ant;
            }

        }

    }
}
