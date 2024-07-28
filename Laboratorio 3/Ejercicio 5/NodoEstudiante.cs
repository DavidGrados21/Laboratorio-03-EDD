using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Ejercicio_5
{
    internal class NodoEstudiante
    {
        private Estudiante vinfo;
        private NodoEstudiante vsgte;
        private NodoEstudiante vant;

        public Estudiante info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }

        public NodoEstudiante sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }
        public NodoEstudiante ant
        {
            get { return vant; }
            set { vant = value; }
        }

        public NodoEstudiante()
        {

        }

        public NodoEstudiante(Estudiante vinfo)
        {
            info = vinfo;
            sgte = null;
            ant = null;

        }
        public NodoEstudiante(Estudiante vinfo, NodoEstudiante vsgte, NodoEstudiante vant)

        {
            this.info = vinfo;
            this.sgte = vsgte;
            this.ant = vant;


        }
    }
}
