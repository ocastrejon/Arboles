using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Nodo
    {
        private int _dato;
        public int dato { get { return _dato; } set { _dato = value; } }

        public Nodo hiz { get; set; }
        public Nodo hid { get; set; }

        public Nodo(int dato)
        {

        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
