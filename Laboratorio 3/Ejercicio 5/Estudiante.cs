using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Ejercicio_5
{
    internal class Estudiante
    {

        private string vnombre;
        private int vcodigo;
        private int vnota;


        public int codigo
        {
            get { return vcodigo; }
            set { vcodigo = value; }
        }
        public string nombre
        {
            get { return vnombre; }
            set { vnombre = value; }
        }

        public int nota
        {
            get { return vnota; }
            set { vnota = value; }
        }

        public Estudiante(string vnombre, int vcodigo, int vnota)
        {
            codigo = vcodigo;
            nombre = vnombre;
            nota = vnota;
        }
    }
}
