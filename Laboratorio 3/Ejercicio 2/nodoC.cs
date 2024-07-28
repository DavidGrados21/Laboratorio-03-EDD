using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Ejercicio_3
{
    internal class nodoC
    {
        private int vinfo;
        private nodoC vsgte;

        public int info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public nodoC sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public nodoC()
        {
            info = 0;
            sgte = null;
        }

        public nodoC(int vinfo)
        {
            info = vinfo;
            sgte = null;
        }

        public nodoC(int vinfo, nodoC vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }

    }
}
