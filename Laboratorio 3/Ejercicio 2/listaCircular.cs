using Laboratorio_3.Ejercicio_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3.Ejercicio_2
{
    internal class listaCircular
    {
        public nodoC inicio;

        public listaCircular()
        {
            inicio = null;
        }


        public bool vacia()
        {
            if (inicio == null) return true;
            else return false;
        }

        public void insertarC(int valor)
        {
            nodoC nuevoNodo, ultimo;
            nuevoNodo = new nodoC();
            nuevoNodo.info = valor;
            nuevoNodo.sgte = inicio;

            if(inicio == null) 
            {
                ultimo = nuevoNodo;
            }
            else
            {
                ultimo = inicio;
                while (ultimo.sgte != inicio) 
                {
                    ultimo = ultimo.sgte;
                }
            }
            inicio = nuevoNodo;
            ultimo.sgte = inicio;
        }

        public void Mostrar (ListBox lst)
        {
            nodoC actual = inicio;
            lst.Items.Clear();
            do
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
            while (actual != inicio);

        }

    }
}
