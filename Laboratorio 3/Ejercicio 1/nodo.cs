using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class nodo
    {
        private nodoPersona vinfo;
        private nodo vsgte;
        private nodo vant;

        public nodoPersona info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public nodo sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }
        public nodo ant
        {
            get { return vant; }
            set { vant = value; }
        }

        public nodo()
        {

        }

        public nodo(nodoPersona vinfo)
        {
            info = vinfo;
            sgte = null;
            ant = null;
        }

        public nodo(nodoPersona vinfo, nodo vsgte, nodo vant)
        {
            info = vinfo;
            sgte = vsgte;
            ant = vant;
        }
    }
}
