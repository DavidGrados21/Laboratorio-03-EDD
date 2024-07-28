using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Ejercicio_2
{
    internal class nodoS
    {
        private string vinfo;
        private nodoS vsgte;
        private nodoS vant;

        public string info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public nodoS sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }
        public nodoS ant
        {
            get { return vant; }
            set { vant = value; }
        }

        public nodoS(string vinfo)
        {
            info = vinfo;
            sgte = null;
            ant = null;
        }

        public nodoS(string vinfo, nodoS vsgte, nodoS vant)
        {
            info = vinfo;
            sgte = vsgte;
            ant = vant;
        }

    }
}
