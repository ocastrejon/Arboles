using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
            Arbol a = new Arbol();
            Vector v = new Vector();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Nodo n = new Nodo(Convert.ToInt32(txtBxDato.Text));
            a.agregar(n);
            txtBxDato.Clear();
        }

        private void bttnpreOrder_Click(object sender, EventArgs e)
        {
            txtBxPreInPost.Clear();
            txtBxPreInPost.Text = a.preOrder();
        }

        private void bttninOrder_Click(object sender, EventArgs e)
        {
            txtBxPreInPost.Clear();
            txtBxPreInPost.Text = a.inOrder();
        }

        private void bttnpostOrder_Click(object sender, EventArgs e)
        {
            txtBxPreInPost.Clear();
            txtBxPreInPost.Text = a.postOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBxVector.Clear();
            int[] z = new int[8];
                z = v.llenarVector();
            for (int i = 0; i < z.Length; i++)
                txtBxVector.Text += z[i].ToString() + Environment.NewLine;
        }

        private void bttnBusBinaria_Click(object sender, EventArgs e)
        {
            int a = v.busquedaBinaria(Convert.ToInt32(txtBxNumBuscar.Text));
            txtBxNumBuscar.Clear();
            txtBxNumBuscar.Text = a.ToString();
        }

        private void bttnBuscarArbol_Click(object sender, EventArgs e)
        {
            Nodo x = new Nodo(Convert.ToInt32(txtBxDato.Text));
            txtBxPreInPost.Text = a.buscar(x).ToString();
        }
    }
}
