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
        }
    }
}
