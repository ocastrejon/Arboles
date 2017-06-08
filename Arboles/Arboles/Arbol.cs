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

        public void buscar()
        {
            //Falta este
        }

        public string inOrder()
        {
            if (raiz == null)
                return "";
            else
                return inOrder(raiz);
        }

        private string inOrder(Nodo r)
        {
            string res = "";

            //I
            if (r.hiz != null)
                res += inOrder(r.hiz);
            //R
            res += r.ToString();
            //D
            if (r.hid != null)
                res += inOrder(r.hid);

            return res;
        }

        public string postOrder()
        {
            if (raiz == null)
                return "";
            else
                return postOrder(raiz);
        }

        private string postOrder(Nodo r)
        {
            string res = "";

            //I
            if (r.hiz != null)
                res += postOrder(r.hiz);
            //D
            if (r.hid != null)
                res += postOrder(r.hid);
            //R
            res += r.ToString();

            return res;
        }

        public string preOrder()
        {
            if (raiz == null)
                return "";
            else
                return preOrder(raiz);
        }

        private string preOrder(Nodo r)
        {
            string res = "";

            //R
            res += r.ToString();
            //I
            if (r.hiz != null)
                res += preOrder(r.hiz);
            //D
            if (r.hid != null)
                res += preOrder(r.hid);

            return res;
        }
    }
}
