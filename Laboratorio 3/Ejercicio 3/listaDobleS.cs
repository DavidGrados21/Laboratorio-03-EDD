using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3.Ejercicio_2
{
    internal class listaDobleS
    {
        public nodoS inicioS;

        public listaDobleS()
        {
            inicioS = null;
        }
        public bool vacia()
        {
            if (inicioS == null) return true;
            else return false;
        }
        public void insertarAlFinal(String x)
        {
            nodoS nuevo = new nodoS(x);

            if (nuevo.info != "")
            {
                if (inicioS == null)
                    inicioS = nuevo;
                else
                {
                    nodoS actual = inicioS;
                    while (actual.sgte != null)
                    {
                        actual = actual.sgte;
                    }
                    nuevo.ant = actual;
                    actual.sgte = nuevo;
                }
            }

        }
        public void mostrar(ListBox lst)
        {
            nodoS actual = inicioS;

            while (actual.sgte!= null)
            {
                actual = actual.sgte;
            }

            while (actual != null)
            {

               lst.Items.Add(actual.info);

               actual = actual.ant;
            }
        }
        public bool eliminar(string valor)
        {
            if (inicioS.info == valor)
            {
                inicioS = inicioS.sgte;
                return true;
            }
            else
            {
                nodoS anterior = inicioS;
                nodoS actual = inicioS.sgte;
                while (actual != null && actual.info != valor)
                {
                    anterior = actual;
                    actual = actual.sgte;
                }
                if (actual != null)
                {
                    anterior.sgte = actual.sgte;
                    actual.sgte.ant = anterior;
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
