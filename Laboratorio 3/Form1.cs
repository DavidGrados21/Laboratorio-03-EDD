using Laboratorio_3.Ejercicio_2;
using Laboratorio_3.Ejercicio_3;
using Laboratorio_3.Ejercicio_4;
using Laboratorio_3.Ejercicio_5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Form1 : Form
    {
        listaDoble lista1 = new listaDoble();
        listaDobleS lista2 = new listaDobleS();
        listaDobleI lista3 = new listaDobleI();
        listaCircular lista4 = new listaCircular();
        public Form1()

        {
            InitializeComponent();
        }

        private void bntInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                String N;
                int E;
                float Es;

                N = textBox1.Text;
                E = int.Parse(textBox2.Text);
                Es = float.Parse(textBox3.Text);

                nodoPersona x = new nodoPersona(N, E, Es);

                lista1.insertarAlFinal(x);


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                listBox1.Items.Add("------------------------");
                lista1.mostrar(listBox1);
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void bntinsertarS_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    listBox1.Items.Clear();
                    String s;

                    s = txtstring.Text;
                    nodoS x = new nodoS(s);

                    lista2.insertarAlFinal(s);

                    txtstring.Clear();
                    txtstring.Focus();
                    lista2.mostrar(listBox1);
                }
                if (radioButton2.Checked == true)
                {
                    listBox1.Items.Clear();
                    int k;

                    k = int.Parse (txtstring.Text);
                    nodoI x = new nodoI(k);

                    lista3.InsertarAlInicio(k);

                    txtstring.Clear();
                    txtstring.Focus();
                    lista3.ordenar();
                    lista3.mostrar(listBox1);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtstring.Clear();

            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (!TxteliminarS.Text.Equals(""))
            {
                String l = TxteliminarS.Text;
                bool exito = lista2.eliminar(l);
                if (exito)
                {
                    MessageBox.Show("Dato Suprimido");
                    listBox1.Items.Clear();
                    lista2.mostrar(listBox1);
                }
                else
                {
                    MessageBox.Show("el dato no se encuentra en la lista o ya ha sido eliminado");
                }

            }
        }

        private void btnCircular_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int t;

                t = int.Parse (txtstring.Text);
                nodoC x = new nodoC(t);

                lista4.insertarC(t);

                txtstring.Clear();
                txtstring.Focus();
                lista4.Mostrar(listBox1);

            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtstring.Clear();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ejercico5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Colegio();
            ventana.Show();
        }
    }
}
