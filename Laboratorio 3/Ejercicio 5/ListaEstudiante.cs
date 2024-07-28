using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3.Ejercicio_5
{
    internal class ListaEstudiante
    {
        public NodoEstudiante inicio;


        public ListaEstudiante()
        {
            inicio = null;

        }

        public bool vacia()
        {
            if (inicio == null)
                return true;
            else
                return false;

        }

        public void insertarAlInicio(Estudiante x)
        {
            NodoEstudiante nuevo = new NodoEstudiante(x);

            nuevo.sgte = inicio;
            nuevo.ant = null;

            if (inicio != null)
            {
                inicio.ant = nuevo;
            }
            inicio = nuevo;
        }

        public void insertarAlFinal(Estudiante valor)
        {
            NodoEstudiante nuevo = new NodoEstudiante(valor);

            if (inicio != null)
            {
                inicio = nuevo;
            }
            else
            {
                NodoEstudiante actual = inicio;
                while (actual.sgte != null)
                {
                    actual = actual.sgte;

                }
                nuevo.ant = actual;
                actual.sgte = nuevo;
            }


        }

        public void mostrarHaciaAdelante(ListBox lst)
        {
            NodoEstudiante actual = inicio;
            while (actual != null)
            {
                lst.Items.Add("Nombre del Estudiante: " + actual.info.nombre);
                lst.Items.Add("Codigo del Estudiante: " + actual.info.codigo);
                lst.Items.Add("Nota: " + actual.info.nota);
                actual = actual.sgte;
            }
        }


        public NodoEstudiante buscar(int codigo)
        {
            NodoEstudiante actual = inicio;

            while (actual != null)
            {
                if (actual.info.codigo.Equals(codigo))
                    return actual;
                actual = actual.sgte;
            }
            return null;
        }

        public void SepararAPyDE(ListaEstudiante AP, ListaEstudiante DA)
        {
            NodoEstudiante actual = inicio;

            if (actual != null)
            {
                if (actual.info.nota >= 12)
                {


                    AP.insertarAlFinal(actual.info);
                    actual = actual.sgte;
                    SepararAPyDE(AP, DA);


                }
                else
                {
                    DA.insertarAlFinal(actual.info);
                    actual = actual.sgte;
                    SepararAPyDE(AP, DA);

                }

            }
        }
    }
}
