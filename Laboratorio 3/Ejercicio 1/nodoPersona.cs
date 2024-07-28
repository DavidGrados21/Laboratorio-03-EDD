using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class nodoPersona
    {
        string vnombre;
        int vedad;
        float vestatura;

        public string nombre
        {
            get { return vnombre; }
            set { vnombre = value; }
        }

        public int edad
        { 
            get { return vedad; } 
            set { vedad = value; }
        }

        public float estatura
        {
            get { return vestatura; }
            set { vestatura = value; }
        }

        public nodoPersona (string vnombre, int vedad, float vestatura)
        {
            nombre = vnombre;
            edad = vedad;
            estatura = vestatura;
        }
    }
}
