using Laboratorio_3.Ejercicio_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3.Ejercicio_4
{
    internal class listaDobleI
    {
        public nodoI inicioI;

        public listaDobleI()
        {
            inicioI = null;
        }
        public bool vacia()
        {
            if (inicioI == null) return true;
            else return false;
        }
        public void ordenar()
        {
            nodoI p, q;
            int aux;
            p = inicioI;

            while (p != null)
            {
                q = p.sgte;
                while (q != null)
                {
                    if (p.info < q.info)
                    {
                        aux = p.info;
                        p.info = q.info;
                        q.info = aux;
                    }
                    q = q.sgte;
                }
                p = p.sgte;
            }
        }
        public void InsertarAlInicio(int valor)
        {
            nodoI nuevo = new nodoI(valor);
            nuevo.sgte = inicioI;
            nuevo.ant = null;

            if (inicioI != null)
            {
                inicioI.ant = nuevo;
            }
            inicioI = nuevo;
        }
        public void mostrar(ListBox lst)
        {
            nodoI actual = inicioI;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }
    }
}
