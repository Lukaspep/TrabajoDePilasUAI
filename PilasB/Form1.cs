using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasB
{
    public partial class Form1 : Form
    {
        Pila1 MiPila = new Pila1 ();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMiNodo.Text , out int numero)) {
                
                
                
                numero1 unNuevoNodo = new numero1();
                unNuevoNodo.Nombre = numero.ToString();
                MiPila.Apilar(unNuevoNodo);
                MostrarPila();
            }
            else
            {
                MessageBox.Show("Por favor, Ingrese un numero valido");
            }
            
        }

        void MostrarPila()
        {
            lstPila.Items.Clear();
            if (MiPila.tope() != null)
            {
                MostrarNodoEnLista(MiPila.tope());
            }
            

        }

        void MostrarNodoEnLista(numero1 unNodo)
        {
            lstPila.Items.Add(unNodo.Nombre);
            if (unNodo.Siguiente != null)
            {
                MostrarNodoEnLista (unNodo.Siguiente);
            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            MiPila.Desapilar();
            MostrarPila();
        }

        private void txtMiNodo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
