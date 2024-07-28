using Laboratorio_3.Ejercicio_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Ejercicio_4
{
    internal class nodoI
    {
        private int vinfo;
        private nodoI vsgte;
        private nodoI vant;

        public int info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public nodoI sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }
        public nodoI ant
        {
            get { return vant; }
            set { vant = value; }
        }

        public nodoI(int vinfo)
        {
            info = vinfo;
            sgte = null;
            ant = null;
        }

        public nodoI(int vinfo, nodoI vsgte, nodoI vant)
        {
            info = vinfo;
            sgte = vsgte;
            ant = vant;
        }
    }
}
