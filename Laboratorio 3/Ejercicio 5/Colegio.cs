using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3.Ejercicio_5
{
    public partial class Colegio : Form
    {
        ListaEstudiante lista = new ListaEstudiante();
        ListaEstudiante Aprobados = new ListaEstudiante();
        ListaEstudiante Desaprobados = new ListaEstudiante();
        NodoEstudiante pbusquedad;

        public Colegio()
        {
            InitializeComponent();
        }

        private void btnInsartar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int codigo = int.Parse (txtCodigo.Text);
            int nota = int.Parse(numericUpDown1.Value.ToString());
            Estudiante UPN = new Estudiante(nombre,codigo, nota);

            if (nota >= 12) 
            { 
                lista.insertarAlInicio(UPN);
                //lstdatos.Items.Clear();
                lista.mostrarHaciaAdelante(lstdatos);
                lstdatos.Items.Add("------------------------------");
                txtNombre.Clear();
                txtCodigo.Clear();
                txtNombre.Focus();
            }
            else
            {
                lista.insertarAlFinal(UPN);
                txtNombre.Clear();
                txtCodigo.Clear();
                txtNombre.Focus();
                //lstdatos.Items.Clear(); 
                lista.mostrarHaciaAdelante(lstdatos);
                lstdatos.Items.Add("------------------------------");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int b = int.Parse (txtbuscar.Text);
            pbusquedad = lista.buscar(b);
            if(pbusquedad != null)
            {
                Estudiante x = pbusquedad.info;
                txtCodigo.Text = x.codigo.ToString();
            }
            else
                MessageBox.Show("No existe ese codigo");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            lista.SepararAPyDE(Aprobados, Desaprobados);
            lstdatos.Items.Add("Alumnos Aprobados");
            Aprobados.mostrarHaciaAdelante(lstdatos);
            lstdatos.Items.Add("Alumnos Desaprobados");
            Desaprobados.mostrarHaciaAdelante(lstdatos);
        }
    }
}
