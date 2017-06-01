using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        Nodo raiz;

        public Arbol()
        {
            raiz = null;
        }

        public void agregar(Nodo nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                agregar(nuevo, raiz);
        }
        private void agregar(Nodo n, Nodo r)
        {
            if (n.dato < r.dato)
                if (r.hiz == null)
                    r.hiz = n;
                else agregar(n, r.hiz);
            else
                if (r.hid == null)
                r.hid = n;
            else agregar(n, r.hid);
        }

        //public string inOrder()
        //{

        //}
    }
}
